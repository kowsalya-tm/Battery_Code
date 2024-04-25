using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using System.Text.RegularExpressions;

namespace DWI
{
    public partial class frmMainLine : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        int exist;
        private string barcode, Status, vehicleCode, vinnumber, bioMetric, engineNumber, batteryCode, ShiftName, variantId, variantName, variantImage, assemblyLine, stationNumber, reworkStatus;
        int vehicleId, plantId, stationId, assignmentId, partUniqueNo;

        List<string> lisShiftFromTime = new List<string>();
        List<string> lisShiftToTime = new List<string>();
        List<string> lisShiftName = new List<string>();
        private MemoryStream ms;

        string ABSDetails, saleOrderNo, ABSNo, lineItem, engineNo;
        public frmMainLine()
        {

            InitializeComponent();
            getStation();
            getEmployeeId();
            rbtnComleted.Visible = false;
            rbtnRework.Visible = false;
            lblEmpName.Text = Global.OperatorId;

        }

        private void getStation()
        {
            //lblEmpName.Text = Global.OperatorId;
            //cmbPlant.Text = ConfigurationManager.AppSettings["Plant"];
            lblStationNo.Text = ConfigurationManager.AppSettings["StationNo"];
            lblStationName.Text = ConfigurationManager.AppSettings["Station"];
        }

