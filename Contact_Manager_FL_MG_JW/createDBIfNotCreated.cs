using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager_FL_MG_JW
{
    internal class createDBIfNotCreated
    {
        public static void CreateDB()
        {
            string dbPfad = Path.Combine(Application.StartupPath, "contactManagerDB.db");

            try
            {
                if (!File.Exists(dbPfad))
                {
                    SQLiteConnection.CreateFile(dbPfad);
                }

                using (var connection = new SQLiteConnection($"Data Source={dbPfad};Version=3;"))
                {
                    connection.Open();

                    // Globale Tabelle
                    string createGlobal = @"
                    CREATE TABLE IF NOT EXISTS Global (
                    Anrede TEXT,
                    Titel TEXT,
                    Vorname TEXT,
                    Name TEXT,
                    Geschlecht TEXT,
                    `E-Mail` TEXT,
                    Geburtstag INTEGER,
                    Status TEXT,
                    globalid INTEGER PRIMARY KEY AUTOINCREMENT
                    );";

                    // Kunde
                    string createKunde = @"
                    CREATE TABLE IF NOT EXISTS Kunde (
                    kundentyp TEXT,
                    firmenname TEXT,
                    geschäftsadresse TEXT,
                    geschäftsnummer TEXT,
                    adresse TEXT,
                    telefon TEXT,
                    globalid INTEGER
                    );";

                    // Mitarbeiter
                    string createMitarbeiter = @"
                    CREATE TABLE IF NOT EXISTS Mitarbeiter (
                    mitarbeiternummer INTEGER PRIMARY KEY AUTOINCREMENT,
                    eintrittsdatum TEXT,
                    adresse TEXT,
                    handynummer TEXT,
                    beschäftigungsgrad INTEGER,
                    abteilung TEXT,
                    kaderstufe INTEGER,
                    ahvnummer TEXT,
                    austrittsdatum TEXT,
                    wohnort TEXT,
                    nationalität TEXT,
                    standort TEXT,
                    tätigkeitsbezeichnung TEXT,
                    telefonnummerintern TEXT,
                    globalid INTEGER NOT NULL,
                    FOREIGN KEY(globalid) REFERENCES Global(globalid) ON DELETE CASCADE
                    );";

                    // Lernender
                    string createLernender = @"
                    CREATE TABLE IF NOT EXISTS Lernender (
                    lehrjahre TEXT,
                    aktuelleslehrjahr TEXT,
                    mitarbeiterid INTEGER,
                    FOREIGN KEY(mitarbeiterid) REFERENCES Mitarbeiter(mitarbeiternummer) ON DELETE CASCADE
                    );";

                    string[] sqlBefehle = { createGlobal, createKunde, createMitarbeiter, createLernender };

                    foreach (string sql in sqlBefehle)
                    {
                        using (var command = new SQLiteCommand(sql, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Erstellen der Datenbank: " + ex.Message, "Datenbankfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
