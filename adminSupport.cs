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
    public partial class adminSupport : Form
    {
        public adminSupport()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAdminSupport_Paint(object sender, PaintEventArgs e)
        {
            lblAdminSupport.Location = new Point(
             this.ClientSize.Width / 2 - lblAdminSupport.Size.Width / 2,
             this.ClientSize.Height / 2 - lblAdminSupport.Size.Height / 2);
            lblAdminSupport.Anchor = AnchorStyles.None;
        }
    }
}
