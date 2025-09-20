using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Contact_Manager_FL_MG_JW;
using Microsoft.VisualBasic.FileIO;

namespace Contact_Manager_FL_MG_JW
{
    public sealed class CsvImportSummary
    {
        public int InsertedGlobal { get; set; }
        public int InsertedKunden { get; set; }
        public int InsertedMitarbeiter { get; set; }
        public int InsertedLernende { get; set; }
        public int Skipped { get; set; }
        public List<string> Errors { get; } = new List<string>();
    }
    // CSV-Importer für Mitarbeiter und Geschäftskunden mit Auto-Erkennung.
    // - Schreibt immer zuerst einen Global-Datensatz.
    // - Entscheidet danach automatisch, ob Kunde oder Mitarbeiter angelegt wird.
    // - Optional: legt beim  Mitarbeiter, Lernender an, wenn entsprechende Spalten vorhanden sind.
    public sealed class CsvImporter
    {
        private readonly string _connectionString;
        private readonly CultureInfo _dateCulture = CultureInfo.GetCultureInfo("de-CH");

        public CsvImporter(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        #region Public API

        public CsvImportSummary Import(string csvPath)
        {
            if (string.IsNullOrWhiteSpace(csvPath)) throw new ArgumentNullException(nameof(csvPath));
            if (!File.Exists(csvPath)) throw new FileNotFoundException("CSV-Datei nicht gefunden.", csvPath);

            var summary = new CsvImportSummary();

            using var conn = new SQLiteConnection(_connectionString);
            conn.Open();

            using var tx = conn.BeginTransaction();

            //SQL Statement für die Globaltabelle
            using var cmdInsGlobal = new SQLiteCommand(@"
                INSERT INTO Global (Anrede, Titel, Vorname, Name, Geschlecht, `E-Mail`, Geburtstag, Status, Accounttyp)
                VALUES (@Anrede, @Titel, @Vorname, @Name, @Geschlecht, @Email, @Geburtstag, @Status, @Accounttyp);
                SELECT last_insert_rowid();", conn, tx);

            //SQL Statement für die Kundentabelle
            using var cmdInsKunde = new SQLiteCommand(@"
                INSERT INTO Kunde (kundentyp, firmenname, `geschäftsadresse`, `geschäftsnummer`, strasse, PLZ, Ort, telefon, Note, globalid)
                VALUES (@kundentyp, @firmenname, @geschaeftsadresse, @geschaeftsnummer, @strasse, @plz, @ort, @telefon, @Note, @globalid);", conn, tx);

            //SQL Statement für die Mitarbeitertabelle
            using var cmdInsMitarb = new SQLiteCommand(@"
                INSERT INTO Mitarbeiter (
                    Mitarbeiternummer, eintrittsdatum, strasse, PLZ, Ort, handynummer, beschäftigungsgrad, abteilung, kaderstufe,
                    ahvnummer, austrittsdatum, nationalität, standort, tätigkeitsbezeichnung, telefonnummerintern, globalid
                ) VALUES (
                    @Mitarbeiternummer, @eintritt, @strasse, @plz, @ort, @handy, @grad, @abteilung, @kader,
                    @ahv, @austritt, @nationalitaet, @standort, @taetigkeit, @telintern, @globalid
                );
                SELECT last_insert_rowid();", conn, tx);

            //SQL Statement für die Lernender Tabelle
            using var cmdInsLernender = new SQLiteCommand(@"
                INSERT INTO Lernender (lehrjahre, aktuelleslehrjahr, globalid)
                VALUES (@lehrjahre, @aktuelles, @globalid);", conn, tx);

            try
            {
                using var parser = CreateParser(csvPath);
                var headers = parser.ReadFields();
                if (headers == null || headers.Length == 0)
                    throw new InvalidOperationException("CSV enthaelt keine Headerzeile.");

                var H = BuildHeader(headers);

                while (!parser.EndOfData)
                {
                    string[]? row = null;
                    try
                    {
                        row = parser.ReadFields();
                        if (row == null || row.Length == 0) { summary.Skipped++; continue; }

                        // --- Global ---
                        string? anrede = FixUmlauts(Val(row, H, "Anrede"));
                        string? titel = FixUmlauts(Val(row, H, "Titel"));
                        string? vorname = FixUmlauts(Val(row, H, "Vorname"));
                        string? name = FixUmlauts(Val(row, H, "Name"));
                        string? geschl = FixUmlauts(Val(row, H, "Geschlecht"));
                        string? email = Val(row, H, "E-Mail", "Email", "Mail");
                        string? status = FixUmlauts(Val(row, H, "Status")) ?? "Aktiv";
                        string? acct = FixUmlauts(Val(row, H, "Accounttyp"));

                        string? gebStr = Val(row, H, "Geburtstag", "Geburtsdatum");
                        string? gebOut = ParseDate(gebStr);

                        cmdInsGlobal.Parameters.Clear();
                        cmdInsGlobal.Parameters.AddWithValue("@Anrede", anrede ?? (object)DBNull.Value);
                        cmdInsGlobal.Parameters.AddWithValue("@Titel", titel ?? (object)DBNull.Value);
                        cmdInsGlobal.Parameters.AddWithValue("@Vorname", vorname ?? (object)DBNull.Value);
                        cmdInsGlobal.Parameters.AddWithValue("@Name", name ?? (object)DBNull.Value);
                        cmdInsGlobal.Parameters.AddWithValue("@Geschlecht", geschl ?? (object)DBNull.Value);
                        cmdInsGlobal.Parameters.AddWithValue("@Email", email ?? (object)DBNull.Value);
                        cmdInsGlobal.Parameters.AddWithValue("@Geburtstag", (object?)gebOut ?? DBNull.Value);
                        cmdInsGlobal.Parameters.AddWithValue("@Status", status ?? (object)DBNull.Value);
                        cmdInsGlobal.Parameters.AddWithValue("@Accounttyp", acct ?? (object)DBNull.Value);

                        long globalId = (long)(long?)cmdInsGlobal.ExecuteScalar()!;
                        summary.InsertedGlobal++;

                        // --- Auto-Erkennung Kunde/Mitarbeiter ---
                        bool looksKunde = false, looksMitarb = false;

                        string? firmenname = FixUmlauts(Val(row, H, "Firmenname"));
                        string? gesAdr = FixUmlauts(Val(row, H, "Geschaeftsadresse", "Geschäftsadresse"));
                        string? gesNr = Val(row, H, "Geschaeftsnummer", "Geschäftsnummer");

                        if (!string.IsNullOrWhiteSpace(acct))
                        {
                            var a = acct.Trim().ToLowerInvariant();
                            if (a.Contains("kunde")) looksKunde = true;
                            if (a.Contains("mitarbeiter") || a.Contains("employee")) looksMitarb = true;
                        }

                        if (!looksKunde && !looksMitarb)
                        {
                            if (!string.IsNullOrWhiteSpace(firmenname) || !string.IsNullOrWhiteSpace(gesAdr) || !string.IsNullOrWhiteSpace(gesNr))
                                looksKunde = true;

                            string? anyMitarb = Val(row, H, "Mitarbeiternummer", "Eintrittsdatum", "Beschaeftigungsgrad", "Beschäftigungsgrad", "Abteilung", "Kaderstufe",
                                                       "AHVNummer", "AHV", "AHV-Nr", "AHVNr", "Nationalitaet", "Nationalität",
                                                       "Standort", "Taetigkeitsbezeichnung", "Tätigkeitsbezeichnung", "TelefonnummerIntern",
                                                       "Austrittsdatum");
                            if (!string.IsNullOrWhiteSpace(anyMitarb)) looksMitarb = true;
                        }

                        if (looksKunde && !looksMitarb)
                        {
                            // --- Kunde ---
                            string? strasse = FixUmlauts(Val(row, H, "Strasse (Kunde)", "Straße (Kunde)"));
                            string? plz = Val(row, H, "PLZ (Kunde)");
                            string? ort = FixUmlauts(Val(row, H, "Ort (Kunde)"));
                            string? tel = Val(row, H, "Telefon", "Telefonnummer", "Telefonnr/Handynr (Kunde)");
                            string? kundentyp = FixUmlauts(Val(row, H, "Kundentyp")) ?? "Geschaeftskunde";
                            string? notiz = Environment.NewLine + FixUmlauts(Val(row, H,"Notiz"));

                            cmdInsKunde.Parameters.Clear();
                            cmdInsKunde.Parameters.AddWithValue("@kundentyp", kundentyp ?? (object)DBNull.Value);
                            cmdInsKunde.Parameters.AddWithValue("@firmenname", firmenname ?? (object)DBNull.Value);
                            cmdInsKunde.Parameters.AddWithValue("@geschaeftsadresse", gesAdr ?? (object)DBNull.Value);
                            cmdInsKunde.Parameters.AddWithValue("@geschaeftsnummer", gesNr ?? (object)DBNull.Value);
                            cmdInsKunde.Parameters.AddWithValue("@strasse", strasse ?? (object)DBNull.Value);
                            cmdInsKunde.Parameters.AddWithValue("@plz", plz ?? (object)DBNull.Value);
                            cmdInsKunde.Parameters.AddWithValue("@ort", ort ?? (object)DBNull.Value);
                            cmdInsKunde.Parameters.AddWithValue("@telefon", tel ?? (object)DBNull.Value);
                            cmdInsKunde.Parameters.AddWithValue("@Note", notiz ?? (object)DBNull.Value);
                            cmdInsKunde.Parameters.AddWithValue("@globalid", globalId);
                            cmdInsKunde.ExecuteNonQuery();

                            summary.InsertedKunden++;
                        }
                        else
                        {
                            // Mitarbeiternummer aus CSV lesen
                            string? mitarbeiternummerStr = FixUmlauts(Val(row, H, "Mitarbeiternummer"));

                            object mitarbeiternummerParam;

                            if (string.IsNullOrWhiteSpace(mitarbeiternummerStr))
                            {
                                // Neue Nummer aus DB holen (MAX+1)

                                long nextMitarbNummer = 1;
                                using (var cmdMax = new SQLiteCommand("SELECT IFNULL(MAX(mitarbeiternummer), 0) + 1 FROM Mitarbeiter", conn))
                                {
                                    object? result = cmdMax.ExecuteScalar();
                                    if (result != null && result != DBNull.Value)
                                        nextMitarbNummer = Convert.ToInt64(result);
                                }

                                mitarbeiternummerParam = nextMitarbNummer;
                            }
                            else
                            {
                                mitarbeiternummerParam = mitarbeiternummerStr;
                            }




                            // --- Mitarbeiter ---
                            string? mitarbeiternummer = FixUmlauts(Val(row, H, "Mitarbeiternummer"));
                            string? strasse = FixUmlauts(Val(row, H, "Strasse (Mitarbeiter)", "Straße (Mitarbeiter)"));
                            string? plz = Val(row, H, "PLZ (Mitarbeiter)");
                            string? ort = FixUmlauts(Val(row, H, "Ort (Mitarbeiter)"));
                            string? handy = Val(row, H, "Handynummer", "Mobile", "TelefonMobil", "Mobiltelefon");

                            string? eintrittStr = Val(row, H, "Eintrittsdatum");
                            string? austrittStr = Val(row, H, "Austrittsdatum");
                            string? eintrittOut = ParseDate(eintrittStr);
                            string? austrittOut = ParseDate(austrittStr);

                            int? grad = ToInt(Val(row, H, "Beschaeftigungsgrad", "Beschäftigungsgrad"));
                            string? abt = FixUmlauts(Val(row, H, "Abteilung"));
                            string? kader = FixUmlauts(Val(row, H, "Kaderstufe"));
                            string? ahv = Val(row, H, "AHVNummer", "AHV", "AHV-Nr", "AHVNr");
                            string? nat = FixUmlauts(Val(row, H, "Nationalitaet", "Nationalität"));
                            string? stand = FixUmlauts(Val(row, H, "Standortadresse"));
                            string? taet = FixUmlauts(Val(row, H, "Taetigkeitsbezeichnung", "Tätigkeitsbezeichnung"));
                            string? telIn = Val(row, H, "TelefonnummerIntern", "TelIntern");


                            cmdInsMitarb.Parameters.Clear();
                            cmdInsMitarb.Parameters.AddWithValue("@Mitarbeiternummer", mitarbeiternummerParam);
                            cmdInsMitarb.Parameters.AddWithValue("@eintritt", (object?)eintrittOut ?? DBNull.Value);
                            cmdInsMitarb.Parameters.AddWithValue("@strasse", strasse ?? (object)DBNull.Value);
                            cmdInsMitarb.Parameters.AddWithValue("@plz", plz ?? (object)DBNull.Value);
                            cmdInsMitarb.Parameters.AddWithValue("@ort", ort ?? (object)DBNull.Value);
                            cmdInsMitarb.Parameters.AddWithValue("@handy", handy ?? (object)DBNull.Value);
                            cmdInsMitarb.Parameters.AddWithValue("@grad", (object?)grad ?? DBNull.Value);
                            cmdInsMitarb.Parameters.AddWithValue("@abteilung", abt ?? (object)DBNull.Value);
                            cmdInsMitarb.Parameters.AddWithValue("@kader", kader ?? (object)DBNull.Value);
                            cmdInsMitarb.Parameters.AddWithValue("@ahv", ahv ?? (object)DBNull.Value);
                            cmdInsMitarb.Parameters.AddWithValue("@austritt", (object?)austrittOut ?? DBNull.Value);
                            cmdInsMitarb.Parameters.AddWithValue("@nationalitaet", nat ?? (object)DBNull.Value);
                            cmdInsMitarb.Parameters.AddWithValue("@standort", stand ?? (object)DBNull.Value);
                            cmdInsMitarb.Parameters.AddWithValue("@taetigkeit", taet ?? (object)DBNull.Value);
                            cmdInsMitarb.Parameters.AddWithValue("@telintern", telIn ?? (object)DBNull.Value);
                            cmdInsMitarb.Parameters.AddWithValue("@globalid", globalId);

                            long Mitarbeiternummer = (long)(long?)cmdInsMitarb.ExecuteScalar()!;
                            summary.InsertedMitarbeiter++;

                            // Lernender
                            string? lehrlingStr = Val(row, H, "Lehrling");
                            bool isLehrling = false;

                            if (!string.IsNullOrWhiteSpace(lehrlingStr))
                            {
                                var normalized = lehrlingStr.Trim().ToLowerInvariant();
                                if (normalized is "1" or "ja" or "true" or "y" or "yes")
                                    isLehrling = true;
                            }
                            if (isLehrling)
                            {
                                string? lehrjahre = Val(row, H, "Anzahl Ausbildungsjahre");
                                string? aktuelles = Val(row, H, "Aktuelles Ausbildungsjahr", "AktuellesLehrjahr");
                                if (!string.IsNullOrWhiteSpace(lehrjahre) || !string.IsNullOrWhiteSpace(aktuelles))
                                {
                                    cmdInsLernender.Parameters.Clear();
                                    cmdInsLernender.Parameters.AddWithValue("@lehrjahre", FixUmlauts(lehrjahre) ?? (object)DBNull.Value);
                                    cmdInsLernender.Parameters.AddWithValue("@aktuelles", FixUmlauts(aktuelles) ?? (object)DBNull.Value);
                                    cmdInsLernender.Parameters.AddWithValue("@globalid", globalId);
                                    cmdInsLernender.ExecuteNonQuery();
                                    summary.InsertedLernende++;
                                }
                            }
                        }
                    }
                    catch (Exception lineEx)
                    {
                        summary.Skipped++;
                        summary.Errors.Add($"Zeile konnte nicht importiert werden: {lineEx.Message}");
                    }
                }

                tx.Commit();
            }
            catch
            {
                try { tx.Rollback(); } catch { /* ignore */ }
                throw;
            }

            return summary;
        }

        #endregion

        #region Helpers

        private static TextFieldParser CreateParser(string path)
        {
            var parser = new TextFieldParser(path, Encoding.UTF8)
            {
                HasFieldsEnclosedInQuotes = true
            };
            string first = File.ReadLines(path).FirstOrDefault() ?? string.Empty;
            if (first.Contains(';') && !first.Contains(','))
                parser.SetDelimiters(";");
            else
                parser.SetDelimiters(",", ";");
            return parser;
        }

        private static string Norm(string? h)
        {
            if (string.IsNullOrWhiteSpace(h)) return string.Empty;

            // Nutzerpraeferenz: ß -> ss
            string s = h.Replace("ß", "ss").Trim().ToLowerInvariant();

            s = s.Replace("ä", "ae").Replace("ö", "oe").Replace("ü", "ue")
                 .Replace("é", "e").Replace("è", "e");

            s = new string(s.Where(ch => char.IsLetterOrDigit(ch) || ch == '@').ToArray());

            if (s == "email") s = "e-mail";
            if (s == "mail") s = "e-mail";
            return s;
        }

        private static Dictionary<string, int> BuildHeader(string[] headers)
        {
            var map = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            for (int i = 0; i < headers.Length; i++)
            {
                var key = Norm(headers[i]);
                if (!map.ContainsKey(key))
                    map[key] = i;
            }
            return map;
        }

        private static string? Val(string[] row, Dictionary<string, int> map, params string[] keys)
        {
            foreach (var k in keys)
            {
                var nk = Norm(k);
                if (map.TryGetValue(nk, out int idx))
                {
                    if (idx >= 0 && idx < row.Length)
                    {
                        var v = row[idx]?.Trim();
                        if (!string.IsNullOrWhiteSpace(v)) return v;
                    }
                }
            }
            return null;
        }

        private static string? FixUmlauts(string? v, bool convertAe = true, bool convertEszett = true, bool skipEmailLike = true)
        {
            if (string.IsNullOrWhiteSpace(v)) return v;
            var s = v;

            if (skipEmailLike && (s.Contains("@") || s.StartsWith("http", StringComparison.OrdinalIgnoreCase)))
                return s;

            if (convertEszett) s = s.Replace("ß", "ss");

            if (convertAe)
            {
                s = s.Replace("Ae", "Ä").Replace("Oe", "Ö").Replace("Ue", "Ü")
                     .Replace("ae", "ä").Replace("oe", "ö").Replace("ue", "ü");
            }
            return s;
        }

        private string? ParseDate(string? dateStr)
        {
            if (string.IsNullOrWhiteSpace(dateStr)) return null;
            if (DateTime.TryParse(dateStr, _dateCulture, DateTimeStyles.AssumeLocal, out var dt)) return dt.ToString("yyyy-MM-dd");
            if (DateTime.TryParse(dateStr, CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal, out dt)) return dt.ToString("yyyy-MM-dd");
            return null;
        }

        private static int? ToInt(string? s)
        {
            if (int.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out var n)) return n;
            return null;
        }

        #endregion
    }
}
