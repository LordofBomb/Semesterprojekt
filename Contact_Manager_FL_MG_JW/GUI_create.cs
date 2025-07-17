using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Contact_Manager_FL_MG_JW
{
    public partial class GUI_Create : Form
    {
        public GUI_Create()
        {
            InitializeComponent();
            radioGroupboxHide();
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
            var creator = new createNewEntry(this);
            creator.CreatePerson(sender, e);
        }
    }
}
