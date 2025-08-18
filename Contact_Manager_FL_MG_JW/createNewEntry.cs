using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Contact_Manager_FL_MG_JW
{
    internal class createNewEntry
    {
        private GUI_Create gui;

        public createNewEntry(GUI_Create guiForm)
        {
            gui = guiForm;
        }

        private static DateTime? GetNullable(DateTimePicker dp) => dp.Checked ? dp.Value.Date : (DateTime?)null;

        internal void CreatePerson(object sender, EventArgs e) 
        {
            // -------------------------- Abschnitt Global --------------------------

            string anrede = gui.ddlSalutation.Text;
            string titel = gui.txtbTitel.Text;
            string vorname = gui.txtbFirstName.Text;
            string nachname = gui.txtbLastName.Text;
            string geschlecht = gui.ddlGender.Text;
            string geburtsdatum = gui.dtpBirthday.Value.ToString("O");
            string mail = gui.txtbEMail.Text;
            string status = gui.ddbStatus.Text;

            string dbPfad = Path.Combine(Application.StartupPath, "contactManagerDB.db");

            using (var connection = new SQLiteConnection($"Data Source={dbPfad};Version=3;"))
            {
                connection.Open();

                string sql = @"
                            INSERT INTO Global 
                            (Anrede, Titel, Vorname, Name, Geschlecht, Geburtstag, `E-Mail`, Status) 
                            VALUES 
                            (@anrede, @titel, @vorname, @nachname, @geschlecht, @geburtsdatum, @mail, @status)";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@anrede", anrede);
                    command.Parameters.AddWithValue("@titel", titel);
                    command.Parameters.AddWithValue("@vorname", vorname);
                    command.Parameters.AddWithValue("@nachname", nachname);
                    command.Parameters.AddWithValue("@geschlecht", geschlecht);
                    command.Parameters.AddWithValue("@geburtsdatum", geburtsdatum);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@status", status);

                    if (!gui.rbttCustomer.Checked && !gui.rbttEmployee.Checked)
                    {
                        MessageBox.Show("Bitte Kunde oder Mitarbeiter auswählen!", "Fehler!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }

                    long globalId = connection.LastInsertRowId;

                    // -------------------------- Abschnitt Mitarbeiter --------------------------
                    if (gui.rbttEmployee.Checked)
                    {
                        string eintrittsdatum = gui.dtphiringdate.Value.ToString("yyyy-MM-dd");
                        string austrittsdatum = gui.dtpExitDate.Value.ToString("yyyy-MM-dd");
                        string strasse = gui.txtbEmpStreet.Text;
                        string PLZOrt = gui.txtbEmpPlz.Text;
                        string handynummer = gui.txtbMoPhone.Text;
                        string beschaeftigungsgrad = gui.nudEmpLevel.Text;
                        string abteilung = gui.ddbDepartment.Text;
                        int kaderstufe = 0;
                        int.TryParse(gui.ddbCadreLvl.Text, out kaderstufe);
                        string ahvnummer = gui.txtbAHVNr.Text;
                        string nationalitaet = gui.txtbNationality.Text;
                        string standort = gui.ddbLoAddress.Text;
                        string taetigkeit = gui.txtbRole.Text;
                        string telefonintern = gui.txtbIntPhNr.Text;
                        string insertMitarbeiter = @"
                            INSERT INTO Mitarbeiter 
                            (eintrittsdatum, strasse, PLZOrt, handynummer, beschäftigungsgrad, abteilung, kaderstufe, ahvnummer, austrittsdatum, nationalität, standort, tätigkeitsbezeichnung, telefonnummerintern, globalid)
                            VALUES 
                            (@eintritt, @strasse, @PLZOrt, @handy, @grad, @abteilung, @kader, @ahv, @austritt, @nationalitaet, @standort, @tätigkeitsbezeichnung, @telefon, @globalid);";
                    
                        var cmdMitarbeiter = new SQLiteCommand(insertMitarbeiter, connection);
                        cmdMitarbeiter.Parameters.AddWithValue("@eintritt", eintrittsdatum);
                        cmdMitarbeiter.Parameters.AddWithValue("@strasse", strasse); 
                        cmdMitarbeiter.Parameters.AddWithValue("@PLZOrt", PLZOrt);
                        cmdMitarbeiter.Parameters.AddWithValue("@handy", handynummer);
                        cmdMitarbeiter.Parameters.AddWithValue("@grad", beschaeftigungsgrad);
                        cmdMitarbeiter.Parameters.AddWithValue("@abteilung", abteilung);
                        cmdMitarbeiter.Parameters.AddWithValue("@kader", kaderstufe);
                        cmdMitarbeiter.Parameters.AddWithValue("@ahv", ahvnummer);
                        cmdMitarbeiter.Parameters.AddWithValue("@austritt", austrittsdatum);
                        cmdMitarbeiter.Parameters.AddWithValue("@nationalitaet", nationalitaet);
                        cmdMitarbeiter.Parameters.AddWithValue("@standort", standort);
                        cmdMitarbeiter.Parameters.AddWithValue("@tätigkeitsbezeichnung", taetigkeit);
                        cmdMitarbeiter.Parameters.AddWithValue("@telefon", telefonintern);
                        cmdMitarbeiter.Parameters.AddWithValue("@globalid", globalId);
                
                        try
                        {
                            if (
                                string.IsNullOrWhiteSpace(anrede) ||
                                string.IsNullOrWhiteSpace(titel) ||
                                string.IsNullOrWhiteSpace(vorname) ||
                                string.IsNullOrWhiteSpace(nachname) ||
                                string.IsNullOrWhiteSpace(geschlecht) ||
                                string.IsNullOrWhiteSpace(geburtsdatum) ||
                                string.IsNullOrWhiteSpace(mail) ||
                                string.IsNullOrWhiteSpace(status) ||
                                !ValidateRequiredFields(gui.groupBoxEmployee)
                                )
                            {
                                MessageBox.Show("Bitte alle Pflichtfelder ausfüllen!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            if (!gui.ChbTrainee.Checked)
                            {
                                command.ExecuteNonQuery();
                                cmdMitarbeiter.ExecuteNonQuery();
                                MessageBox.Show("Daten erfolgreich gespeichert!", "Speichern erfolgreich!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );
                            }
                            else
                            {
                                long mitarbeiterId = connection.LastInsertRowId;

                                // -------------------------- Abschnitt Lernende --------------------------
                                if (gui.ChbTrainee.Checked)
                                {
                                    if (!ValidateRequiredFields(gui.groupBoxTrainee))
                                    {
                                        MessageBox.Show("Bitte alle Pflichtfelder für Lernende ausfüllen!");
                                        return;
                                    }
                                    string lehrjahre = gui.txtbNrOfYearsOfAppr.Text;
                                    string aktuelleslehrjahr = gui.txtbWhYearsOfAppr.Text;
                                    string insertLernender = @"
                                                                                INSERT INTO Lernender
                                                                                (lehrjahre, aktuelleslehrjahr, mitarbeiterid)
                                                                                VALUES
                                                                                (@lehrjahre, @aktuelleslehrjahr, @mitarbeiterid);";
                                    var cmdLernender = new SQLiteCommand(insertLernender, connection);
                                    cmdLernender.Parameters.AddWithValue("@lehrjahre", lehrjahre);
                                    cmdLernender.Parameters.AddWithValue("@aktuelleslehrjahr", aktuelleslehrjahr);
                                    cmdLernender.Parameters.AddWithValue("@mitarbeiterid", mitarbeiterId);
                                    command.ExecuteNonQuery();
                                    cmdMitarbeiter.ExecuteNonQuery();
                                    cmdLernender.ExecuteNonQuery();
                                    MessageBox.Show("Daten erfolgreich gespeichert!", "Speichern erfolgreich!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                    );
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Fehler: " + ex.Message, "Fehler!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                    // -------------------------- Abschnitt Kunden --------------------------
                    if (gui.rbttCustomer.Checked)
                    {
                        string kundentyp = "";
                        if (gui.rbttKtA.Checked)
                        {
                            kundentyp = gui.rbttKtA.Text;
                        }
                        else if (gui.rbttKtB.Checked)
                        {
                            kundentyp = gui.rbttKtB.Text;
                        }
                        else if (gui.rbttKtC.Checked)
                        {
                            kundentyp = gui.rbttKtC.Text;
                        }
                        else if (gui.rbttKtD.Checked)
                        {
                            kundentyp = gui.rbttKtD.Text;
                        }
                        else if (gui.rbttKtE.Checked)
                        {
                            kundentyp = gui.rbttKtE.Text;
                        }
                        if (string.IsNullOrWhiteSpace(kundentyp))
                        {
                            MessageBox.Show("Bitte Kundentyp auswählen!", "Fehler!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                            return;
                        }
                        string firmenname = gui.txtbCoName.Text;
                        string geschaeftsadresse = gui.txtbCoAddresse.Text;
                        string geschaeftsnummer = gui.txtbCoPhoneNr.Text;
                        string adresse = gui.txtbPrStreet.Text;
                        string telefon = gui.txtbPrPhone.Text;
                    
                        string insertKunde = @"
                            INSERT INTO Kunde 
                            (kundentyp, firmenname, geschäftsadresse, geschäftsnummer, adresse, telefon, globalid)
                            VALUES 
                            (@kundentyp, @firmenname, @geschaeftsadresse, @geschaeftsnummer, @adresse, @telefon, @globalid);";
                    
                        var cmdKunde = new SQLiteCommand(insertKunde, connection);
                        cmdKunde.Parameters.AddWithValue("@kundentyp", kundentyp);
                        cmdKunde.Parameters.AddWithValue("@firmenname", firmenname);
                        cmdKunde.Parameters.AddWithValue("@geschaeftsadresse", geschaeftsadresse);
                        cmdKunde.Parameters.AddWithValue("@geschaeftsnummer", geschaeftsnummer);
                        cmdKunde.Parameters.AddWithValue("@adresse", adresse);
                        cmdKunde.Parameters.AddWithValue("@telefon", telefon);
                        cmdKunde.Parameters.AddWithValue("@globalid", globalId);
                        try
                        {
                            if (string.IsNullOrWhiteSpace(anrede) ||
                                //string.IsNullOrWhiteSpace(titel) ||
                                string.IsNullOrWhiteSpace(vorname) ||
                                string.IsNullOrWhiteSpace(nachname) ||
                                string.IsNullOrWhiteSpace(geschlecht) ||
                                string.IsNullOrWhiteSpace(geburtsdatum) ||
                                string.IsNullOrWhiteSpace(mail) ||
                                string.IsNullOrWhiteSpace(status))
                            {
                                MessageBox.Show("Bitte alle Pflichtfelder ausfüllen!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            command.ExecuteNonQuery();
                            MessageBox.Show("Daten erfolgreich gespeichert!", "Speichern erfolgreich!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Fehler: " + ex.Message, "Fehler!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                        if (!ValidateRequiredFields(gui.groupBoxCustomer))
                        {
                            MessageBox.Show("Bitte alle Pflichtfelder für Kunden ausfüllen!");
                            return;
                        }
                        cmdKunde.ExecuteNonQuery();
                    }
                }
            }
        }

        // -------------------------- Abschnitt Pflichtfeldprüfung --------------------------
        private bool ValidateRequiredFields(Control parent)
{
            bool allValid = true;

            foreach (Control control in parent.Controls)
            {

                //Lehrlingsfelder nur prüfen wenn checked
                if (!gui.ChbTrainee.Checked && (control.Name == "txtbNrOfYearsOfAppr" || control.Name == "txtbWhYearsOfAppr"))
                {
                    continue;
                }
                // Rekursiv prüfen (z. B. für GroupBoxen)
                if (control.HasChildren)
                {
                    if (!ValidateRequiredFields(control))
                        allValid = false;
                    continue;
                }
                //Mitarbeiternummer ignorieren
                if (control.Name == "lblEmpNrOut")
                {
                    continue;
                }
                // RadioButtons ignorieren
                if (control is RadioButton)
                {
                    continue;
                }
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
                        dtp.CalendarTitleBackColor = Color.MistyRose; // nicht ideal sichtbar
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
