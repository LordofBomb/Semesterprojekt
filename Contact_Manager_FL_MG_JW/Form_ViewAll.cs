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
            LadeDaten();
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

        private void LadeDaten(string filter = "")
        {
            string dbPfad = Path.Combine(Application.StartupPath, "contactManagerDB.db");

            using (var connection = new SQLiteConnection($"Data Source={dbPfad};Version=3;"))
            {
                connection.Open();
                string sql = "SELECT globalid, Anrede, Titel, Vorname, Name, Geschlecht, `E-Mail`, CAST(Geburtstag AS TEXT) AS Geburtstag, Status FROM Global";

                if (!string.IsNullOrWhiteSpace(filter))
                    sql += " WHERE Vorname LIKE @filter OR Name LIKE @filter OR `E-Mail` LIKE @filter";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    if (!string.IsNullOrWhiteSpace(filter))
                        command.Parameters.AddWithValue("@filter", "%" + filter + "%");

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
            LadeDaten(txtSuche.Text.Trim());
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView.Rows[e.RowIndex];
                var bearbeitenFormular = new GUI_Create();

                bearbeitenFormular.txtbFirstName.Text = row.Cells["Vorname"].Value?.ToString();
                bearbeitenFormular.txtbLastName.Text = row.Cells["Name"].Value?.ToString();
                bearbeitenFormular.ddlSalutation.Text = row.Cells["Anrede"].Value?.ToString();
                bearbeitenFormular.txtbTitel.Text = row.Cells["Titel"].Value?.ToString();
                bearbeitenFormular.ddlGender.Text = row.Cells["Geschlecht"].Value?.ToString();
                bearbeitenFormular.txtbEMail.Text = row.Cells["E-Mail"].Value?.ToString();
                if (row.Cells["Geburtstag"].Value != null) 
                { 
                    bearbeitenFormular.dtpBirthday.Value = DateTime.Parse(row.Cells["Geburtstag"].Value.ToString()!); 
                }
                bearbeitenFormular.ddbStatus.Text = row.Cells["Status"].Value?.ToString();
                bearbeitenFormular.Tag = row.Cells["globalid"].Value?.ToString();

                bearbeitenFormular.Show();
            }
        }
    }
}
