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
    public partial class GUI_Create : Form
    {
        public GUI_Create()
        {
            InitializeComponent();
            radioGroupboxHide();
        }

        private void rbttCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbttCustomer.Checked)
            {
                groupBoxCustomer.Visible = true;
                groupBoxEmployee.Visible = false;
                ChbTrainee.Checked = false;
            }
        }

        private void rbttEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (rbttEmployee.Checked)
            {
                groupBoxEmployee.Visible = true;
                groupBoxCustomer.Visible = false;
            }
        }
        private void radioGroupboxHide()
        {
            groupBoxCustomer.Visible = false;
            groupBoxEmployee.Visible = false;
            groupBoxTrainee.Visible = false;
        }

        private void ChbTrainee_CheckedChanged(object sender, EventArgs e)
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

        private void ChkbExitDate_CheckedChanged(object sender, EventArgs e)
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

        private void BtnDelete_Click(object sender, EventArgs e)
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
    }
}

