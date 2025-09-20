using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Contact_Manager_FL_MG_JW
{
    public partial class GUI_Create : Form //Form in welcher sich alle Felder befinden um neue Einträge einzufügen, Einträge zu bearbeiten oder anzuzeigen
    {
        public GUI_Create()
        {
            InitializeComponent();
            radioGroupboxHide();
        }

        private void rbttCustomer_CheckedChanged(object sender, EventArgs e) //Radiobutton für Kunden
        {
            if (rbttCustomer.Checked)
            {
                groupBoxCustomer.Visible = true;
                groupBoxEmployee.Visible = false;
                ChbTrainee.Checked = false;
            }
        }

        private void rbttEmployee_CheckedChanged(object sender, EventArgs e) //Radiobutton für Mitarbeiter
        {
            if (rbttEmployee.Checked)
            {
                groupBoxEmployee.Visible = true;
                groupBoxCustomer.Visible = false;
            }
        }
        private void radioGroupboxHide() //Versteckt standardmässig alle Groupboxen, um später die richtigen zeigen zu können.
        {
            groupBoxCustomer.Visible = false;
            groupBoxEmployee.Visible = false;
            groupBoxTrainee.Visible = false;
        }

        private void ChbTrainee_CheckedChanged(object sender, EventArgs e) //zeigt Lernender Groupbox wenn Checkbox ausgewählt ist
        {
            groupBoxTrainee.Visible = ChbTrainee.Checked;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                // Bestehenden Datensatz aktualisieren

                var creator = new UpdateEntry(this);
                creator.UpdatePerson(sender, e);
            }
            else
            {
                // Neuen Datensatz erstellen
                var creator = new createNewEntry(this);
                creator.CreatePerson(sender, e);
            }
        }

        private void ChkbExitDate_CheckedChanged(object sender, EventArgs e) //Zeigt oder versteckt Austrittsdatum Date
        {
            if (ChkbExitDate.Checked)
            {
                dtpExitDate.Visible = true;
            }
            else
            {
                dtpExitDate.Visible = false;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e) //Löscht den aktuell geöffneten Eintrag aus der Datenbank
        {

            if (this.Tag == null)
            {
                MessageBox.Show("Kein Datensatz geladen.");
                return;
            }

            var confirm = MessageBox.Show("Möchtest du diesen Eintrag wirklich löschen?", "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            long globalId = Convert.ToInt64(this.Tag);

            string dbPfad = Path.Combine(Application.StartupPath, "contactManagerDB.db");

            using (var connection = new SQLiteConnection($"Data Source={dbPfad};Version=3;"))
            {
                connection.Open();

                long mitarbeiterId = -1;
                string sqlGetMid = "SELECT mitarbeiternummer FROM Mitarbeiter WHERE globalid = @globalid";
                using (var cmdMid = new SQLiteCommand(sqlGetMid, connection))
                {
                    cmdMid.Parameters.AddWithValue("@globalid", globalId);
                    var result = cmdMid.ExecuteScalar();
                    if (result != null && long.TryParse(result.ToString(), out var mid))
                        mitarbeiterId = mid;
                }

                if (mitarbeiterId != -1)
                {
                    string sqlDeleteLernender = "DELETE FROM Lernender WHERE mitarbeiterid = @mid";
                    using (var cmd = new SQLiteCommand(sqlDeleteLernender, connection))
                    {
                        cmd.Parameters.AddWithValue("@mid", mitarbeiterId);
                        cmd.ExecuteNonQuery();
                    }
                }

                string sqlDeleteMitarbeiter = "DELETE FROM Mitarbeiter WHERE globalid = @globalid";
                using (var cmd = new SQLiteCommand(sqlDeleteMitarbeiter, connection))
                {
                    cmd.Parameters.AddWithValue("@globalid", globalId);
                    cmd.ExecuteNonQuery();
                }

                string sqlDeleteKunde = "DELETE FROM Kunde WHERE globalid = @globalid";
                using (var cmd = new SQLiteCommand(sqlDeleteKunde, connection))
                {
                    cmd.Parameters.AddWithValue("@globalid", globalId);
                    cmd.ExecuteNonQuery();
                }

                string sqlDeleteGlobal = "DELETE FROM Global WHERE globalid = @globalid";
                using (var cmd = new SQLiteCommand(sqlDeleteGlobal, connection))
                {
                    cmd.Parameters.AddWithValue("@globalid", globalId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Eintrag erfolgreich gelöscht.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();


            }
        }

        private void btnExportCsv_Click(object sender, EventArgs e) //Exportiert den geöffneten Eintrag als csv
        {
            using (var dlg = new SaveFileDialog())
            {
                dlg.Title = "CSV exportieren";
                dlg.Filter = "CSV-Datei (*.csv)|*.csv";
                dlg.FileName = $"kontakt_form_{DateTime.Now:HH-mm_dd-MM-yyyy}.csv";
                dlg.RestoreDirectory = true;

                if (dlg.ShowDialog(this) != DialogResult.OK) return;

                try
                {
                    ExportCurrentFormToCsv(dlg.FileName, ';');
                    MessageBox.Show(this, "Formulardaten wurden exportiert.", "CSV Export",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, $"Export fehlgeschlagen:\n{ex.Message}", "CSV Export",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Exportiert ALLE Felder aus GUI_Create als eine CSV-Zeile (auch leere)
        private void ExportCurrentFormToCsv(string path, char delimiter = ';')
        {
            // Accounttyp und Kundentyp (A-E)
            string accounttyp =
                (rbttCustomer?.Checked ?? false) ? "Kunde" :
                (rbttEmployee?.Checked ?? false) ? "Mitarbeiter" : "";

            string kundentyp =
                (rbttKtA?.Checked ?? false) ? "A" :
                (rbttKtB?.Checked ?? false) ? "B" :
                (rbttKtC?.Checked ?? false) ? "C" :
                (rbttKtD?.Checked ?? false) ? "D" :
                (rbttKtE?.Checked ?? false) ? "E" : "";

            // CSV-Schema: stabile Spaltenreihenfolge
            var dt = new DataTable("FormExport");
            string[] columns = new[]
            {
        // Basis
        "Accounttyp",
        "Kundentyp",
        "Anrede",
        "Titel",
        "Vorname",
        "Name",
        "Geschlecht",
        "Geburtstag",
        "E-Mail",
        "Status",

        // Kunde / Firma
        "Firmenname",
        "Geschaeftsadresse",
        "Geschaeftsnummer",
        "Strasse (Kunde)",
        "PLZ (Kunde)",
        "Ort (Kunde)",
        "Telefonnr/Handynr (Kunde)",
        "Notiz",

        // Mitarbeiter
        "Eintrittsdatum",
        "Austrittsdatum aktiv",
        "Austrittsdatum",
        "Strasse (Mitarbeiter)",
        "PLZ (Mitarbeiter)",
        "Ort (Mitarbeiter)",
        "Mobiltelefon",
        "AHV-Nummer",
        "Nationalitaet",
        "Standortadresse",
        "Abteilung",
        "Taetigkeitsbezeichnung",
        "Beschäftigungsgrad",
        "Kaderstufe",
        "Telefonnummer intern",
        "Lehrling",
        "Anzahl Ausbildungsjahre",
        "Aktuelles Ausbildungsjahr"
    };
            foreach (var c in columns) dt.Columns.Add(c);

            var row = dt.NewRow();

            // Basis
            row["Accounttyp"] = accounttyp;
            row["Kundentyp"] = kundentyp;
            row["Anrede"] = ddlSalutation?.Text ?? "";
            row["Titel"] = txtbTitel?.Text ?? "";
            row["Vorname"] = txtbFirstName?.Text ?? "";
            row["Name"] = txtbLastName?.Text ?? "";
            row["Geschlecht"] = ddlGender?.Text ?? "";
            row["Geburtstag"] = dtpBirthday != null ? dtpBirthday.Value.ToString("yyyy-MM-dd") : "";
            row["E-Mail"] = txtbEMail?.Text ?? "";
            row["Status"] = ddbStatus?.Text ?? "";

            // Kunden
            row["Firmenname"] = txtbCoName?.Text ?? "";
            row["Geschaeftsadresse"] = txtbCoAddresse?.Text ?? "";
            row["Geschaeftsnummer"] = txtbCoPhoneNr?.Text ?? "";
            row["Strasse (Kunde)"] = txtbPrStreet?.Text ?? "";
            row["PLZ (Kunde)"] = txtprplz?.Text ?? "";
            row["Ort (Kunde)"] = TxtbCoPlace?.Text ?? "";
            row["Telefonnr/Handynr (Kunde)"] = txtbPrPhone?.Text ?? "";
            row["Notiz"] = TxtbNote?.Text ?? "";

            // Mitarbeiter
            row["Eintrittsdatum"] = dtphiringdate != null ? dtphiringdate.Value.ToString("yyyy-MM-dd") : "";
            row["Austrittsdatum aktiv"] = (ChkbExitDate?.Checked ?? false) ? "true" : "false";
            row["Austrittsdatum"] = dtpExitDate != null ? dtpExitDate.Value.ToString("yyyy-MM-dd") : "";
            row["Strasse (Mitarbeiter)"] = txtbEmpStreet?.Text ?? "";
            row["PLZ (Mitarbeiter)"] = txtbEmpPlz?.Text ?? "";
            row["Ort (Mitarbeiter)"] = txtbEmpPlace?.Text ?? "";
            row["Mobiltelefon"] = txtbMoPhone?.Text ?? "";
            row["AHV-Nummer"] = txtbAHVNr?.Text ?? "";
            row["Nationalitaet"] = txtbNationality?.Text ?? "";
            row["Standortadresse"] = ddbLoAddress?.Text ?? "";
            row["Abteilung"] = ddbDepartment?.Text ?? "";
            row["Taetigkeitsbezeichnung"] = txtbRole?.Text ?? "";
            row["Beschäftigungsgrad"] = nudEmpLevel.Value;
            row["Kaderstufe"] = ddbCadreLvl?.Text ?? "";
            row["Telefonnummer intern"] = txtbIntPhNr?.Text ?? "";
            row["Lehrling"] = (ChbTrainee?.Checked ?? false) ? "true" : "false";
            row["Anzahl Ausbildungsjahre"] = txtbNrOfYearsOfAppr?.Text ?? "";
            row["Aktuelles Ausbildungsjahr"] = txtbWhYearsOfAppr?.Text ?? "";

            dt.Rows.Add(row);

            WriteDataTableToCsv(dt, path, delimiter, includeHeaders: true);
        }

        // CSV-Schreiber für DataTable
        private static void WriteDataTableToCsv(DataTable dt, string path, char delimiter = ';', bool includeHeaders = true)
        {
            using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            using (var writer = new StreamWriter(fs, new UTF8Encoding(encoderShouldEmitUTF8Identifier: true)))
            {
                if (includeHeaders)
                {
                    var headers = dt.Columns.Cast<DataColumn>()
                        .Select(c => EscapeCsv(c.ColumnName, delimiter));
                    writer.WriteLine(string.Join(delimiter.ToString(), headers));
                }

                foreach (DataRow r in dt.Rows)
                {
                    var cells = r.ItemArray.Select(v => EscapeCsv(Convert.ToString(v) ?? string.Empty, delimiter));
                    writer.WriteLine(string.Join(delimiter.ToString(), cells));
                }
            }
        }

        // CSV-Escaping
        private static string EscapeCsv(string value, char delimiter)
        {
            if (value == null) return string.Empty;

            bool mustQuote =
                value.Contains(delimiter.ToString()) ||
                value.Contains("\"") ||
                value.Contains("\n") ||
                value.Contains("\r");

            value = value.Replace("\"", "\"\"");
            return mustQuote ? $"\"{value}\"" : value;
        }
    }
}

