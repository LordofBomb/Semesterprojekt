using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager_FL_MG_JW
{
    public partial class GUI_ViewAll : Form
    {
        private DataGridView dataGridView;
        private TextBox txtSuche;
        private Button btnSuche;

        public GUI_ViewAll()
        {
            InitializeComponent();
            LadeDaten();
        }

        private void InitializeComponent()
        {
            this.dataGridView = new DataGridView();
            this.txtSuche = new TextBox();
            this.btnSuche = new Button();

            // txtSuche
            this.txtSuche.Location = new System.Drawing.Point(12, 12);
            this.txtSuche.Size = new System.Drawing.Size(200, 27);

            // btnSuche
            this.btnSuche.Location = new System.Drawing.Point(220, 12);
            this.btnSuche.Size = new System.Drawing.Size(100, 27);
            this.btnSuche.Text = "Suchen";
            this.btnSuche.Click += BtnSuche_Click;

            // dataGridView
            this.dataGridView.Location = new System.Drawing.Point(12, 50);
            this.dataGridView.Size = new System.Drawing.Size(760, 400);
            this.dataGridView.ReadOnly = true;
            this.dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.CellDoubleClick += DataGridView_CellDoubleClick;

            // Form
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.txtSuche);
            this.Controls.Add(this.btnSuche);
            this.Controls.Add(this.dataGridView);
            this.Text = "Alle Kontakte anzeigen";
        }

        private void LadeDaten(string filter = "")
        {
            string dbPfad = Path.Combine(Application.StartupPath, "contactManagerDB.db");

            using (var connection = new SQLiteConnection($"Data Source={dbPfad};Version=3;"))
            {
                connection.Open();
                string sql = "SELECT globalid, Anrede, Titel, Vorname, Name, Geschlecht, `E-Mail`, Geburtstag, Status FROM Global";

                if (!string.IsNullOrWhiteSpace(filter))
                {
                    sql += " WHERE Vorname LIKE @filter OR Name LIKE @filter OR `E-Mail` LIKE @filter";
                }

                using (var command = new SQLiteCommand(sql, connection))
                {
                    if (!string.IsNullOrWhiteSpace(filter))
                    {
                        command.Parameters.AddWithValue("@filter", "%" + filter + "%");
                    }

                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView.DataSource = dt;
                    }
                }
            }
        }

        private void BtnSuche_Click(object sender, EventArgs e)
        {
            string filter = txtSuche.Text.Trim();
            LadeDaten(filter);
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                GUI_Create bearbeitenFormular = new GUI_Create();

                bearbeitenFormular.txtbFirstName.Text = row.Cells["Vorname"].Value.ToString();
                bearbeitenFormular.txtbLastName.Text = row.Cells["Name"].Value.ToString();
                bearbeitenFormular.ddlSalutation.Text = row.Cells["Anrede"].Value.ToString();
                bearbeitenFormular.txtbTitel.Text = row.Cells["Titel"].Value.ToString();
                bearbeitenFormular.ddlGender.Text = row.Cells["Geschlecht"].Value.ToString();
                bearbeitenFormular.txtbEMail.Text = row.Cells["E-Mail"].Value.ToString();
                bearbeitenFormular.dtpBirthday.Text = row.Cells["Geburtstag"].Value.ToString();
                bearbeitenFormular.ddbStatus.Text = row.Cells["Status"].Value.ToString();

                bearbeitenFormular.Tag = row.Cells["globalid"].Value.ToString();

                bearbeitenFormular.Show();
            }
        }

    }
}
