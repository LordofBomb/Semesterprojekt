namespace Contact_Manager_FL_MG_JW
{
    public partial class GUI_Dashboard : Form
    {
        public GUI_Dashboard()
        {
            InitializeComponent();
        }

        private void bttmCreateOnDash_Click(object sender, EventArgs e)
        {
            GUI_Create createForm = new GUI_Create(); // Neues Fenster erzeugen
            createForm.Show(); // Fenster anzeigen (nicht modal)
        }
    }
}
