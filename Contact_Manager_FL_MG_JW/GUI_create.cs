using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Contact_Manager_FL_MG_JW
{
    public partial class GUI_Create : Form
    {
        public GUI_Create()
        {
            InitializeComponent();
            createDBIfNotCreated();
            radioGroupboxHide();

        }

        private void ddlGender_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            string anrede = ddlSalutation.Text;
            string titel = txtbTitel.Text;
            string vorname = txtbFirstName.Text;
            string nachname = txtbLastName.Text;
            string geschlecht = ddlGender.Text;
            string geburtsdatum = dtpBirthday.Text;
            string mail = txtbEMail.Text;  
            string status = ddbStatus.Text;

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

                    if (!rbttCustomer.Checked && !rbttEmployee.Checked)
                    {
                        MessageBox.Show("Fehler! Bitte Kunde oder Mitarbeiter auswählen!");
                    }

                    long globalId = connection.LastInsertRowId;

                    if (rbttEmployee.Checked)
                    {
                        string eintrittsdatum = dtphiringdate.Value.ToString("yyyy-MM-dd");
                        string austrittsdatum = dtpExitDate.Value.ToString("yyyy-MM-dd");
                        string adresse = txtbEmpAddress.Text;
                        string handynummer = txtbMoPhone.Text;
                        string beschaeftigungsgrad = nudEmpLevel.Text;
                        string abteilung = ddbDepartment.Text;
                        int kaderstufe = 0;
                        int.TryParse(ddbCadreLvl.Text, out kaderstufe);
                        string ahvnummer = txtbAHVNr.Text;
                        string wohnort = txtbEmpResi.Text;
                        string nationalitaet = txtbNationality.Text;
                        string standort = ddbLoAddress.Text;
                        string taetigkeit = txtbRole.Text;
                        string telefonintern = txtbIntPhNr.Text;
                        string insertMitarbeiter = @"
                        INSERT INTO Mitarbeiter 
                        (eintrittsdatum, adresse, handynummer, beschäftigungsgrad, abteilung, kaderstufe, ahvnummer, austrittsdatum, wohnort, nationalität, standort, tätigkeitsbezeichnung, telefonnummerintern, globalid)
                        VALUES 
                        (@eintritt, @adresse, @handy, @grad, @abteilung, @kader, @ahv, @austritt, @ort, @nationalitaet, @standort, @tätigkeitsbezeichnung, @telefon, @globalid);";

                        var cmdMitarbeiter = new SQLiteCommand(insertMitarbeiter, connection);
                        cmdMitarbeiter.Parameters.AddWithValue("@eintritt", eintrittsdatum);
                        cmdMitarbeiter.Parameters.AddWithValue("@adresse", adresse);
                        cmdMitarbeiter.Parameters.AddWithValue("@handy", handynummer);
                        cmdMitarbeiter.Parameters.AddWithValue("@grad", beschaeftigungsgrad);
                        cmdMitarbeiter.Parameters.AddWithValue("@abteilung", abteilung);
                        cmdMitarbeiter.Parameters.AddWithValue("@kader", kaderstufe);
                        cmdMitarbeiter.Parameters.AddWithValue("@ahv", ahvnummer);
                        cmdMitarbeiter.Parameters.AddWithValue("@austritt", austrittsdatum);
                        cmdMitarbeiter.Parameters.AddWithValue("@ort", wohnort);
                        cmdMitarbeiter.Parameters.AddWithValue("@nationalitaet", nationalitaet);
                        cmdMitarbeiter.Parameters.AddWithValue("@standort", standort);
                        cmdMitarbeiter.Parameters.AddWithValue("@tätigkeitsbezeichnung", taetigkeit);
                        cmdMitarbeiter.Parameters.AddWithValue("@telefon", telefonintern);
                        cmdMitarbeiter.Parameters.AddWithValue("@globalid", globalId);
                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Daten erfolgreich gespeichert!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Fehler: " + ex.Message);
                        }
                        cmdMitarbeiter.ExecuteNonQuery();
                    }

                    if (rbttCustomer.Checked)
                    {
                        string kundentyp = "";
                        if (rbttKtA.Checked)
                        {
                            kundentyp = rbttKtA.Text;
                        }
                        else if (rbttKtB.Checked)
                        {
                            kundentyp = rbttKtB.Text;
                        }
                        else if (rbttKtC.Checked)
                        {
                            kundentyp = rbttKtC.Text;
                        }
                        else if (rbttKtD.Checked)
                        {
                            kundentyp = rbttKtD.Text;
                        }
                        else if (rbttKtE.Checked)
                        {
                            kundentyp = rbttKtE.Text;
                        }
                        if (string.IsNullOrWhiteSpace(kundentyp))
                        {
                            MessageBox.Show("Bitte Kundentyp wählen!");
                            return;
                        }
                        string firmenname = txtbCoName.Text;
                        string geschaeftsadresse = txtbCoAddresse.Text;
                        string geschaeftsnummer = txtbCoPhoneNr.Text;
                        string adresse = txtbPrAddress.Text;
                        string telefon = txtbPrPhone.Text;

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
                            command.ExecuteNonQuery();
                            MessageBox.Show("Daten erfolgreich gespeichert!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Fehler: " + ex.Message);
                        }
                        cmdKunde.ExecuteNonQuery();
                    }
                }
            }
        }
        private void createDBIfNotCreated()
        {
            string dbPfad = Path.Combine(Application.StartupPath, "contactManagerDB.db");
            if (!File.Exists(dbPfad))
            {
                SQLiteConnection.CreateFile(dbPfad);
            }

            using (var connection = new SQLiteConnection($"Data Source={dbPfad};Version=3;"))
            {
                connection.Open();

                string createTableSql = @"
        CREATE TABLE IF NOT EXISTS Global (
            Anrede TEXT,
            Titel TEXT,
            Vorname TEXT,
            Name TEXT,
            Geschlecht TEXT,
            `E-Mail` TEXT,
            Geburtstag INTEGER,
            Status TEXT
        );";

                var command = new SQLiteCommand(createTableSql, connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
