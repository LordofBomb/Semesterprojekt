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
        }

        private void bttmCreateOnDash_Click(object sender, EventArgs e)
        {
            GUI_Create createForm = new GUI_Create(); // Neues Fenster erzeugen
            createForm.Show(); // Fenster anzeigen (nicht modal)
        }

        private void BtnResetDB_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Willst du die Datenbank wirklich zurücksetzten? Alle bisher gespeicherten Daten gehen unwiderruflich verloren!", "Warnung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {s
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
    }
}
