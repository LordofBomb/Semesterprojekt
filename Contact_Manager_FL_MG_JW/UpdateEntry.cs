using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Contact_Manager_FL_MG_JW
{
    internal class UpdateEntry
    {
        private GUI_Create gui;

        public UpdateEntry(GUI_Create guiForm) //übernahme der GUI_Create.cs (verknüpfung)
        {
            gui = guiForm;
        }

        internal void UpdatePerson(object sender, EventArgs e) //Update Person Methode, welche erlaubt die bestehenden Einträge zu überschreiben, ohne neue zu erstellen.
        {

            string globalId = gui.Tag?.ToString();

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
                    WHERE globalid = @Id; 
                    ";



                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Anrede", gui.ddlSalutation.Text);
                    command.Parameters.AddWithValue("@Titel", gui.txtbTitel.Text);
                    command.Parameters.AddWithValue("@Vorname", gui.txtbFirstName.Text);
                    command.Parameters.AddWithValue("@Name", gui.txtbLastName.Text);
                    command.Parameters.AddWithValue("@Geschlecht", gui.ddlGender.Text);
                    command.Parameters.AddWithValue("@Email", gui.txtbEMail.Text);
                    command.Parameters.AddWithValue("@Geburtstag", gui.dtpBirthday.Value.ToString("O"));
                    command.Parameters.AddWithValue("@Status", gui.ddbStatus.Text);
                    command.Parameters.AddWithValue("@Id", globalId);

                    if (gui.rbttEmployee.Checked && !gui.rbttCustomer.Checked)
                    {
                        if (!ValidateRequiredFields(gui.groupBoxEmployee))
                        {
                            MessageBox.Show("Bitte alle Pflichtfelder ausfüllen!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (gui.ChbTrainee.Checked)
                        {
                            long mitarbeiterId = -1;

                            string sqlGetMitarbeiterId = "SELECT mitarbeiternummer FROM Mitarbeiter WHERE globalid = @globalid";
                            using (var cmdGetId = new SQLiteCommand(sqlGetMitarbeiterId, connection))
                            {
                                cmdGetId.Parameters.AddWithValue("@globalid", globalId);
                                var result = cmdGetId.ExecuteScalar();

                                if (result != null && long.TryParse(result.ToString(), out var id))
                                {
                                    mitarbeiterId = id;
                                }
                                else
                                {
                                    MessageBox.Show("Mitarbeiter-ID konnte nicht ermittelt werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }

                            bool lernenderExistiert = false;
                            string sqlCheck = "SELECT 1 FROM Lernender WHERE mitarbeiterid = @mitarbeiterid LIMIT 1";
                            using (var cmdCheck = new SQLiteCommand(sqlCheck, connection))
                            {
                                cmdCheck.Parameters.AddWithValue("@mitarbeiterid", mitarbeiterId);
                                using (var reader = cmdCheck.ExecuteReader())
                                {
                                    lernenderExistiert = reader.HasRows;
                                }
                            }

                            if (lernenderExistiert)
                            {
                                string sqlUpdate = @"
                                                UPDATE Lernender 
                                                SET 
                                                    lehrjahre = @lehrjahre, 
                                                    aktuelleslehrjahr = @aktuelleslehrjahr 
                                                WHERE mitarbeiterid = @mitarbeiterid";

                                using (var cmdUpdate = new SQLiteCommand(sqlUpdate, connection))
                                {
                                    cmdUpdate.Parameters.AddWithValue("@lehrjahre", gui.txtbNrOfYearsOfAppr.Text);
                                    cmdUpdate.Parameters.AddWithValue("@aktuelleslehrjahr", gui.txtbWhYearsOfAppr.Text);
                                    cmdUpdate.Parameters.AddWithValue("@mitarbeiterid", mitarbeiterId);

                                    cmdUpdate.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                if (!ValidateRequiredFields(gui.groupBoxTrainee))
                                {
                                    MessageBox.Show("Bitte alle Pflichtfelder ausfüllen!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                string sqlInsert = @"
                                            INSERT INTO Lernender 
                                            (lehrjahre, aktuelleslehrjahr, mitarbeiterid) 
                                            VALUES 
                                            (@lehrjahre, @aktuelleslehrjahr, @mitarbeiterid)";

                                using (var cmdInsert = new SQLiteCommand(sqlInsert, connection))
                                {
                                    cmdInsert.Parameters.AddWithValue("@lehrjahre", gui.txtbNrOfYearsOfAppr.Text);
                                    cmdInsert.Parameters.AddWithValue("@aktuelleslehrjahr", gui.txtbWhYearsOfAppr.Text);
                                    cmdInsert.Parameters.AddWithValue("@mitarbeiterid", mitarbeiterId);

                                    cmdInsert.ExecuteNonQuery();
                                }
                            }
                        }
          

                    }
                
                    else if (gui.rbttCustomer.Checked && !gui.rbttEmployee.Checked)
                    {
                        if (!ValidateRequiredFields(gui.groupBoxCustomer))
                        {
                            MessageBox.Show("Bitte alle Pflichtfelder ausfüllen!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        string sqlc = @"
                                            UPDATE Kunde SET
                                                kundentyp = @kundentyp,
                                                firmenname = @firmenname,
                                                geschäftsadresse = @geschaeftsadresse,
                                                geschäftsnummer = @geschaeftsnummer,
                                                strasse = @strasse,
                                                PLZ = @PLZ,
                                                Ort = @Ort,
                                                telefon = @telefon,
                                                note = @note
                                            WHERE globalid = @globalid;
                                            ";
                        using (var command3 = new SQLiteCommand(sqlc, connection))
                        {
                            string kundentyp = "";

                            if (gui.rbttKtA.Checked) kundentyp = gui.rbttKtA.Text;
                            else if (gui.rbttKtB.Checked) kundentyp = gui.rbttKtB.Text;
                            else if (gui.rbttKtC.Checked) kundentyp = gui.rbttKtC.Text;
                            else if (gui.rbttKtD.Checked) kundentyp = gui.rbttKtD.Text;
                            else if (gui.rbttKtE.Checked) kundentyp = gui.rbttKtE.Text;

                            command3.Parameters.AddWithValue("@kundentyp", kundentyp);
                            command3.Parameters.AddWithValue("@firmenname", gui.txtbCoName.Text);
                            command3.Parameters.AddWithValue("@geschaeftsadresse", gui.txtbCoAddresse.Text);
                            command3.Parameters.AddWithValue("@geschaeftsnummer", gui.txtbCoPhoneNr.Text);
                            command3.Parameters.AddWithValue("@strasse", gui.txtbPrStreet.Text);
                            command3.Parameters.AddWithValue("@PLZ", gui.txtprplz.Text);
                            command3.Parameters.AddWithValue("@Ort", gui.TxtbCoPlace.Text);
                            command3.Parameters.AddWithValue("@telefon", gui.txtbPrPhone.Text);
                            if (!string.IsNullOrWhiteSpace(gui.TxtbNote.Text))
                            {
                                string datum = DateTime.Now.ToString("dd.MM.yyyy");
                                string notiz = $"{Environment.NewLine}[{datum}] {gui.TxtbNote.Text}";
                                command3.Parameters.AddWithValue("@note", notiz);
                            }
                            else
                            {
                                string notiz = "";
                                command3.Parameters.AddWithValue("@note", notiz);
                            }
                            command3.Parameters.AddWithValue("@globalid", globalId);
                            command3.ExecuteNonQuery();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Bitte Kundentyp auswählen!", "Fehler!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }

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
        private bool ValidateRequiredFields(Control parent)
        {
            bool allValid = true;

            foreach (Control control in parent.Controls)
            {
                // Lehrlingsfelder nur prüfen wenn angehakt
                if (!gui.ChbTrainee.Checked && (control.Name == "txtbNrOfYearsOfAppr" || control.Name == "txtbWhYearsOfAppr"))
                    continue;

                // Rekursiv prüfen (z. B. für GroupBoxes)
                if (control.HasChildren)
                {
                    if (!ValidateRequiredFields(control))
                        allValid = false;
                    continue;
                }

                // Ignorieren:
                if (control.Name == "lblEmpNrOut" || control is RadioButton)
                    continue;
                if (control.Name == "TxtbNote")
                    continue;

                // TextBox prüfen
                if (control is System.Windows.Forms.TextBox tb)
                {
                    if (string.IsNullOrWhiteSpace(tb.Text))
                    {
                        tb.BackColor = Color.MistyRose;
                        allValid = false;
                    }
                    else
                    {
                        tb.BackColor = Color.White;
                    }
                }
                // ComboBox prüfen
                else if (control is System.Windows.Forms.ComboBox cb)
                {
                    if (string.IsNullOrWhiteSpace(cb.Text))
                    {
                        cb.BackColor = Color.MistyRose;
                        allValid = false;
                    }
                    else
                    {
                        cb.BackColor = Color.White;
                    }
                }
                // DateTimePicker prüfen
                else if (control is DateTimePicker dtp)
                {
                    if (dtp.Value == DateTimePicker.MinimumDateTime)
                    {
                        dtp.CalendarTitleBackColor = Color.MistyRose;
                        allValid = false;
                    }
                }
                // NumericUpDown prüfen
                else if (control is NumericUpDown nud)
                {
                    if (nud.Value <= 0)
                    {
                        nud.BackColor = Color.MistyRose;
                        allValid = false;
                    }
                    else
                    {
                        nud.BackColor = Color.White;
                    }
                }
            }

            return allValid;
        }

    }
}
