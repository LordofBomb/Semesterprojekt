using System.Data.SQLite;
using System;
using System.Text;

namespace Contact_Manager_FL_MG_JW
{
    public partial class GUI_Dashboard : Form
    {
        public GUI_Dashboard()
        {
            InitializeComponent();
            createDBIfNotCreated.CreateDB();


            viewAllPanel = new Form_ViewAll();
            viewAllPanel.Location = new Point(25, 550);
            viewAllPanel.Anchor = AnchorStyles.Top;
            Controls.Add(viewAllPanel);
        }

        private void bttmCreateOnDash_Click(object sender, EventArgs e) //Erzeugt neues Fenster um einen neuen Eintrag in die Datenbank machen zu können.
        {
            GUI_Create createForm = new GUI_Create(); // Neues Fenster erzeugen
            createForm.Show(); // Fenster anzeigen (nicht modal)
        }


        private void BtnResetDB_Click(object sender, EventArgs e) //Button um die Datenbank zurücksetzten zu können, alle Einträge werden gelöscht und die Ids auf 0 gesetzt.
        {
            DialogResult result = MessageBox.Show("Willst du die Datenbank wirklich zurücksetzten? Alle bisher gespeicherten Daten gehen unwiderruflich verloren!", "Warnung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (var connection = new SQLiteConnection("Data Source=contactManagerDB.db;Version=3;"))
                {
                    connection.Open();

                    string resetSql = @"
                        DELETE FROM Lernender;
                        DELETE FROM Mitarbeiter;
                        DELETE FROM Kunde;
                        DELETE FROM Global;
                        DELETE FROM sqlite_sequence;
                        ";

                    using (var cmd = new SQLiteCommand(resetSql, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void bttnCsv_Click(object? sender, EventArgs e) //CSV import Button, dieser öffnet eine Instanz der CSVImport.cs und importiert die Einträge einer CSV Datei in die Datenbank, aktuell werden da Fehlerhafte CSV Daten noch nicht abgefangen.
        {
            using var ofd = new OpenFileDialog
            {
                Title = "CSV-Datei wählen",
                Filter = "CSV-Dateien (*.csv)|*.csv|Alle Dateien (*.*)|*.*",
                Multiselect = false
            };
            if (ofd.ShowDialog(this) != DialogResult.OK) return;

            try
            {
                var importer = new CsvImporter("Data Source=contactManagerDB.db;Version=3;");
                var result = importer.Import(ofd.FileName);

                var msg =
                    $"Import abgeschlossen:\n" +
                    $"- Global: {result.InsertedGlobal}\n" +
                    $"- Kunden: {result.InsertedKunden}\n" +
                    $"- Mitarbeiter: {result.InsertedMitarbeiter}\n" +
                    $"- Lernende: {result.InsertedLernende}\n" +
                    $"- Uebersprungen: {result.Skipped}";

                if (result.Errors.Count > 0)
                    msg += $"\n\nHinweise:\n- " + string.Join("\n- ", result.Errors.Take(5));

                MessageBox.Show(msg, "CSV-Import", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Import: {ex.Message}", "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            viewAllPanel.UpdateDashboard();
        }

    }
}
