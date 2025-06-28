using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Manager_FL_MG_JW
{
    public partial class GUI_Create : Form
    {
        public GUI_Create()
        {
            InitializeComponent();
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
    }
}
