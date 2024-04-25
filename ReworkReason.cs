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
    public partial class ReworkReason : Form
    {
        public ReworkReason()
        {
            InitializeComponent();
        }

        private void rbtnPartNotAvailable_Click(object sender, EventArgs e)
        {
            string reason = "PartNotAvailable";
            reworkReason(reason);
        }
        private void reworkReason(string reason)
        {
            Global.reworkReason = reason;
            this.DialogResult = DialogResult.OK;
            this.Hide();

            this.rbtnPartNotAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnPartNotAvailable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnPartNotAvailable.ForeColor = Color.White;
        }

        private void rbtnPartDamaged_Click(object sender, EventArgs e)
        {
            string reason = "PartDamaged";
            reworkReason(reason);
        }

        private void rbtnOthers_Click(object sender, EventArgs e)
        {
            string reason = "Others";
            reworkReason(reason);
        }

        private void rbtnClose_Click(object sender, EventArgs e)
        {
            Global.reworkReason = "";
            this.DialogResult = DialogResult.No;
            this.Hide();

            this.rbtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnClose.ForeColor = Color.White;
        }


    }
}
