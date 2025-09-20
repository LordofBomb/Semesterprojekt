using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Contact_Manager_FL_MG_JW
{
    internal class createNewEntry
    {
        private GUI_Create gui;

        public createNewEntry(GUI_Create guiForm) //übergabe aus der GUI_Create um auf Felder zugreifen zu können
        {
            gui = guiForm;
        }

        internal void CreatePerson(object sender, EventArgs e) //Funktion für das Eintragen der Daten in die SQLite Datenbank mit Validierungsprüfung der Pflichtfelder
        {
            string anrede = gui.ddlSalutation.Text;
            string titel = gui.txtbTitel.Text;
            string vorname = gui.txtbFirstName.Text;
            string nachname = gui.txtbLastName.Text;
            string geschlecht = gui.ddlGender.Text;
            string geburtsdatum = gui.dtpBirthday.Value.ToString("yyyy-MM-dd");
            string mail = gui.txtbEMail.Text;
            string status = gui.ddbStatus.Text;
            string acctype = "";

            // -------------------------- Prüfen ob Mitarbeiter oder Kunde und Accounttyp setzen --------------------------
            if (!gui.rbttCustomer.Checked && !gui.rbttEmployee.Checked)
            {
                MessageBox.Show("Bitte Kunde oder Mitarbeiter auswählen!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (gui.rbttEmployee.Checked == true)
                {
                    acctype = "Mitarbeiter";

                    if (gui.ChbTrainee.Checked)
                    {
                        if (!ValidateRequiredFields(gui.groupBoxTrainee))
                        {
                            MessageBox.Show("Bitte alle Pflichtfelder für Lernende ausfüllen!");
                            return;
                        }
                    }
                    if (
                        string.IsNullOrWhiteSpace(vorname) ||
                        string.IsNullOrWhiteSpace(nachname) ||
                        string.IsNullOrWhiteSpace(geschlecht) ||
                        string.IsNullOrWhiteSpace(geburtsdatum) ||
                        string.IsNullOrWhiteSpace(mail) ||
                        string.IsNullOrWhiteSpace(status) ||
                        !ValidateRequiredFields(gui.groupBoxEmployee))
                    {
                        MessageBox.Show("Bitte alle Pflichtfelder ausfüllen!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    acctype = "Kunde";

                    if (string.IsNullOrWhiteSpace(vorname) ||
                        string.IsNullOrWhiteSpace(nachname) ||
                        string.IsNullOrWhiteSpace(geschlecht) ||
                        string.IsNullOrWhiteSpace(geburtsdatum) ||
                        string.IsNullOrWhiteSpace(mail) ||
                        string.IsNullOrWhiteSpace(status))
                    {
                        MessageBox.Show("Bitte alle Pflichtfelder ausfüllen!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }


            string dbPfad = Path.Combine(Application.StartupPath, "contactManagerDB.db");

            using (var connection = new SQLiteConnection($"Data Source={dbPfad};Version=3;"))
            {
                connection.Open();

                string sql = @"
                    INSERT INTO Global 
                    (Anrede, Vorname, Name, Geschlecht, Geburtstag, `E-Mail`, Status, Accounttyp) 
                    VALUES 
                    (@anrede, @vorname, @nachname, @geschlecht, @geburtsdatum, @mail, @status, @Accounttyp)";

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
                    command.Parameters.AddWithValue("@Accounttyp", acctype);

                    command.ExecuteNonQuery();

                    long globalId = connection.LastInsertRowId;

                    if (gui.rbttEmployee.Checked)
                    {
                        string eintrittsdatum = gui.dtphiringdate.Value.ToString("yyyy-MM-dd");
                        string austrittsdatum = gui.dtpExitDate.Value.ToString("yyyy-MM-dd");
                        string strasse = gui.txtbEmpStreet.Text;
                        string PLZ = gui.txtbEmpPlz.Text;
                        string Ort = gui.txtbEmpPlace.Text;
                        string handynummer = gui.txtbMoPhone.Text;
                        string beschaeftigungsgrad = gui.nudEmpLevel.Text;
                        string abteilung = gui.ddbDepartment.Text;
                        string kaderstufe = gui.ddbCadreLvl.Text;
                        string ahvnummer = gui.txtbAHVNr.Text;
                        string nationalitaet = gui.txtbNationality.Text;
                        string standort = gui.ddbLoAddress.Text;
                        string taetigkeit = gui.txtbRole.Text;
                        string telefonintern = gui.txtbIntPhNr.Text;

                        string updateMitarbeiter = @"
                        INSERT INTO Mitarbeiter 
                        (Mitarbeiternummer, eintrittsdatum, strasse, PLZ, Ort, handynummer, beschäftigungsgrad, abteilung, kaderstufe, ahvnummer, austrittsdatum, nationalität, standort, tätigkeitsbezeichnung, telefonnummerintern, globalid)
                        VALUES 
                        (@Mitarbeiternummer, @eintritt, @strasse, @PLZ, @Ort, @handy, @grad, @abteilung, @kader, @ahv, @austritt, @nationalitaet, @standort, @tätigkeitsbezeichnung, @telefon, @globalid);";

                        var cmdMitarbeiter = new SQLiteCommand(updateMitarbeiter, connection);

                        long neueMitarbeiternummer;
                        using (var getMaxCmd = new SQLiteCommand("SELECT MAX(mitarbeiternummer) FROM Mitarbeiter;", connection))
                        {
                            object result = getMaxCmd.ExecuteScalar();
                            if (result != DBNull.Value && result != null)
                            {
                                neueMitarbeiternummer = Convert.ToInt64(result) + 1;
                            }
                            else
                            {
                                neueMitarbeiternummer = 1; // erste Nummer
                            }
                        }
                        cmdMitarbeiter.Parameters.AddWithValue("@Mitarbeiternummer", neueMitarbeiternummer);
                        cmdMitarbeiter.Parameters.AddWithValue("@eintritt", eintrittsdatum);
                        cmdMitarbeiter.Parameters.AddWithValue("@strasse", strasse);
                        cmdMitarbeiter.Parameters.AddWithValue("@PLZ", PLZ);
                        cmdMitarbeiter.Parameters.AddWithValue("@Ort", Ort);
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


                        if (gui.ChbTrainee.Checked)
                        {
                            string lehrjahre = gui.txtbNrOfYearsOfAppr.Text;
                            string aktuelleslehrjahr = gui.txtbWhYearsOfAppr.Text;
                            string updateLernender = @"                         
                            INSERT INTO Lernender
                            (lehrjahre, aktuelleslehrjahr, globalid)
                            VALUES
                            (@lehrjahre, @aktuelleslehrjahr, @globalid);";

                            var cmdLernender = new SQLiteCommand(updateLernender, connection);
                            cmdLernender.Parameters.AddWithValue("@lehrjahre", lehrjahre);
                            cmdLernender.Parameters.AddWithValue("@aktuelleslehrjahr", aktuelleslehrjahr);
                            cmdLernender.Parameters.AddWithValue("@globalid", globalId);

                            cmdLernender.ExecuteNonQuery();
                        }

                        cmdMitarbeiter.ExecuteNonQuery();

                        MessageBox.Show("Daten erfolgreich gespeichert!", "Speichern erfolgreich!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }

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
                        string strasse = gui.txtbPrStreet.Text;
                        string PLZ = gui.txtprplz.Text;
                        string Ort = gui.TxtbCoPlace.Text;
                        string telefon = gui.txtbPrPhone.Text;
                        string note = gui.TxtbNote.Text;

                        string updateKunde = @"
                        INSERT INTO Kunde 
                        (kundentyp, firmenname, geschäftsadresse, geschäftsnummer, strasse, PLZ, Ort, telefon, note, globalid)
                        VALUES 
                        (@kundentyp, @firmenname, @geschaeftsadresse, @geschaeftsnummer, @strasse, @PLZ, @ort , @telefon, @note, @globalid);";

                        var cmdKunde = new SQLiteCommand(updateKunde, connection);
                        cmdKunde.Parameters.AddWithValue("@kundentyp", kundentyp);
                        cmdKunde.Parameters.AddWithValue("@firmenname", firmenname);
                        cmdKunde.Parameters.AddWithValue("@geschaeftsadresse", geschaeftsadresse);
                        cmdKunde.Parameters.AddWithValue("@geschaeftsnummer", geschaeftsnummer);
                        cmdKunde.Parameters.AddWithValue("@strasse", strasse);
                        cmdKunde.Parameters.AddWithValue("@PLZ", PLZ);
                        cmdKunde.Parameters.AddWithValue("@ort", Ort);
                        cmdKunde.Parameters.AddWithValue("@telefon", telefon);
                        if (!string.IsNullOrWhiteSpace(gui.TxtbNote.Text))
                        {
                            string datum = DateTime.Now.ToString("dd.MM.yyyy");
                            string notiz = $"{Environment.NewLine}[{datum}] {gui.TxtbNote.Text}";
                            cmdKunde.Parameters.AddWithValue("@note", notiz);
                        }
                        else
                        {
                            string notiz = "";
                            cmdKunde.Parameters.AddWithValue("@note", notiz);
                        }
                        cmdKunde.Parameters.AddWithValue("@globalid", globalId);

                        cmdKunde.ExecuteNonQuery();

                        MessageBox.Show("Daten erfolgreich gespeichert!", "Speichern erfolgreich!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
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
            //LadeDaten();
            return allValid;
        }
    }
}
