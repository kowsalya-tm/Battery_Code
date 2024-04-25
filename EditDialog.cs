using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWI
{
    public partial class EditDialog : Form
    {
         public string result = "";
        public EditDialog()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblwarning.Visible = false;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (rdbtn_TCU.Checked)
            {
                this.result = "TCU";
                this.Close();
            }
            else if(rdbtn_battery.Checked)
            {
                this.result = "BATTERY";
                this.Close();
            }
            else
            {
                lblwarning.Visible = true;
            }
            
        }

        private void rdbtn_TCU_CheckedChanged(object sender, EventArgs e)
        {
            lblwarning.Visible = false;
        }
    }
}
