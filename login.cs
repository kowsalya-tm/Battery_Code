using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DWI
{
    public partial class login : Form
    {
        private bool isMainFormClosed = false;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static string bioMetric;
        int totalValue;
       
        public login()
        {
            InitializeComponent();
            employeeId();
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {
            pnlLogin.Location = new Point(
              this.ClientSize.Width / 2 - pnlLogin.Size.Width / 2,
              this.ClientSize.Height / 2 - pnlLogin.Size.Height / 2);
            pnlLogin.Anchor = AnchorStyles.None;
        }


        private void login_Load(object sender, EventArgs e)
        {
            string AssemblyLine = ConfigurationManager.AppSettings["AssemblyLine"];
            string ApplicationVersion = ConfigurationManager.AppSettings["ApplicationVersion"];
            string Environment = ConfigurationManager.AppSettings["Environment"];
            string Plant = ConfigurationManager.AppSettings["Plant"];
            this.Text = "Digital Work Instruction (" + Environment + ")" + " - " + ApplicationVersion + " - " + Plant  + " - " + AssemblyLine;
            lblerrorempid.Visible = false;
            employeeId();
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
        }
        
        
        private bool ValidateData()
        {
            erpLoginPage.Clear();
            bool Isvalid = true;

            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                txtUserName.Focus();
                erpLoginPage.SetError(txtUserName, "Please enter UserName");
                Isvalid = false;
            }

            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                txtPassword.Focus();
                erpLoginPage.SetError(txtPassword, "Please enter Password");
                Isvalid = false;
            }


            return Isvalid;
        }
        private void getoperator()
        {
            //Script to get employeeid
        }
        private void openForm()
        {
            string AssemblyLine = ConfigurationManager.AppSettings["AssemblyLine"];
            string ApplicationVersion = ConfigurationManager.AppSettings["ApplicationVersion"];
            string Environment = ConfigurationManager.AppSettings["Environment"];
            string Plant = ConfigurationManager.AppSettings["Plant"];

            if (!txtEmployeeId.Text.Equals(null))
            {
                // emissionDetail ed = new emissionDetail(txtEmpId.Text.ToString(),role);
                frmHome h = new frmHome();
                h.FormClosed += new FormClosedEventHandler(mainFormClosed);
                h.Text = "Digital Work Instruction (" + Environment + ")" + " - " + ApplicationVersion + " - " + Plant + " - " + AssemblyLine;
                this.Hide();
                h.Show();
            }
        }
       
        private void validateEmployee()
            {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
                con.Open();

                SqlCommand cmd = new SqlCommand(ApplicationConstants.LOGIN_SELECT_QUERY, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeCode", txtUserName.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;


                //If count is equal to 1, than show Main Page
                if (count == 1)
                {

                    bool Active = Convert.ToBoolean(ds.Tables[0].Rows[0]["Active"]);
                    if (Active)
                    {

                        string employeeCode = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                        string userRole = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                        //MessageBox.Show(employeeCode + "role " + userRole);
                        log.Info("Loged in as" + txtUserName.Text);
                        Global.LoginUserId = employeeCode;
                        Global.UserRole = userRole;
                        lblAuthStat.Text = "Success\nPlease enter EmployeeId";
                        lblAuthStat.ForeColor = Color.LimeGreen;
                        lblAuthStat.Visible = true;
                        grpEmpId.Visible = true;
                        txtUserName.Enabled = false;
                        txtPassword.Enabled = false;
                        this.txtEmployeeId.Focus();
                    }
                     else
                    {
                        MessageBox.Show($"User is inactive",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        log.Error("Inactive User" + txtUserName.Text);
                    }
                }
                else
                {
                    lblAuthStat.Text = "User Name and Password Mismatched";
                    lblAuthStat.ForeColor = Color.Red;
                    lblAuthStat.Visible = true;
                    //MessageBox.Show($"User Name and Password Mismatch",
                    //                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //log.Error("User Name and Password Mismatch" + txtUserName.Text);
                            
                }
            }
            catch (Exception ex)
            {
                log.Debug("Issue in Sql Server" + ex.Message);
                log.Error(ex.Message);
                MessageBox.Show("Some issue in Sql Server:" + ex.Message);
                clear();
            }
        }
       
        private void employeeId()
        {
            bioMetric= ConfigurationManager.AppSettings["BioMetric"];
            if(bioMetric=="True")
            {
                grpEmpId.Visible = false;
            }
            else if(bioMetric == "false")
            {
                grpEmpId.Visible = true;
            }
        }
        private bool validateEmpid()
        {
            bool isvalid = true;
            totalValue = txtEmployeeId.Text.Length;
            if (totalValue > 8)
            {
                isvalid = false;
            }
            return isvalid;
        }
        private void clear()
        {
            this.rbtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnLogin.ForeColor = Color.White;
            this.rbtnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnEnter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnEnter.ForeColor = Color.White;
        }

        private void rbtnLogin_Click(object sender, EventArgs e)
        {
            log.Info("Enter Button Clicked By " + txtUserName.Text);
            this.rbtnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(216)))), ((int)(((byte)(94)))));
            this.rbtnEnter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(216)))), ((int)(((byte)(94)))));
            this.rbtnEnter.ForeColor = Color.Black;

            if (string.IsNullOrEmpty(txtEmployeeId.Text.Trim()))
            {
                txtEmployeeId.Focus();
                erpLoginPage.SetError(txtEmployeeId, "Please enter EmployeeId");
                MessageBox.Show($"Please correct validation errors:\n {erpLoginPage.GetError(txtEmployeeId)} \n ",
                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (validateEmpid())
                {

                    Global.OperatorId = txtEmployeeId.Text;
                    openForm();
                    erpLoginPage.Clear();
                }
                else
                {
                    lblerrorempid.Visible = true;
                    lblerrorempid.Text = "Please enter 8 characters";
                    lblerrorempid.ForeColor = Color.Red;
                    txtEmployeeId.Text = "";

                }
            }
        }
        private void mainFormClosed(object sender, FormClosedEventArgs e)
        {
            this.isMainFormClosed = true;
            this.Close();
        }
        private void rbtnEnter_Click(object sender, EventArgs e)
        {
                log.Info("login button clicked by " + txtEmployeeId.Text);
                this.rbtnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(216)))), ((int)(((byte)(94)))));
                this.rbtnEnter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(216)))), ((int)(((byte)(94)))));
                this.rbtnEnter.ForeColor = Color.Black;
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                txtUserName.Focus();
                lblAuthStat.Text = "Please enter UserName";
                lblAuthStat.ForeColor = Color.Red;
                lblAuthStat.Visible = true;
                //erpLoginPage.SetError(txtUserName, "Please enter UserName");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                txtPassword.Focus();
                lblAuthStat.Text = "Please enter Password";
                lblAuthStat.ForeColor = Color.Red;
                lblAuthStat.Visible = true;
               // erpLoginPage.SetError(txtPassword, "Please enter Password");

            }
            else
            {
                validateEmployee();
                erpLoginPage.Clear();
                clear();
            }

        }
        private void rbtnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                openForm();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
                {
                    txtUserName.Focus();
                    lblAuthStat.Text = "Please enter UserName";
                    lblAuthStat.ForeColor = Color.Red;
                    lblAuthStat.Visible = true;
                   // erpLoginPage.SetError(txtUserName, "Please enter UserName");
                }
                else if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    txtPassword.Focus();
                    lblAuthStat.Text = "Please enter Password";
                    lblAuthStat.ForeColor = Color.Red;
                    lblAuthStat.Visible = true;
                    //erpLoginPage.SetError(txtPassword, "Please enter Password");
                }
                else
                {
                    validateEmployee();
                    erpLoginPage.Clear();
                    clear();
                }

            }
        }

        private void txtEmployeeId_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                var regex = new Regex(@"[^a-zA-Z0-9\s\b]");
                if (regex.IsMatch(e.KeyChar.ToString()))
                {
                    e.Handled = true;
                }
            
            if (e.KeyChar == 13)
            {

                if (string.IsNullOrEmpty(txtEmployeeId.Text.Trim()))
                {
                    txtEmployeeId.Focus();
                    //erpLoginPage.SetError(txtEmployeeId, "Please enter EmployeeId");
                    //MessageBox.Show($"Please correct validation errors:\n {erpLoginPage.GetError(txtEmployeeId)} \n ",
                    //    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblerrorempid.Visible = true;
                    lblerrorempid.Text = "Please enter EmployeeId";
                    lblerrorempid.ForeColor = Color.Red;
                    txtEmployeeId.Text = "";
                    clear();
                }
                else
                {
                    if (validateEmpid())
                    {
                        Global.OperatorId = txtEmployeeId.Text;
                        openForm();
                        erpLoginPage.Clear();
                    }
                    else
                    {

                        lblerrorempid.Visible = true;
                        lblerrorempid.Text = "Please enter 8 characters";
                        lblerrorempid.ForeColor = Color.Red;
                        txtEmployeeId.Text = "";
                        clear();
                    }
                }
            }
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.isMainFormClosed)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to close the application", ApplicationConstants.APPLICATION_NAME,
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }

            }
        }
    }
}