        private void txtScanVehicle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !InputIsCommand;
            var regex = new Regex(@"[^A-Z^a-z0-9@\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
        bool InputIsCommand = false;
        private void txtScanVehicle_KeyDown(object sender, KeyEventArgs e)
        {
            InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
            barcode = txtScanVehicle.Text;
            if (e.KeyCode == Keys.Enter)
            {
                log.Info("Barcode Scanner Enter key event done for QR Code " + barcode);
                if (scanText())
                {
                    rbtnRework.Visible = true;
                }
                else
                {
                    clear();
                }

            }
        }
        private bool scanText()
        {
            bool isvalid = false;
            barcode = txtScanVehicle.Text;
            if (barcode.Contains("@"))
            {
                //string[] RollOff = barcode.Split('@');
                //vehicleCode = RollOff[0];
                //vinnumber = RollOff[2];
                //    lblVinNoValue.Text = vinnumber;







                string[] RollOff = txtScanVehicle.Text.Split('@');
                string ABSDetails, saleOrderNo, ABSNo, lineItem, engineNo;
                if (txtScanVehicle.Text.Length > 0 && RollOff.Length == 6 && !RollOff[3].StartsWith("-"))
                {
                    vehicleCode = RollOff[0];
                    engineNo = RollOff[1];
                    lblVinNoValue.Text = RollOff[2];
                    if (RollOff[3].Length >= 31)
                    {
                        ABSDetails = RollOff[3].Substring(0, 31);
                    }
                    else if (!(RollOff[3].Length >= 19))
                    {
                        ABSDetails = RollOff[3].Substring(0, 11);
                    }
                    else
                    {
                        ABSDetails = RollOff[3].Substring(0, 19);
                    }
                    if (RollOff[4].Contains("-"))
                    {
                        string[] SONumber = RollOff[4].Split('-');
                        saleOrderNo = SONumber[0];
                    }
                    else
                    {
                        saleOrderNo = RollOff[4];
                    }
                    lineItem = RollOff[5];
                    vinnumber = lblVinNoValue.Text;
                    //engineNo = txtEngineNo.Text;
                    ABSNo = ABSDetails;
                    if (isVINEngineExists())
                    {
                        process();
                    }
                    saleOrderNo = string.Empty;
                    lineItem = string.Empty;

                }
                if (txtScanVehicle.Text.Length > 0 && RollOff.Length == 6 && RollOff[3].StartsWith("-"))
                {

                    vehicleCode = RollOff[0];
                    engineNumber = RollOff[1];
                    lblVinNoValue.Text = RollOff[2];
                    if (RollOff[4].Contains("-"))
                    {
                        string[] SONumber = RollOff[4].Split('-');
                        saleOrderNo = SONumber[0];
                    }
                    else
                    {
                        saleOrderNo = RollOff[4];
                    }
                    lineItem = RollOff[5];
                    vinnumber = lblVinNoValue.Text;
                    //engineNo = txtEngineNo.Text;
                    ABSNo = string.Empty;
                    if (isVINEngineExists())
                    {
                        process();
                    }
                    saleOrderNo = string.Empty;
                    lineItem = string.Empty;

                }
                else if (txtScanVehicle.Text.Length > 0 && RollOff.Length == 5)
                {

                    vehicleCode = RollOff[0];
                    engineNo = RollOff[1];
                    lblVinNoValue.Text = RollOff[2];
                    if (RollOff[3].Contains("-"))
                    {
                        string[] SONumber = RollOff[3].Split('-');
                        saleOrderNo = SONumber[0];
                    }
                    else
                    {
                        saleOrderNo = RollOff[3];
                    }
                    lineItem = RollOff[4];
                    vinnumber = lblVinNoValue.Text;
                    //engineNo = txtEngineNo.Text;
                    ABSNo = string.Empty;
                    if (isVINEngineExists())
                    {
                        process();
                    }
                    saleOrderNo = string.Empty;
                    lineItem = string.Empty;
                }
                else if (txtScanVehicle.Text.Length > 0 && RollOff.Length == 4 && !RollOff[3].StartsWith("-"))
                {
                    if (RollOff[3].Length >= 31)
                    {
                        ABSDetails = RollOff[3].Substring(0, 31);
                    }

                    else if (!(RollOff[3].Length >= 19))
                    {
                        ABSDetails = RollOff[3].Substring(0, 11);
                    }
                    else
                    {
                        ABSDetails = RollOff[3].Substring(0, 19);
                    }
                    vehicleCode = RollOff[0];
                    engineNo = RollOff[1];
                    lblVinNoValue.Text = RollOff[2];
                    vinnumber = lblVinNoValue.Text;
                    //engineNo = txtEngineNo.Text;
                    saleOrderNo = string.Empty;
                    lineItem = string.Empty;

                    ABSNo = ABSDetails;
                    if (isVINEngineExists())
                    {
                        process();
                    }
                }
                else if (txtScanVehicle.Text.Length > 0 && RollOff.Length == 4 && RollOff[3].StartsWith("-"))
                {

                    vehicleCode = RollOff[0];
                    engineNo = RollOff[1];
                    lblVinNoValue.Text = RollOff[2];
                    vinnumber = lblVinNoValue.Text;
                    // engineNo = txtEngineNo.Text;
                    saleOrderNo = string.Empty;
                    lineItem = string.Empty;
                    ABSNo = String.Empty;
                    if (isVINEngineExists())
                    {
                        process();
                    }
                }
                else if (txtScanVehicle.Text.Length > 0 && RollOff.Length == 3)
                {
                    vehicleCode = RollOff[0];
                    engineNo = RollOff[1];
                    lblVinNoValue.Text = RollOff[2];
                    vinnumber = lblVinNoValue.Text;
                    //engineNo = txtEngineNo.Text;
                    ABSNo = "";
                    saleOrderNo = string.Empty;
                    lineItem = string.Empty;
                    if (isVINEngineExists())
                    {
                        process();
                    }
                }
                this.txtScanVehicle.Focus();
            }
            else
            {
                MessageBox.Show("Incorrect Barcode", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                isvalid = false;
                clear();
                log.Error(" Incorrect Barcode ");
            }
            return isvalid;
        }

        private bool process()
        {

            bool isvalid = false;

            //if (validate_Vinnumber())
            //        {

            DataTable dt = Vinumber_exist();  //***********check in emission details******

            exist = dt.Rows.Count;
            if (exist == 0)
            {
                if (getVehicleDetails())
                {
                    isvalid = true;
                    txtScanPart.Select();
                    this.ActiveControl = txtScanPart;
                    txtScanPart.Focus();
                }
            }
            else if (exist >= 1)
            {
                Status = dt.Rows[0]["Status"].ToString();
                if (Status == "Completed")

                {
                    MessageBox.Show("The VinNumber and Part you have entered already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                    isvalid = false;
                    clear();
                }
            }
            else if (Status != "Completed")
            {
                DialogResult resultmsg;
                resultmsg = MessageBox.Show(" The VinNumber you have entered is in Rework Status.\n Do you want to Continue?",
                    "Information",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (resultmsg == DialogResult.Yes)
                {

                    if (getVehicleDetails())
                    {
                        isvalid = true;
                        txtScanPart.Select();
                        this.ActiveControl = txtScanPart;
                        txtScanPart.Focus();
                    }
                }
                else
                {
                    clear();
                }
            }

            else
            {
                isvalid = false;
                clear();
            }
            return isvalid;
        }
		
        
            
    private void clear()
        {
            txtScanVehicle.Select();
            this.ActiveControl = txtScanVehicle;
            txtScanVehicle.Focus();
            rbtnComleted.Visible = false;
            rbtnRework.Visible = false;
            txtScanVehicle.Clear();
            txtScanPart.Clear();
            lblVinNoValue.Text = "";
            lblModelCodeValue.Text = "";
            lblModelDescValue.Text = "";
            lblPartCodeValue.Text = "";
            lblPartDescValue.Text = "";
            lblOrderTypeValue.Text = "";
            lblColor.Text = "";
            
        }

        private DataTable Vinumber_exist()
        {
            DataTable dt = null;
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
                con.Open();
                SqlCommand cmd;
                cmd = new SqlCommand(ApplicationConstants.CheckIsVinNoExists, con);
                cmd.Parameters.AddWithValue("@vinnumber", vinnumber);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Error  While checking Vinumber in MainLine" + " " + ex.Message, "Information",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1);
                log.Error(lblVinNoValue.Text + " " + "Sql Error  While checking Mainline table" + " " + ex.Message);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sql Error  While checking Vinumber in MainLine " + " " + ex.Message, "Information",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1);
                 log.Error(lblVinNoValue.Text + " " + "Sql Error  While checking Vinumber in Mainline table " + " " + ex.Message);
                clear();
            }

            return dt;
        }

        private void rbtnComleted_Click(object sender, EventArgs e)
        {
            // partUniqueNo = int.Parse((lblScanPart.Text).ToString());
           string reworkReason = "";
            string completedStatus = "Completed";
            DataTable dt = Vinumber_exist();  //***********check in emission details******
            exist = dt.Rows.Count;
            if (exist == 0)
            {
                save(reworkReason, completedStatus);
            }
            else if (exist == 1)
            {
                reworkStatus = dt.Rows[0]["Status"].ToString();
                if (reworkStatus == "Rework")
                {
                    reworkUpdate(reworkReason, completedStatus);
                }
            }
           else
            {
                clear();
            }

        }

        private void rbtnRework_Click(object sender, EventArgs e)
        {
            reworkReason();
            string rwkReason = Global.reworkReason;
            string reworkStatus = "Rework";
            DataTable dt = Vinumber_exist();  //***********check in emission details******
            exist = dt.Rows.Count;
            if(exist==0)
            {
                save(rwkReason, reworkStatus);
            }
            else if(exist==1)
            {
                reworkStatus= dt.Rows[0]["Status"].ToString();
                if(reworkStatus=="Rework")
                {
                    reworkUpdate(rwkReason, reworkStatus);
                }
            }
            else
            {
                clear();
            }

        }

        private void frmMainLine_Load(object sender, EventArgs e)
        {
            rbtnComleted.Visible = false;
            rbtnRework.Visible = false;
            
            lblEmpName.Text = Global.OperatorId;
            getEmployeeId();
        }

        private void txtScanPart_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                if (ValidateData())
                {
                    //partUniqueNo = int.Parse(txtScanPart.Text);
                    rbtnComleted.Visible = true;
                }
                else
                {
                    MessageBox.Show($"Please correct validation errors:\n {erpMainLine.GetError(txtScanVehicle)} \n " +
                       $"{erpMainLine.GetError(txtScanPart)}\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                }
            }
        }

        
        private bool ValidateData()
        {
            erpMainLine.Clear();
            bool Isvalid = true;

            if (string.IsNullOrEmpty(txtScanVehicle.Text.Trim()))
            {
                txtScanVehicle.Focus();
                erpMainLine.SetError(txtScanVehicle, "Please Scan Vehicle");
                Isvalid = false;
            }

            if (string.IsNullOrEmpty(txtScanPart.Text.Trim()))
            {
                txtScanPart.Focus();
                erpMainLine.SetError(txtScanPart, "Please Scan Part");
                Isvalid = false;
            }
            return Isvalid;
        }
        private bool validate_Vinnumber()
        {
            bool isvalid = false;
            try
            {
                log.Info("Initiated for VinNumber Validation");
                SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
                con.Open();
                SqlCommand cmd;
                cmd = new SqlCommand(ApplicationConstants.ValidateVinnumber, con);
                cmd.Parameters.AddWithValue("@vinnumber", vinnumber);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                int total = dt.Rows.Count;
                if (total == 1)
                {
                    lblVinNoValue.Text = dt.Rows[0]["VinNumber"].ToString();
                    isvalid = true;
                    log.Info("VinNumber Validation Success and details displayed");
                }
                else
                {
                    log.Error("VinNumber Validation Failed");
                    isvalid = false;
                    clear();

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Error while Validating VinNumber" + " " + ex.Message, "Information",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information,
                           MessageBoxDefaultButton.Button1);
                log.Error(lblVinNoValue.Text + " " + "Sql Error while Validating VinNumber and vehicle details from DB" + " " + ex.Message);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Validating VinNumber" + " " + ex.Message, "Information",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information,
                           MessageBoxDefaultButton.Button1);
                 log.Error(lblVinNoValue.Text + " " + "Error while Validating VinNumber and vehicle details from DB" + " " + ex.Message);
                clear();
            }
            return isvalid;
        }

        private bool isVINEngineExists()
        {
            String[] ABSvalue = new string[3];
            string ABSKit = string.Empty, ABSModulator = string.Empty;
            if (ABSDetails.Length >= 31)
            {
                ABSvalue = ABSDetails.Split('_');
                ABSModulator = ABSvalue[0];
                ABSKit = ABSvalue[1];
            }
            else if (ABSDetails.Length == 19)
            {
                ABSKit = ABSDetails;
            }
            else if (ABSDetails.Length == 11)
            {
                ABSModulator = ABSDetails;
            }
            else
            {
                ABSModulator = string.Empty;
                ABSKit = string.Empty;
            }
            bool isvalid = true;
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
                SqlCommand cmd;
                con.Open();
                cmd = new SqlCommand("usp_CheckRelationIsVINENGINEEXISTS", con);
                cmd.Parameters.AddWithValue("@ABSModulator", ABSModulator);
                cmd.Parameters.AddWithValue("@ABSKit", ABSKit);
                cmd.Parameters.AddWithValue("@VINNO", lblVinNoValue.Text);
                cmd.Parameters.AddWithValue("@ENGINENO", engineNo);
                cmd.Parameters.AddWithValue("@PLantCode", ConfigurationManager.AppSettings["LocationValue"]);
                cmd.Parameters.AddWithValue("@AssemblyLine", ConfigurationManager.AppSettings["AssemblyLine"]);
                cmd.CommandType = CommandType.StoredProcedure;
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                if (result == 0)
                {
                    isvalid = false;
                    MessageBox.Show("Invalid QRCode. Please scan a valid QRCode",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                    clear();
                }
            }
            catch (SqlException ex)
            {
                isvalid = false;
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                isvalid = false;
                MessageBox.Show(ex.Message);
            }

            return isvalid;
        }
        private void save(string reworkReason,string status)
        {
            
            log.Info("Inside Save Action in Battery");
            try
            {
                BindShiftDetails();
                SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
                con.Open();
                SqlCommand cmd;
                cmd = new SqlCommand(ApplicationConstants.AddMainLineVehicle, con);
                cmd.Parameters.AddWithValue("@vinNumber", lblVinNoValue.Text);
                cmd.Parameters.AddWithValue("@vehicleId", vehicleId);
                cmd.Parameters.AddWithValue("@vehicleCode", vehicleCode);
                cmd.Parameters.AddWithValue("@orderType", lblOrderTypeValue.Text);
                cmd.Parameters.AddWithValue("@staionId", stationId);
                cmd.Parameters.AddWithValue("@staionNumber", stationNumber);
                cmd.Parameters.AddWithValue("@assemblyLine", assemblyLine);
                cmd.Parameters.AddWithValue("@plantId", plantId);
                cmd.Parameters.AddWithValue("@assignmentId", assignmentId);
                cmd.Parameters.AddWithValue("@variantId", variantId);
                cmd.Parameters.AddWithValue("@partUniqueNo", txtScanPart.Text);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@reworkReason", reworkReason);
                cmd.Parameters.AddWithValue("@qHoldRemarks", "");
                cmd.Parameters.AddWithValue("@reworkRemarks", "");
                cmd.Parameters.AddWithValue("@approvalReason", "");
                cmd.Parameters.AddWithValue("@productionDate", "");
                cmd.Parameters.AddWithValue("@reworkReleaseDate", "");
                cmd.Parameters.AddWithValue("@approvalDate", "");
                cmd.Parameters.AddWithValue("@approvedBy", "");
                cmd.Parameters.AddWithValue("@shift", ShiftName);
                cmd.Parameters.AddWithValue("@assembledBy", Global.OperatorId); 
                cmd.Parameters.AddWithValue("@reworkedBy", "");
               cmd.Parameters.AddWithValue("@createdBy", Global.OperatorId); 
                //cmd.Parameters.AddWithValue("@Action", Action);
                cmd.CommandType = CommandType.StoredProcedure;
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    //MessageBox.Show("Added");
                    Global.reworkReason = "";
                    clear();

                }
                con.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601)
                {
                    log.Debug("The VinNumber and Part you have entered already exists" + ex.Message);
                    MessageBox.Show("The VinNumber and Part you have entered already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    clear();
                }
                else
                {
                    MessageBox.Show("Sql Error  While Adding Vinumber in Mainline" + " " + ex.Message, "Information",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1);
                    log.Error(lblVinNoValue.Text + " " + "Sql Error  While  Adding Vinumber in Mainline table" + " " + ex.Message);
                    clear();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error  While  Adding Vinumber in Mainline " + " " + ex.Message, "Information",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1);
                log.Error(lblVinNoValue.Text + " " + "Sql Error  While  Adding Vinumber in Mainline table" + " " + ex.Message);
                clear();
            }
        }
        private void reworkReason()
        {
            DialogResult result = DialogResult.No;
            ReworkReason RR = new ReworkReason();
            result = RR.ShowDialog();
            this.Enabled = false;
            if (result == DialogResult.OK)
            {
                reworkReasonFormClosed();
            }
        }
        private void reworkReasonFormClosed()
        {
            string a = Global.reworkReason;
            this.Enabled = true;
           // clear();
        }
        private void BindShiftDetails()
        {
            lisShiftFromTime.Clear();
            lisShiftToTime.Clear();
            lisShiftName.Clear();
            try
            {
                DataSet dsRole = null;
                SqlConnection conSettings = null;
                SqlCommand cmdSettings = null;
                SqlDataAdapter daSettings = null;
                dsRole = new DataSet();
                conSettings = new SqlConnection(ConnectionString.GetConnectionString());
                conSettings.Open();
                cmdSettings = new SqlCommand(ApplicationConstants.GetShiftDetails, conSettings);

                cmdSettings.Parameters.AddWithValue("@ShiftId", 0);
                cmdSettings.Parameters.AddWithValue("@ShiftName", string.Empty);
                cmdSettings.CommandType = CommandType.StoredProcedure;
                daSettings = new SqlDataAdapter();
                daSettings.SelectCommand = cmdSettings;
                daSettings.Fill(dsRole);
                for (int i = 0; i < dsRole.Tables[0].Rows.Count; i++)
                {
                    lisShiftFromTime.Add(dsRole.Tables[0].Rows[i]["ShiftFromTime"].ToString());
                    lisShiftToTime.Add(dsRole.Tables[0].Rows[i]["ShiftToTime"].ToString());
                    lisShiftName.Add(dsRole.Tables[0].Rows[i]["ShiftName"].ToString());

                }
                conSettings.Close();
                TimeSpan today = DateTime.Parse(System.DateTime.Now.ToString("HH:mm")).TimeOfDay;

                for (int index = 0; index < lisShiftFromTime.Count; index++)
                {
                    TimeSpan fromtime = DateTime.Parse(lisShiftFromTime[index].ToString()).TimeOfDay;
                    TimeSpan totime = DateTime.Parse(lisShiftToTime[index].ToString()).TimeOfDay;
                    DateTime testTimeString = new DateTime(2021, 11, 2, 12, 00, 00);
                    TimeSpan testTime = DateTime.Parse(testTimeString.ToString()).TimeOfDay;
                    if (fromtime > testTime && totime < testTime && today > testTime)
                    {
                        if ((today >= fromtime) && (today >= totime))
                        {
                            ShiftName = lisShiftName[index].ToString();
                        }
                    }
                    else if (fromtime > testTime && totime < testTime && today < testTime)
                    {
                        if ((today <= fromtime) && (today <= totime))
                        {
                            ShiftName = lisShiftName[index].ToString();
                        }
                    }
                    else
                    {
                        if ((today >= fromtime) && (today <= totime))
                        {
                            ShiftName = lisShiftName[index].ToString();
                        }
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                log.Error(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                log.Error(ex.Message);
            }
        }

        private void getEmployeeId()
        {
            bioMetric = ConfigurationManager.AppSettings["BioMetric"];
            if (bioMetric == "False"||bioMetric=="false")
            {
                lblEmpName.Text = Global.OperatorId;
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlCommand cmdEmployee = new SqlCommand(ApplicationConstants.GetEmployeeId, con);
                    string deviceid = ConfigurationManager.AppSettings["AssemblyLine"];
                    string stationNumber = ConfigurationManager.AppSettings["Station"];
                    cmdEmployee.Parameters.AddWithValue("@deviceId", deviceid);
                    cmdEmployee.Parameters.AddWithValue("@StationNumber", stationNumber);
                    cmdEmployee.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmdEmployee);
                    // da.SelectCommand = cmdEmployee;
                    da.Fill(dt);
                    int result = cmdEmployee.ExecuteNonQuery();
                    int total = dt.Rows.Count;
                    string employeeId = dt.Rows[0]["EmployeeID"].ToString();
                    lblEmpName.Text = employeeId;
                    con.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Sql Error while getting EmployeeId" + " " + ex.Message, "Information",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information,
                           MessageBoxDefaultButton.Button1);
                    log.Error(" " + "Sql Error while getting EmployeeId" + " " + ex.Message);
                    clear();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while getting EmployeeId" + " " + ex.Message, "Information",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information,
                           MessageBoxDefaultButton.Button1);
                    log.Error(" " + "Error while getting EmployeeId" + " " + ex.Message);
                    clear();
                }
            }
        }
        private bool getVehicleDetails()
        {
            bool isvalid = false;
            try
            {
                log.Info("Initiated to Get Vehicle Details");
                SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
                con.Open();
                SqlCommand cmd;
                cmd = new SqlCommand(ApplicationConstants.GetVehicleDetails, con);
                cmd.Parameters.AddWithValue("@vehicleCode", vehicleCode);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                int total = dt.Rows.Count;
                if (total == 1)
                {
                   // lblVinNoValue.Text = dt.Rows[0]["VinNumber"].ToString();
                    lblModelCodeValue.Text = dt.Rows[0]["ModelCode"].ToString();
                    lblModelDescValue.Text = dt.Rows[0]["ModelDescription"].ToString();
                    lblPartCodeValue.Text = dt.Rows[0]["VariantCode"].ToString();
                    lblPartDescValue.Text = dt.Rows[0]["VariantName"].ToString();
                    lblOrderTypeValue.Text = dt.Rows[0]["OrderType"].ToString();
                    assemblyLine = dt.Rows[0]["Assemblyline"].ToString();
                    lblColor.Text = dt.Rows[0]["Color"].ToString();
                   vehicleId =int.Parse(dt.Rows[0]["VehicleId"].ToString());
                    plantId = int.Parse(dt.Rows[0]["Plant"].ToString());
                    stationId = int.Parse(dt.Rows[0]["StationId"].ToString());
                    stationNumber = dt.Rows[0]["StationNumber"].ToString();
                    assignmentId = int.Parse(dt.Rows[0]["Assignment_id"].ToString());
                    variantId =dt.Rows[0]["VariantCode"].ToString();
                    variantName = dt.Rows[0]["VariantName"].ToString();
                    variantImage= dt.Rows[0]["VariantImage"].ToString();
                    //  var img1=Converter.

                    //ImageConverter converter = new ImageConverter();
                    //Image img = pictureBox1.Image;
                    //var Img1 = converter.ConvertTo(Variant.VariantImage, typeof(byte[]));
                    // variant.VariantImage = Img1;
                    //Byte[] Img1 = (Byte[])new ImageConverter().ConvertTo(dt.Rows[0]["VariantImage"], typeof(Byte[]));

                //    byte[] photo_aray;

                    //photo_aray = (byte[])dt.Rows[0]["VariantImage"];
                    //MemoryStream ms = new MemoryStream(photo_aray);
                    //picBoxPartVariant.Image = Image.FromStream(ms);

                   // MemoryStream ms = new MemoryStream(Img1);
                   // picBoxPartVariant.Image = new Bitmap(ms);
                    isvalid = true;
                    // log.Info("VinNumber Validation Success and details displayed");
                }
                else
                {
                    log.Error("Getting Vehicle Details Failed for vehiclecode "+vehicleCode);
                    isvalid = false;
                    clear();

                }
            }
            catch (SqlException ex)
            {
                isvalid = false;
                MessageBox.Show("Sql Error while getting vinnumber and vehicle details" + " " + ex.Message, "Information",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information,
                           MessageBoxDefaultButton.Button1);
                log.Error(lblVinNoValue.Text + " " + "Sql Error while getting vinnumber and vehicle details from DB" + " " + ex.Message);
                clear();
            }
            
            catch (Exception ex)
            {
                isvalid = false;
                MessageBox.Show("Error while getting vinnumber and vehicle details" + " " + ex.Message, "Information",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information,
                           MessageBoxDefaultButton.Button1);
                 log.Error(lblVinNoValue.Text + " " + "Error while getting vinnumber and vehicle details from DB" + " " + ex.Message);
                clear();
            }
            return isvalid;
        }
        private void reworkUpdate(string reworkReason, string status)
        {

            log.Info("Inside Rework Update in Battery");
            try
            {
                BindShiftDetails();
                SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
                con.Open();
                SqlCommand cmd;
                cmd = new SqlCommand(ApplicationConstants.UpdateReworkBattery, con);
                cmd.Parameters.AddWithValue("@vinNumber", lblVinNoValue.Text);
                cmd.Parameters.AddWithValue("@partUniqueNo", txtScanPart.Text);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@reworkReason", reworkReason);
                cmd.Parameters.AddWithValue("@shift", ShiftName);
                cmd.Parameters.AddWithValue("@assembledBy", Global.OperatorId);
                cmd.Parameters.AddWithValue("@reworkedBy", "");
                cmd.Parameters.AddWithValue("@updatedBy", Global.OperatorId);
                //cmd.Parameters.AddWithValue("@Action", Action);
                cmd.CommandType = CommandType.StoredProcedure;
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    //MessageBox.Show("Added");
                    Global.reworkReason = "";
                    clear();

                }
                con.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601)
                {
                    log.Debug("The VinNumber and Part you have entered already exists" + ex.Message);
                    MessageBox.Show("The VinNumber and Part you have entered already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    clear();
                }
                else
                {
                    MessageBox.Show("Sql Error  While Adding Vinumber in Mainline" + " " + ex.Message, "Information",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1);
                    log.Error(lblVinNoValue.Text + " " + "Sql Error  While  Adding Vinumber in Mainline table" + " " + ex.Message);
                    clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error  While  Adding Vinumber in Mainline " + " " + ex.Message, "Information",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1);
                log.Error(lblVinNoValue.Text + " " + "Sql Error  While  Adding Vinumber in Mainline table" + " " + ex.Message);
                clear();
            }
        }
    }
       
}

