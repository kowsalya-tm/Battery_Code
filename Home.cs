using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace DWI
{
    public partial class frmHome : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        // public static string empid, role;
        public static string CurrTime = "", bioMetric;
       public static int skip;
        public static string shift = "";
        public static string shift1time = ConfigurationManager.AppSettings["shift1time"];
        public static string shift2time = ConfigurationManager.AppSettings["shift2time"];
        public static string shift3time = ConfigurationManager.AppSettings["shift3time"];
       
        
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome1_Load(object sender, EventArgs e)
        {
            
            if (getEmployeeId())
            {
                LoadUserMenus();
            }
            else
            {
                login lg = new login();
                this.Hide();
                lg.Show();
            }
        }

        #region Design
        private void CustomizeDesign()
        {
            //pnlStation.Visible = false;
            //pnlReport.Visible = false;
          
        }
        private void HideSubMenu()
        {
            /*if (pnlStation.Visible == true)
                pnlStation.Visible = false;
            if (pnlReport.Visible == true)
                pnlReport.Visible = false;*/
        }

        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }

        }
        private Form ActiveForm = null;

        private void OpenChildForm(Form ChildForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(ChildForm);
            pnlMain.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
           // label1.Text = ChildForm.Text;

        }
        private void ExpandmMenu()
        {
            PnlLeft.Width = 250;
            //  pictureBox2.Width = 250;
            // panel9.Width = 250;
            //btnStation.Text = "  " + "Station";
            btnReports.Text = "  " + "Report";
            btnSettings.Text = "  " + "Setting";
            //btnStation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
          btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // btnNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }
        private void CollapseMenu()
        {

            PnlLeft.Width = 80;
            //btnStation.Text = "";
            //   btnUsers.TextImageRelation = TextImageRelation.ImageAboveText;

            btnReports.Text = "";
            btnSettings.Text = "";
            
        }
        private void pictureBoxToggle_Click(object sender, EventArgs e)
        {
            if (PnlLeft.Width > 249)
            {
                HideSubMenu();
                CollapseMenu();
             }
            else
            {
                ExpandmMenu();
            }
        }
        #endregion Design
        private void LoadUserMenus()
        {
            if (Global.UserRole.ToUpper() == "DWI USER")
            {
                pictureBoxToggle.Visible = false;
                picBoxLogout.Visible = true;
                //btnAdmin.Visible = true;
                PnlLeft.Visible = false;
               // btnStation.Visible = false;
                btnReports.Visible = false;
                btnSettings.Visible = false;

                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["Station"].ToString()) && (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["Plant"].ToString())) && (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["StationType"].ToString())) && (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["AssemblyLine"].ToString())))
                {

                    if (ConfigurationManager.AppSettings["StationType"].ToUpper() == "MAINLINE")
                    {
                        OpenChildForm(new adminSupport());
                    }
                    else if (config.AppSettings.Settings["StationType"].Value.ToUpper() == "QHOLD")
                    {
                        OpenChildForm(new adminSupport());
                    }
                    else if (config.AppSettings.Settings["StationType"].Value.ToUpper() == "SUBASSEMBLY")
                    {
                        OpenChildForm(new adminSupport());
                    }
                    else if (config.AppSettings.Settings["StationType"].Value.ToUpper() == "REWORK")
                    {
                        OpenChildForm(new adminSupport());
                    }
                    else if (config.AppSettings.Settings["StationType"].Value.ToUpper() == "BATTERY")
                    {
                        OpenChildForm(new frmBattery());
                    }

                    else
                    {
                        OpenChildForm(new adminSupport());
                    }
                }
                else
                {
                    OpenChildForm(new adminSupport());
                }
            }
            if (Global.UserRole.ToUpper() == "DWI SUPERVISOR")
            {
                pictureBoxToggle.Visible = false;
                if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["Station"].ToString()) && (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["Plant"].ToString())) && (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["StationType"].ToString())) && (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["StationNo"].ToString())) && (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["AssemblyLine"].ToString())))
                {
                    PnlLeft.Visible = false;
                    btnReports.Visible = false;
                    btnSettings.Visible = false;
                    OpenChildForm(new report());
                }
                else
                {
                    PnlLeft.Visible = false;
                    btnReports.Visible = false;
                    btnSettings.Visible = false;
                    OpenChildForm(new adminSupport());
                }
            }
            if (Global.UserRole.ToUpper() == "DWI ADMIN")
            {
                //pictureBoxToggle.Visible = true;
                //PnlLeft.Visible = true;
                //btnReports.Visible = true;
                //btnSettings.Visible = true;
                //OpenChildForm(new report());
                if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["Station"].ToString()) && (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["Plant"].ToString())) && (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["StationType"].ToString())) && (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["StationNo"].ToString())) && (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["AssemblyLine"].ToString())))
                {
                    PnlLeft.Visible = true;
                    btnReports.Visible = true;
                    btnSettings.Visible = true;
                    OpenChildForm(new report());
                }
                else
                {
                    PnlLeft.Visible = false;
                    btnReports.Visible = false;
                    btnSettings.Visible = false;
                    OpenChildForm(new frmSetting());
                }
            }
        }

        private void LoadDesign()
        {
          //  PnlLeft.Visible = false;
            //btnStation.Visible = false;
            //btnReports.Visible = false;
            //btnSettings.Visible = false;
            //pnlStation.Visible = false;
          // pnlReport.Visible = false;
        }
        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            log.Info("logout button clicked by" + Global.LoginUserId);
            DialogResult result = MessageBox.Show("Do you want to logout", ApplicationConstants.APPLICATION_NAME,
                                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                logoff();
            }
        }
        private void frmHome1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you want to close the application", ApplicationConstants.APPLICATION_NAME,
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
      
       
       
        private void logoff()
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        private void btnStation_Click(object sender, EventArgs e)
        {
            ExpandmMenu();
           // ShowSubMenu(pnlStation);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
             OpenChildForm(new report());
            ExpandmMenu();
           // ShowSubMenu(pnlReport);
        }

        #region Station
        private void btnMainline_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmMainLine());

        }

        private void btnSubStation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSubAssembly());
        }

        private void btnQHStation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQhold());

        }

        private void btnReworkStation_Click(object sender, EventArgs e)
        {

        }
        #endregion Station

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            logoff();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSetting());
        }
        private bool getEmployeeId()
        {
            bool isvalid = false;
            bioMetric = ConfigurationManager.AppSettings["BioMetric"];
            if (bioMetric == "False" || bioMetric == "false")
            {
                //lblEmpName.Text = Global.OperatorId;
                isvalid = true;
            }
            else
            {
                PnlLeft.Visible = false;
                isvalid = false;
                MessageBox.Show(" BioMetric Table Not Found.\n Please Contact Administrator  ", "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error,
                       MessageBoxDefaultButton.Button1);
            }
            return isvalid;
        }
    }
}
