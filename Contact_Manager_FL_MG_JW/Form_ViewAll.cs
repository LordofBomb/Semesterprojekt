using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Contact_Manager_FL_MG_JW
{
    public partial class Form_ViewAll : UserControl
    {
        private DataGridView dataGridView;
        private TextBox txtSuche;
        private Button BtnOpen;
        private Button BtnDeleteDash;
        private Button btnSuche;

        public Form_ViewAll()
        {
            InitializeComponent();
            LadeDatenDashboard();
        }

        private void InitializeComponent()
        {
            txtSuche = new TextBox();
            btnSuche = new Button();
            dataGridView = new DataGridView();
            BtnOpen = new Button();
            BtnDeleteDash = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // txtSuche
            // 
            txtSuche.Location = new Point(10, 14);
            txtSuche.Name = "txtSuche";
            txtSuche.Size = new Size(446, 31);
            txtSuche.TabIndex = 0;
            // 
            // btnSuche
            // 
            btnSuche.Location = new Point(477, 9);
            btnSuche.Name = "btnSuche";
            btnSuche.Size = new Size(140, 40);
            btnSuche.TabIndex = 1;
            btnSuche.Text = "Suchen";
            btnSuche.Click += BtnSuche_Click;
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeight = 34;
            dataGridView.Location = new Point(10, 55);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(908, 350);
            dataGridView.TabIndex = 2;
            dataGridView.CellDoubleClick += DataGridView_CellDoubleClick;
            // 
            // BtnOpen
            // 
            BtnOpen.Location = new Point(633, 9);
            BtnOpen.Name = "BtnOpen";
            BtnOpen.Size = new Size(140, 40);
            BtnOpen.TabIndex = 3;
            BtnOpen.Text = "Eintrag öffnen";
            BtnOpen.Click += BtnOpen_Click;
            // 
            // BtnDeleteDash
            // 
            BtnDeleteDash.Location = new Point(788, 9);
            BtnDeleteDash.Name = "BtnDeleteDash";
            BtnDeleteDash.Size = new Size(130, 40);
            BtnDeleteDash.TabIndex = 4;
            BtnDeleteDash.Text = "Eintrag Löschen";
            BtnDeleteDash.Click += BtnDeleteDash_Click;
            // 
            // Form_ViewAll
            // 
            BackColor = Color.Transparent;
            Controls.Add(BtnDeleteDash);
            Controls.Add(BtnOpen);
            Controls.Add(txtSuche);
            Controls.Add(btnSuche);
            Controls.Add(dataGridView);
            Name = "Form_ViewAll";
            Size = new Size(928, 416);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        public void UpdateDashboard()
        {
            LadeDatenDashboard();
        }
        private void LadeDatenDashboard(string filter1 = "")
        {
            string dbPfad1 = Path.Combine(Application.StartupPath, "contactManagerDB.db");

            using (var connection1 = new SQLiteConnection($"Data Source={dbPfad1};Version=3;"))
            {
                connection1.Open();
                string sql1 = "SELECT globalid, Accounttyp, Anrede, Titel, Vorname, Name, Geschlecht, `E-Mail`, CAST(Geburtstag AS TEXT) AS Geburtstag, Status FROM Global";

                if (!string.IsNullOrWhiteSpace(filter1))
                    sql1 += " WHERE Vorname LIKE @filter OR Name LIKE @filter OR `E-Mail` LIKE @filter";

                using (var command1 = new SQLiteCommand(sql1, connection1))
                {
                    if (!string.IsNullOrWhiteSpace(filter1))
                        command1.Parameters.AddWithValue("@filter", "%" + filter1 + "%");

                    using (var adapter1 = new SQLiteDataAdapter(command1))
                    {
                        DataTable dt1 = new DataTable();
                        adapter1.Fill(dt1);
                        dataGridView.DataSource = dt1;
                    }
                }
            }
        }

        private void BtnSuche_Click(object sender, EventArgs e)
        {
            LadeDatenDashboard(txtSuche.Text.Trim());
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string dbPfad = Path.Combine(Application.StartupPath, "contactManagerDB.db");

            using (var connection = new SQLiteConnection($"Data Source={dbPfad};Version=3;"))
            {
                connection.Open();

                string sql = "SELECT \r\n    g.*,\r\n    m.strasse AS mitarbeiter_strasse,\r\n    m.PLZ AS mitarbeiter_PLZ,\r\n    m.Ort AS mitarbeiter_Ort,\r\n    m.*,\r\n    l.*,\r\n    k.strasse AS kunde_strasse,\r\n    k.PLZ AS kunde_PLZ,\r\n    k.Ort AS kunde_Ort,\r\n    k.*\r\nFROM Global g\r\nLEFT JOIN Mitarbeiter m ON g.globalid = m.globalid\r\nLEFT JOIN Lernender l ON m.mitarbeiternummer = l.mitarbeiterID\r\nLEFT JOIN Kunde k ON g.globalid = k.globalid;\r\n";


                using (var command = new SQLiteCommand(sql, connection))
                {

                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (e.RowIndex >= 0)
                        {
                            var row = dt.Rows[e.RowIndex];
                            var bearbeitenFormular = new GUI_Create();
                            bearbeitenFormular.BtnSave.Text = "Eintrag Aktualisieren";

                            if (!row.IsNull("mitarbeiternummer"))
                            {

                                bearbeitenFormular.rbttEmployee.Checked = true;
                                bearbeitenFormular.lblEmpNrOut.Text = row.Field<long>("Mitarbeiternummer").ToString();
                                bearbeitenFormular.txtbAHVNr.Text = row.Field<string>("ahvnummer");
                                bearbeitenFormular.txtbEmpStreet.Text = row.Field<string>("mitarbeiter_strasse");
                                bearbeitenFormular.txtbEmpPlz.Text = row.Field<string>("mitarbeiter_plz");
                                bearbeitenFormular.txtbEmpPlace.Text = row.Field<string>("mitarbeiter_ort");
                                bearbeitenFormular.txtbMoPhone.Text = row.Field<string>("Handynummer");
                                bearbeitenFormular.txtbNationality.Text = row.Field<string>("nationalität");
                                bearbeitenFormular.ddbLoAddress.Text = row.Field<string>("Standort");
                                bearbeitenFormular.dtphiringdate.Value = DateTime.Parse(row.Field<string>("Eintrittsdatum"));
                                bearbeitenFormular.txtbIntPhNr.Text = row.Field<string>("telefonnummerintern");
                                bearbeitenFormular.dtpExitDate.Value = DateTime.Parse(row.Field<string>("Austrittsdatum"));
                                bearbeitenFormular.ddbCadreLvl.Text = row.Field<string>("Kaderstufe");
                                bearbeitenFormular.ddbDepartment.Text = row.Field<string>("Abteilung");
                                bearbeitenFormular.txtbRole.Text = row.Field<string>("Tätigkeitsbezeichnung");
                                bearbeitenFormular.nudEmpLevel.Text = row.Field<long>("Beschäftigungsgrad").ToString();

                                if (!row.IsNull("mitarbeiterid") && !row.IsNull("lehrjahre"))
                                {
                                    bearbeitenFormular.ChbTrainee.Checked = true;

                                    bearbeitenFormular.txtbNrOfYearsOfAppr.Text = row.Field<string>("lehrjahre");
                                    bearbeitenFormular.txtbWhYearsOfAppr.Text = row.Field<string>("aktuelleslehrjahr");
                                }
                            }
                            else if (!row.IsNull("kundentyp"))
                            {


                                bearbeitenFormular.rbttCustomer.Checked = true;

                                string kundentyp = row.Field<string>("kundentyp");
                                switch (kundentyp)
                                {
                                    case "A":
                                        bearbeitenFormular.rbttKtA.Checked = true;
                                        break;
                                    case "B":
                                        bearbeitenFormular.rbttKtB.Checked = true;
                                        break;
                                    case "C":
                                        bearbeitenFormular.rbttKtC.Checked = true;
                                        break;
                                    case "D":
                                        bearbeitenFormular.rbttKtD.Checked = true;
                                        break;
                                    case "E":
                                        bearbeitenFormular.rbttKtE.Checked = true;
                                        break;
                                }

                                bearbeitenFormular.txtbCoName.Text = row.Field<string>("firmenname");
                                bearbeitenFormular.txtbCoAddresse.Text = row.Field<string>("geschäftsadresse");
                                bearbeitenFormular.txtbCoPhoneNr.Text = row.Field<string>("geschäftsnummer");

                                bearbeitenFormular.txtbPrStreet.Text = row.Field<string>("kunde_strasse");
                                bearbeitenFormular.txtprplz.Text = row.Field<string>("kunde_plz");
                                bearbeitenFormular.TxtbCoPlace.Text = row.Field<string>("kunde_ort");
                                bearbeitenFormular.txtbPrPhone.Text = row.Field<string>("telefon");
                            }
                            bearbeitenFormular.txtbFirstName.Text = row.Field<string>("Vorname");
                            bearbeitenFormular.txtbLastName.Text = row.Field<string>("Name");
                            bearbeitenFormular.ddlSalutation.Text = row.Field<string>("Anrede");
                            bearbeitenFormular.txtbTitel.Text = row.Field<string>("Titel");
                            bearbeitenFormular.ddlGender.Text = row.Field<string>("Geschlecht");
                            bearbeitenFormular.txtbEMail.Text = row.Field<string>("E-Mail");
                            if (row.Field<string>("Geburtstag") != null)
                            {
                                bearbeitenFormular.dtpBirthday.Value = DateTime.Parse(row.Field<string>("Geburtstag"));
                            }
                            bearbeitenFormular.ddbStatus.Text = row.Field<string>("Status");
                            bearbeitenFormular.Tag = row.Field<long>("globalid").ToString();

                            bearbeitenFormular.BtnDelete.Visible = true;
                            bearbeitenFormular.Show();

                            LadeDatenDashboard();
                        }
                    }
                }
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView.SelectedRows[0].Index;

                DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(0, rowIndex);

                DataGridView_CellDoubleClick(dataGridView, args);
            }
            else
            {
                MessageBox.Show("Bitte zuerst einen Eintrag auswählen.");
            }
        }

        private void BtnDeleteDash_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bitte zuerst einen Eintrag auswählen.");
                return;
            }

            // GlobalID aus der selektierten Zeile holen
            long globalId = Convert.ToInt64(dataGridView.SelectedRows[0].Cells["globalid"].Value);

            DialogResult result = MessageBox.Show(
                "Möchtest du diesen Eintrag wirklich löschen?\nDieser Vorgang kann nicht rückgängig gemacht werden.",
                "Eintrag löschen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            string dbPfad = Path.Combine(Application.StartupPath, "contactManagerDB.db");

            using (var connection = new SQLiteConnection($"Data Source={dbPfad};Version=3;"))
            {
                connection.Open();

                // Optional: erst nachschauen ob es ein Mitarbeiter oder Kunde ist
                string accountType = "";
                using (var cmdCheck = new SQLiteCommand("SELECT Accounttyp FROM Global WHERE globalid = @id;", connection))
                {
                    cmdCheck.Parameters.AddWithValue("@id", globalId);
                    accountType = cmdCheck.ExecuteScalar()?.ToString();
                }

                // Wenn Mitarbeiter, dann zuerst Lernender löschen, dann Mitarbeiter
                if (accountType == "Mitarbeiter")
                {
                    // Lernender löschen
                    string deleteLernender = @"
                DELETE FROM Lernender 
                WHERE mitarbeiterid IN (
                    SELECT mitarbeiternummer FROM Mitarbeiter WHERE globalid = @globalid
                );";

                    using (var cmdLernender = new SQLiteCommand(deleteLernender, connection))
                    {
                        cmdLernender.Parameters.AddWithValue("@globalid", globalId);
                        cmdLernender.ExecuteNonQuery();
                    }

                    // Mitarbeiter löschen
                    string deleteMitarbeiter = "DELETE FROM Mitarbeiter WHERE globalid = @globalid;";
                    using (var cmdMitarbeiter = new SQLiteCommand(deleteMitarbeiter, connection))
                    {
                        cmdMitarbeiter.Parameters.AddWithValue("@globalid", globalId);
                        cmdMitarbeiter.ExecuteNonQuery();
                    }
                }

                // Wenn Kunde, Kundeneintrag löschen
                if (accountType == "Kunde")
                {
                    string deleteKunde = "DELETE FROM Kunde WHERE globalid = @globalid;";
                    using (var cmdKunde = new SQLiteCommand(deleteKunde, connection))
                    {
                        cmdKunde.Parameters.AddWithValue("@globalid", globalId);
                        cmdKunde.ExecuteNonQuery();
                    }
                }

                // Zum Schluss Global löschen
                string deleteGlobal = "DELETE FROM Global WHERE globalid = @globalid;";
                using (var cmdGlobal = new SQLiteCommand(deleteGlobal, connection))
                {
                    cmdGlobal.Parameters.AddWithValue("@globalid", globalId);
                    cmdGlobal.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Eintrag erfolgreich gelöscht.");
            LadeDatenDashboard();

    }
}
}
