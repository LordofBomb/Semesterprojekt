using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Manager_FL_MG_JW
{
    public partial class Form_ViewAll : UserControl
    {
        private DataGridView dataGridView;
        private TextBox txtSuche;
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

            txtSuche.Location = new System.Drawing.Point(10, 10);
            txtSuche.Size = new System.Drawing.Size(200, 27);

            btnSuche.Location = new System.Drawing.Point(220, 10);
            btnSuche.Size = new System.Drawing.Size(100, 27);
            btnSuche.Text = "Suchen";
            btnSuche.Click += BtnSuche_Click;

            dataGridView.Location = new System.Drawing.Point(10, 50);
            dataGridView.Size = new System.Drawing.Size(760, 350);
            dataGridView.ReadOnly = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.CellDoubleClick += DataGridView_CellDoubleClick;

            Controls.Add(txtSuche);
            Controls.Add(btnSuche);
            Controls.Add(dataGridView);

            this.Size = new System.Drawing.Size(780, 420);
        }

        public void LadeDatenDashboard(string filter1 = "")
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
                string sql = "SELECT * FROM global LEFT JOIN mitarbeiter ON global.globalid = Mitarbeiter.globalid ;";


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

                            if (row.Field<string>("Accounttyp") == "Mitarbeiter")
                            {
                                bearbeitenFormular.rbttEmployee.Checked = true;
                                bearbeitenFormular.lblEmpNrOut.Text = row.Field<long>("Mitarbeiternummer").ToString();
                                bearbeitenFormular.txtbAHVNr.Text = row.Field<string>("ahvnummer");
                                bearbeitenFormular.txtbEmpStreet.Text = row.Field<string>("strasse");
                                bearbeitenFormular.txtbEmpPlz.Text = row.Field<string>("PLZ");
                                bearbeitenFormular.txtbEmpPlace.Text = row.Field<string>("Ort");
                                bearbeitenFormular.txtbMoPhone.Text = row.Field<string>("Handynummer");
                                bearbeitenFormular.txtbNationality.Text = row.Field<string>("nationalität");
                                bearbeitenFormular.ddbLoAddress.Text = row.Field<string>("Standort");
                                bearbeitenFormular.dtphiringdate.Value = DateTime.Parse(row.Field<string>("Eintrittsdatum"));
                                bearbeitenFormular.txtbIntPhNr.Text = row.Field<string>("telefonnummerintern");
                                bearbeitenFormular.dtpExitDate.Value = DateTime.Parse(row.Field<string>("Austrittsdatum"));
                                bearbeitenFormular.ddbCadreLvl.Text = row.Field<long>("Kaderstufe").ToString();
                                bearbeitenFormular.ddbDepartment.Text = row.Field<string>("Abteilung");
                                bearbeitenFormular.txtbRole.Text = row.Field<string>("Tätigkeitsbezeichnung");
                                bearbeitenFormular.nudEmpLevel.Text = row.Field<long>("Beschäftigungsgrad").ToString();
                            }
                            else
                            {
                                bearbeitenFormular.rbttCustomer.Checked = true;
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

                            bearbeitenFormular.Show();
                            LadeDatenDashboard();
                        }
                    }
                    }
            }
            
        }
    }
}
