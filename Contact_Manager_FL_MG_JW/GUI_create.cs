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
                string id = this.Tag.ToString();
                UpdateExistingEntry(id);
            }
            else
            {
                // Neuen Datensatz erstellen
                var creator = new createNewEntry(this);
                creator.CreatePerson(sender, e);
            }
        }

        private void UpdateExistingEntry(string id)
        {
            string dbPfad = Path.Combine(Application.StartupPath, "contactManagerDB.db");
            using (var connection = new SQLiteConnection($"Data Source={dbPfad};Version=3;"))
            {
                connection.Open();
                string sql = @"
                    UPDATE Global SET
                        Anrede = @Anrede,
                        Titel = @Titel,
                        Vorname = @Vorname,
                        Name = @Name,
                        Geschlecht = @Geschlecht,
                        `E-Mail` = @Email,
                        Geburtstag = @Geburtstag,
                        Status = @Status
                    WHERE globalid = @Id";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Anrede", ddlSalutation.Text);
                    command.Parameters.AddWithValue("@Titel", txtbTitel.Text);
                    command.Parameters.AddWithValue("@Vorname", txtbFirstName.Text);
                    command.Parameters.AddWithValue("@Name", txtbLastName.Text);
                    command.Parameters.AddWithValue("@Geschlecht", ddlGender.Text);
                    command.Parameters.AddWithValue("@Email", txtbEMail.Text);
                    command.Parameters.AddWithValue("@Geburtstag", dtpBirthday.Value.Date.Ticks);
                    command.Parameters.AddWithValue("@Status", ddbStatus.Text);
                    command.Parameters.AddWithValue("@Id", id);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Kontakt erfolgreich aktualisiert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fehler beim Aktualisieren: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
