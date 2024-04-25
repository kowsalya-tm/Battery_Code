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
using System.Drawing.Printing;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Globalization;

namespace DWI
{
    public partial class frmBattery : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        int exist;
        private string barcode, type, Status, plantId, vehicleCode, vinnumber, bioMetric, absNumber, engineNumber, batteryCode, ShiftName, variantId, variantName, variantImage, assemblyLine, stationNumber, reworkStatus, BatteryNo;
        int vehicleId, statusResultTimer = 0, exportAlertTimer=0, stationId, assignmentId, regionMappingId,countRollOff;
        string ABSDetails, saleOrderNo, ABSNo, lineItem, engineNo;
        string[] RollOff;
        string[] TCUbarcode;
        List<string> lisShiftFromTime = new List<string>();
        List<string> lisShiftToTime = new List<string>();
        List<string> lisShiftName = new List<string>();
        private MemoryStream ms;
        bool IsTcu = false;
        string IMEI = "";
        bool IsInserted = false;
        bool isEdit = false;
        enum Month
        {
            A = 1,  // Represents January
            B,  // Represents February
            C,  // Represents March
            D,  // Represents April
            E,  // Represents May
            F,  // Represents June
            G,  // Represents July
            H,  // Represents August
            J,  // Represents September                  
            K,  // Represents October
            L,  // Represents November
            M   // Represents December

        }
        public frmBattery()
        {
            InitializeComponent();
        }
        private void getStation()
        {
            //lblEmpName.Text = Global.OperatorId;
            //cmbPlant.Text = ConfigurationManager.AppSettings["Plant"];
            lblStationNo.Text = ConfigurationManager.AppSettings["StationNo"];
            lblStationName.Text = ConfigurationManager.AppSettings["Station"];
        }
       // bool InputIsCommand = false;
        private void txtScanVehicle_KeyDown(object sender, KeyEventArgs e)
        {
           // InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
            //barcode = txtScanVehicle.Text;
            if (e.KeyCode == Keys.Enter)
            {
                txtScanVehicle.Enabled = false;
                log.Info("Barcode Scanner Enter key event done");
                scanText();
            }
        }
        private void timerStatusResult_Tick(object sender, EventArgs e)
        {
            log.Info("Status Result Timer Started");
            statusResultTimer++;
            if (statusResultTimer == Int32.Parse(ConfigurationManager.AppSettings["StatusDuration"]))
            {
                timerStatusResult.Stop();
                rbtnStatus.Visible = false;
                log.Info("Status Result timer Stopped");
                statusResultTimer = 0;
                clear();
            }
        }
        private void txtScanVehicle_KeyPress(object sender, KeyPressEventArgs e)
        {
            // e.Handled = !InputIsCommand;
            //var regex = new Regex(@"[^A-Z^a-z0-9@\s\b]");
            //if (regex.IsMatch(e.KeyChar.ToString()))
            //{
            //    e.Handled = true;
            //}

            //var regex = new Regex(@"^[A-Z0-9@\b\-\_]+$");
            //var regex = new Regex(@"[A-Z0-9@\b-_]");
            //if (!regex.IsMatch(e.KeyChar.ToString()))
            //{
            //    e.Handled = true;
            //}
        
        }

        private void txtScanTCU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                if (ValidateTCU())
                {
                    txtScanTCU.Enabled = false;
                    IsInserted = false;
                    if (type == "Domestic" && isEdit == false)
                    {
                        completedTask();
                    }
                    if (IsInserted || type != "Domestic" || isEdit == true)
                    {
                        save_TCU();
                        if (ConfigurationManager.AppSettings["PrintAction"] == "True" || ConfigurationManager.AppSettings["PrintAction"] == "true")
                        {
                            print_label();
                        }
                    }
                }
            }
        }

        private void timerExport_Tick(object sender, EventArgs e)
        {
            log.Info("EXPORT Alert Timer Started");
            exportAlertTimer++;
            if (exportAlertTimer == Int32.Parse(ConfigurationManager.AppSettings["ExportAlertDuration"]))
            {
                timerExport.Stop();
                rbtnExportNotification.Visible = false;
                log.Info("EXPORT Alert timer Stopped");
                exportAlertTimer = 0;
                clear();
            }
        }
        private bool scanText()
        {
            bool isvalid = false;
            barcode = txtScanVehicle.Text;
            if (barcode.Contains("@"))
            {
                splitBarCode();
            }
            else
            {
                MessageBox.Show("Invalid QRCode. Please scan a valid QRCode", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                isvalid = false;
                clear();
                log.Error("Invalid QRCode. Please scan a valid QRCode " + txtScanVehicle.Text);
            }
            return isvalid;
        }
        private void splitBarCode()
        {
            log.Info("Scanned Data " + txtScanVehicle.Text);
            string[] RollOff = txtScanVehicle.Text.Split('@');
            countRollOff = RollOff.Count();
            ABSDetails = "";
            if (checkBarCode())
            {
                if (validateBarCode())
                {
                    process();
                   // if (txtScanVehicle.Text.Length > 0 && RollOff.Length == 6 && !RollOff[3].StartsWith("-"))
                   // {
                   //     vehicleCode = RollOff[0];
                   //     engineNo = RollOff[1];
                   //     lblVinNoValue.Text = RollOff[2];
                   //     if (RollOff[3].Length >= 31)
                   //     {
                   //         ABSDetails = RollOff[3].Substring(0, 31);
                   //     }
                   //     else if (!(RollOff[3].Length >= 19))
                   //     {
                   //         ABSDetails = RollOff[3].Substring(0, 11);
                   //     }
                   //     else
                   //     {
                   //         ABSDetails = RollOff[3].Substring(0, 19);
                   //     }
                   //     if (RollOff[4].Contains("-"))
                   //     {
                   //         string[] SONumber = RollOff[4].Split('-');
                   //         saleOrderNo = SONumber[0];
                   //     }
                   //     else
                   //     {
                   //         saleOrderNo = RollOff[4];
                   //     }
                   //     lineItem = RollOff[5];
                   //     vinnumber = lblVinNoValue.Text;
                   //     //engineNo = txtEngineNo.Text;
                   //     ABSNo = ABSDetails;
                   //     if (isVINEngineExists())
                   //     {
                   //         //if(validate_VehicleCode())
                   //         //{
                   //         //    process();
                   //         //}
                   //         process();
                   //     }
                   //     saleOrderNo = string.Empty;
                   //     lineItem = string.Empty;
                   // }
                   //else if (txtScanVehicle.Text.Length > 0 && RollOff.Length == 6 && RollOff[3].StartsWith("-"))
                   //{
                   //     vehicleCode = RollOff[0];
                   //     engineNumber = RollOff[1];
                   //     lblVinNoValue.Text = RollOff[2];
                   //     if (RollOff[4].Contains("-"))
                   //     {
                   //         string[] SONumber = RollOff[4].Split('-');
                   //         saleOrderNo = SONumber[0];
                   //     }
                   //     else
                   //     {
                   //         saleOrderNo = RollOff[4];
                   //     }
                   //     lineItem = RollOff[5];
                   //     vinnumber = lblVinNoValue.Text;
                   //     //engineNo = txtEngineNo.Text;
                   //     ABSNo = string.Empty;
                   //     if (isVINEngineExists())
                   //     {
                   //         //if (validate_VehicleCode())
                   //         //{
                   //         //    process();
                   //         //}
                   //         process();
                   //     }
                   //     saleOrderNo = string.Empty;
                   //     lineItem = string.Empty;
                   //}
                   // else if (txtScanVehicle.Text.Length > 0 && RollOff.Length == 5)
                   // {
                   //     vehicleCode = RollOff[0];
                   //     engineNo = RollOff[1];
                   //     lblVinNoValue.Text = RollOff[2];
                   //     if (RollOff[3].Contains("-"))
                   //     {
                   //         string[] SONumber = RollOff[3].Split('-');
                   //         saleOrderNo = SONumber[0];
                   //     }
                   //     else
                   //     {
                   //         saleOrderNo = RollOff[3];
                   //     }
                   //     lineItem = RollOff[4];
                   //     vinnumber = lblVinNoValue.Text;
                   //     //engineNo = txtEngineNo.Text;
                   //     ABSNo = string.Empty;
                   //     if (isVINEngineExists())
                   //     {
                   //         //if (validate_VehicleCode())
                   //         //{
                   //         //    process();
                   //         //}
                   //         process();
                   //     }
                   //     saleOrderNo = string.Empty;
                   //     lineItem = string.Empty;
                   // }
                   // else if (txtScanVehicle.Text.Length > 0 && RollOff.Length == 4 && !RollOff[3].StartsWith("-"))
                   // {
                   //     if (RollOff[3].Length >= 31)
                   //     {
                   //         ABSDetails = RollOff[3].Substring(0, 31);
                   //     }

                   //     else if (!(RollOff[3].Length >= 19))
                   //     {
                   //         ABSDetails = RollOff[3].Substring(0, 11);
                   //     }
                   //     else
                   //     {
                   //         ABSDetails = RollOff[3].Substring(0, 19);
                   //     }
                   //     vehicleCode = RollOff[0];
                   //     engineNo = RollOff[1];
                   //     lblVinNoValue.Text = RollOff[2];
                   //     vinnumber = lblVinNoValue.Text;
                   //     //engineNo = txtEngineNo.Text;
                   //     saleOrderNo = string.Empty;
                   //     lineItem = string.Empty;
                   //     ABSNo = ABSDetails;
                   //     if (isVINEngineExists())
                   //     {
                   //         //if (validate_VehicleCode())
                   //         //{
                   //         //    process();
                   //         //}
                   //         process();
                   //     }
                   // }
                   // else if (txtScanVehicle.Text.Length > 0 && RollOff.Length == 4 && RollOff[3].StartsWith("-"))
                   // {
                   //     vehicleCode = RollOff[0];
                   //     engineNo = RollOff[1];
                   //     lblVinNoValue.Text = RollOff[2];
                   //     vinnumber = lblVinNoValue.Text;
                   //     // engineNo = txtEngineNo.Text;
                   //     saleOrderNo = string.Empty;
                   //     lineItem = string.Empty;
                   //     ABSNo = String.Empty;
                   //     if (isVINEngineExists())
                   //     {
                   //         //if (validate_VehicleCode())
                   //         //{
                   //         //    process();
                   //         //}
                   //         process();
                   //     }
                   // }
                   // else if (txtScanVehicle.Text.Length > 0 && RollOff.Length == 3)
                   // {
                   //     vehicleCode = RollOff[0];
                   //     engineNo = RollOff[1];
                   //     lblVinNoValue.Text = RollOff[2];
                   //     vinnumber = lblVinNoValue.Text;
                   //     //engineNo = txtEngineNo.Text;
                   //     ABSNo = "";
                        
                   //     saleOrderNo = string.Empty;
                   //     lineItem = string.Empty;
                   //     if (isVINEngineExists())
                   //     {
                   //         //if (validate_VehicleCode())
                   //         //{
                   //         //    process();
                   //         //}
                   //         process();
                   //     }
                   // }
                    this.txtScanVehicle.Focus();
                }
            }
        }
           // if ((RollOff[3] ?? string2 ?? string3 ?? string4 ?? string5 ?? string6) == null)
        private bool checkBarCode()
        {
            bool isvalid = true;
            RollOff = txtScanVehicle.Text.Split('@');
            int coutRollOff = RollOff.Count();
            for (int i = 0; i < coutRollOff; i++)
            {
                if (string.IsNullOrEmpty(RollOff[i].Trim()))
                {
                    log.Info("Check Bar Code Failed for VIn " + txtScanVehicle.Text);
                    MessageBox.Show("Invalid QRCode. Please scan a valid QRCode",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                    isvalid = false;
                    clear();
                    break;
                }
                log.Info("Check Bar Code success for VIn " + txtScanVehicle.Text);
            }
            return isvalid;
        }
        private bool validateBarCode()
        {
            bool isvalid = false;
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
                SqlCommand cmd;
                con.Open();
                lblVinNoValue.Text = RollOff[2];
                vinnumber= RollOff[2];
                lblModelCodeValue.Text = RollOff[0];
                vehicleCode = RollOff[0];
                engineNo = RollOff[1];
                cmd = new SqlCommand("Select VinNo from vinenginemapping where VinNo='" + RollOff[2] + "'and EngineNo='" + RollOff[1] + "'and ModelCode='" + RollOff[0] + "';", con);
                con.Close();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    isvalid = false;
                    MessageBox.Show("Invalid QRCode. Please scan a valid QRCode",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                    clear();
                }
                else
                {
                    isvalid = true;
                }
            }
            catch (SqlException ex)
            {
                isvalid = false;
                MessageBox.Show("Sql Error while Validating Barcode" + " " + ex.Message, "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error,
                       MessageBoxDefaultButton.Button1);
                log.Error(" " + "Sql Error while Validating Barcode" + " " + ex.Message);
                clear();

            }
            catch (Exception ex)
            {
                isvalid = false;
                MessageBox.Show("Error while Validating Barcode" + " " + ex.Message, "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error,
                       MessageBoxDefaultButton.Button1);
                log.Error(" " + "Error while Validating Barcode" + " " + ex.Message);
                clear();
            }
            return isvalid;
        }
        private bool isVINEngineExists()
        {
            log.Info("Initiated to check Is VIN Engine Exists for vin " + txtScanVehicle.Text);
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
                string locationvalue = ConfigurationManager.AppSettings["LocationValue"];
                string assemblyline = ConfigurationManager.AppSettings["AssemblyLine"];
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
                    log.Info("is vin engine exists failed for Vin " + txtScanVehicle.Text);
                    isvalid = false;
                    MessageBox.Show("Invalid QRCode. Please scan a valid QRCode",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                    clear();
                }
                log.Info("is vin engine exists success for Vin " + txtScanVehicle.Text);
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
        private bool validate_VehicleCode()
        {
            bool isvalid = true;
            try
            {
                log.Info("Initiated to Validate Vehiclecode");
                SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
                con.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("Select ModelCode from vinenginemapping where ModelCode='" + RollOff[0] + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                int total = dt.Rows.Count;
                if (total == 0)
                {
                    log.Error(RollOff[0]+" Vehiclecode Validation Failed");
                    isvalid = false;
                    MessageBox.Show("Invalid QRCode. Please scan a valid QRCode",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                    clear();
                }
                log.Info(RollOff[0] + " Vehiclecode Validation Success");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Error while Validating VehicleCode" + " " + ex.Message, "Information",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information,
                           MessageBoxDefaultButton.Button1);
                log.Error(lblVinNoValue.Text + " " + "Sql Error while Validating VehicleCode" + " " + ex.Message);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Validating VehicleCode" + " " + ex.Message, "Information",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information,
                           MessageBoxDefaultButton.Button1);
                log.Error(lblVinNoValue.Text + " " + "Error while Validating VehicleCode" + " " + ex.Message);
                clear();
            }
            return isvalid;
        }
        private bool process()
        {
            bool isvalid = false;

            //if (validate_Vinnumber())
            //{
                if (getVehicleDetails())
                {
                isEdit = false;
                    if (type == "Domestic")
                    {
                        DataTable dt = Vinumber_exist();  //***********check in MainLine******
                        exist = dt.Rows.Count;
                        if (exist == 0)
                        {
                            isvalid = true;
                            txtScanPart.Enabled = true;
                            this.txtScanPart.Focus();
                            txtScanPart.Select();
                            this.ActiveControl = txtScanPart;
                            txtScanPart.Focus();
                        }
                        else if (exist == 1)
                        {
                            DialogResult resultmsg;
                            resultmsg = MessageBox.Show("VinNumber already exist.\n Do you wish to Update?",
                                "Information",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);

                            if (resultmsg == DialogResult.Yes)
                            {
                            isEdit = true;
                            if (type == "Domestic" && IsTcu == true)
                            {
                                EditDialog dialog = new EditDialog();
                                dialog.ShowDialog();
                                string result = dialog.result;
                                if (result == "TCU")
                                {
                                    txtScanTCU.Enabled = true;
                                    txtScanTCU.Focus();
                                }
                                else if (result == "BATTERY")
                                {
                                    isvalid = true;
                                    txtScanPart.Enabled = true;
                                    this.txtScanPart.Focus();
                                    txtScanPart.Select();
                                    this.ActiveControl = txtScanPart;
                                    txtScanPart.Focus();
                                    IsTcu = false;
                                }

                            }
                            else if (type == "Domestic" && IsTcu == false)
                            {
                                isvalid = true;
                                txtScanPart.Enabled = true;
                                this.txtScanPart.Focus();
                                txtScanPart.Select();
                                this.ActiveControl = txtScanPart;
                                txtScanPart.Focus();
                            }
                            else if (IsTcu == true)
                            {
                                txtScanPart.Enabled = false;
                                txtScanTCU.Enabled = true;
                                txtScanTCU.Focus();
                            }


                        }
                            else
                            {
                                clear();
                            }
                        }
                    }
                    else
                    {

                    if (IsTcu)
                    {
                        DataTable dt = Vinumber_exist();  //***********check in MainLine******
                        exist = dt.Rows.Count;
                        if (exist == 0)
                        {
                            txtScanPart.Enabled = false;
                            txtScanTCU.Enabled = true;
                            txtScanTCU.Focus();
                        }
                        else if (exist == 1)
                        {
                            DialogResult resultmsg;
                            resultmsg = MessageBox.Show("VinNumber already exist.\n Do you wish to Update?",
                                "Information",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);

                            if (resultmsg == DialogResult.Yes)
                            {
                                isEdit = true;
                                if (type == "Domestic" && IsTcu == true)
                                {
                                    EditDialog dialog = new EditDialog();
                                    dialog.ShowDialog();
                                    string result = dialog.result;
                                    if (result == "TCU")
                                    {
                                        txtScanTCU.Enabled = true;
                                        txtScanTCU.Focus();
                                    }
                                    else if (result == "BATTERY")
                                    {
                                        isvalid = true;
                                        txtScanPart.Enabled = true;
                                        this.txtScanPart.Focus();
                                        txtScanPart.Select();
                                        this.ActiveControl = txtScanPart;
                                        txtScanPart.Focus();
                                        IsTcu = false;
                                    }

                                }
                                else if (type == "Domestic" && IsTcu == false)
                                {
                                    isvalid = true;
                                    txtScanPart.Enabled = true;
                                    this.txtScanPart.Focus();
                                    txtScanPart.Select();
                                    this.ActiveControl = txtScanPart;
                                    txtScanPart.Focus();
                                }
                                else if (IsTcu == true)
                                {
                                    txtScanPart.Enabled = false;
                                    txtScanTCU.Enabled = true;
                                    txtScanTCU.Focus();
                                }
                            }
                        }
                    }
                    else
                    {
                        timerExport.Start();
                        rbtnExportNotification.Visible = true;
                        txtScanPart.Enabled = false;
                        clear();
                    }
                    }
                }
                else
                {
                    clear();
                }
            //}
            //else
            //{
            //    MessageBox.Show("Undefined VinNumber", "Error",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Error,
            //    MessageBoxDefaultButton.Button1);
            //    isvalid = false;
            //    clear();
            //    log.Error(lblVinNoValue.Text + " Undefined vinnumber ");
            //}
            return isvalid;
        }
        private void clear()
        {
            txtScanVehicle.Enabled = true;
            txtScanPart.Enabled = false;
            this.txtScanVehicle.Focus();
            rbtnComleted.Visible = false;
            rbtnRework.Visible = false;
            txtScanVehicle.Clear();
            txtScanPart.Clear();
            lblVinNoValue.Text = "";
            lblModelCodeValue.Text = "";
            lblModelDescValue.Text = "";
            lblOrderTypeValue.Text = "";
            lblTypeValue.Text = "";
            lblPartCodeValue.Text = "";
            lblColor.Text = "";
            rbtnStatus.Text = "";
            erpMainLine.Clear();
            rbtnStatus.Visible = false;
            txtScanTCU.Enabled = false;
            txtScanTCU.Text = "";
            IsTcu = false;
            isEdit = false;
            
        }
        private DataTable Vinumber_exist()
        {
            DataTable dt = null;
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
                con.Open();
                SqlCommand cmd;
               // changed logic to validate only based on vinnumber not by assmbly line on 03-Apr-2023
                cmd = new SqlCommand(ApplicationConstants.CheckIsVinNoExistsBattery1, con);
                cmd.Parameters.AddWithValue("@vinnumber", lblVinNoValue.Text);
                /*cmd.Parameters.AddWithValue("@stationNo", ConfigurationManager.AppSettings["StationNo"]);
                cmd.Parameters.AddWithValue("@plant", ConfigurationManager.AppSettings["Plant"]);
                cmd.Parameters.AddWithValue("@assemblyLine", ConfigurationManager.AppSettings["AssemblyLine"]);*/
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
        }
        private void completedTask()
        {
            // partUniqueNo = int.Parse((lblScanPart.Text).ToString());
            string reworkReason = "";
            string completedStatus = "Completed";
            DataTable dt = Vinumber_exist();  //***********check in emission details******
            exist = dt.Rows.Count;
            if (exist == 0)            {
                if (getPartUniqueNo())
                {
                    save(reworkReason, completedStatus);
                }
            }
            else if(exist==1 && type == "Domestic")
            {
                if (getPartUniqueNo())
                {
                    reworkUpdate(reworkReason, completedStatus);
                }
            }
        }
        private void frmMainLine_Load(object sender, EventArgs e)
        {
            if (getEmployeeId())
            {
                getStation();
                lblEmpNameValue.Text = Global.OperatorId;
                rbtnStatus.Visible = false;
                rbtnExportNotification.Visible = false;
                txtScanVehicle.Select();
                this.ActiveControl = txtScanVehicle;
                this.txtScanVehicle.Focus();
                txtScanPart.Enabled = false;
                rbtnComleted.Visible = false;
                rbtnRework.Visible = false;
                lblEmpNameValue.Text = Global.OperatorId;
            }
            else
            {
                login lg = new login();
                this.Hide();
                lg.Show();
            }
        }
        private void txtScanPart_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtScanPart.Enabled = false;
                if (ValidateData())
                {
                    string validation = ConfigurationManager.AppSettings["BatteryValidation"];
                    if (validation == "True" || validation == "true")
                    {
                        if (validateBattery())
                        {
                            if (IsTcu)
                            {
                                txtScanTCU.Enabled = true;
                                txtScanTCU.Focus();
                            }
                            else
                            {
                                completedTask();
                            }
                            // rbtnComleted.Visible = true;
                        }
                    }
                    else
                    {
                        if (IsTcu)
                        {
                            txtScanTCU.Enabled = true;
                            txtScanTCU.Focus();
                        }
                        else
                        {
                            completedTask();
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"Please correct validation errors:\n {erpMainLine.GetError(txtScanVehicle)} \n " +
                       $"{erpMainLine.GetError(txtScanPart)}\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                }
            }
        }

        public bool ValidateTCU()
        {
            bool isvalid = false;
      
            if (string.IsNullOrEmpty(txtScanTCU.Text.Trim()))
            {
                txtScanTCU.Focus();
                erpMainLine.SetError(txtScanTCU, "Please Scan IMEI");
                return false;
            }
            if (txtScanTCU.Text.Contains("@"))
            {
                 TCUbarcode = txtScanTCU.Text.Split('@');
                if(TCUbarcode.Length != 5)
                {
                    MessageBox.Show("Invalid QRCode. Please scan a valid QRCode", "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error,
                       MessageBoxDefaultButton.Button1);
                    isvalid = false;
                    clear();
                    log.Error("Invalid TCU QRCode. Please scan a valid TCU QRCode " + txtScanTCU.Text);
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Invalid QRCode. Please scan a valid QRCode", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                isvalid = false;
                clear();
                log.Error("Invalid TCU QRCode. Please scan a valid TCU QRCode " + txtScanTCU.Text);
            }
            return isvalid;
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
        private void save(string reworkReason, string status)
        {
            if (getStationId())
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
                   // cmd.Parameters.AddWithValue("@vehicleId", vehicleId);
                    cmd.Parameters.AddWithValue("@vehicleCode", vehicleCode);
                    cmd.Parameters.AddWithValue("@orderType", lblOrderTypeValue.Text);
                    cmd.Parameters.AddWithValue("@stationId", stationId);
                    cmd.Parameters.AddWithValue("@stationNumber", ConfigurationManager.AppSettings["StationNo"]);
                    cmd.Parameters.AddWithValue("@assemblyLine", ConfigurationManager.AppSettings["AssemblyLine"]);
                    cmd.Parameters.AddWithValue("@plantId", plantId);
                    cmd.Parameters.AddWithValue("@assignmentId", "");
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
                    if (IsTcu)
                    {
                        cmd.Parameters.AddWithValue("@IMEI", TCUbarcode[4]);
                        cmd.Parameters.AddWithValue("@PartCode", TCUbarcode[0]);
                    }
                    //cmd.Parameters.AddWithValue("@Action", Action);
                    cmd.CommandType = CommandType.StoredProcedure;
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        log.Info(lblVinNoValue.Text + " " + "VinNo Inserted.");
                        //MessageBox.Show("Added");
                        IsInserted = true;
                        Global.reworkReason = "";
                        if (ConfigurationManager.AppSettings["PrintAction"]=="True" || ConfigurationManager.AppSettings["PrintAction"] == "true")
                        {
                            if (!IsTcu)
                            {
                                print_label();
                            }
                            timerStatusResult.Start();
                            rbtnStatus.Visible = true;
                            rbtnStatus.Text = "Completed";
                            log.Info("Status Result Timer started");
                            this.txtScanVehicle.Focus();
                            txtScanPart.Enabled = false;
                        }
                       else
                       {
                            timerStatusResult.Start();
                            rbtnStatus.Visible = true;
                            rbtnStatus.Text = "Completed";
                            log.Info("Status Result Timer started");
                            this.txtScanVehicle.Focus();
                            txtScanPart.Enabled = false;
                       }
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
                        MessageBox.Show(ex.Message, "Error",
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

        private void save_TCU()
        {
           
                log.Info("Inside TCU Save Action in Battery");
                try
                {
                    SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
                    con.Open();
                    SqlCommand cmd;
                    cmd = new SqlCommand("[dbo].[usp_InsertTCU]", con);
                    cmd.Parameters.AddWithValue("@vinNumber", lblVinNoValue.Text);
                    cmd.Parameters.AddWithValue("@PartCode",TCUbarcode[0]);
                    cmd.Parameters.AddWithValue("@VendorCode", TCUbarcode[1]);
                    cmd.Parameters.AddWithValue("@IMEI", TCUbarcode[4]);
                    cmd.Parameters.AddWithValue("@TCUStatus", "Pending");
                    cmd.Parameters.AddWithValue("@MFG_DATE", Getdate(TCUbarcode[2].ToString().Substring(0,5)));
                    cmd.Parameters.AddWithValue("@SerialNo", TCUbarcode[3]);
                    cmd.Parameters.AddWithValue("@StationNo", ConfigurationManager.AppSettings["StationNo"]);
                    cmd.Parameters.AddWithValue("@EmployeeCode", Global.OperatorId);
                    cmd.Parameters.AddWithValue("@ISEdit", isEdit);
                 
                    cmd.CommandType = CommandType.StoredProcedure;
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                    if(type != "Domestic" || isEdit == true)
                    {
                        timerStatusResult.Start();
                        rbtnStatus.Visible = true;
                        rbtnStatus.Text = "Completed";
                        log.Info("Status Result Timer started");
                        this.txtScanVehicle.Focus();
                        txtScanPart.Enabled = false;
                    }
                        log.Info(barcode[4] + " " + "TCU Inserted."); 
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
                        MessageBox.Show(ex.Message, "Error",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error,
                           MessageBoxDefaultButton.Button1);
                        log.Error(lblVinNoValue.Text + " " + "Sql Error  While  Adding Vinumber and in TCU table" + " " + ex.Message);
                        clear();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Error  While  Adding Vinumber in Mainline " + " " + ex.Message, "Error",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error,
                           MessageBoxDefaultButton.Button1);
                    log.Error(lblVinNoValue.Text + " " + "Sql Error  While  Adding Vinumber in Mainline table" + " " + ex.Message);
                    clear();
                }
            
        }
        private bool reworkReason()
        {
            bool isvalid = false;
            DialogResult result = DialogResult.No;
            ReworkReason RR = new ReworkReason();
            result = RR.ShowDialog();
            if (Global.reworkReason == "")
            {
                if (result == DialogResult.No)
                {
                    this.Enabled = true;
                    isvalid = false;
                }

            }
            else
            {
                this.Enabled = false;
                if (result == DialogResult.OK)
                {
                    reworkReasonFormClosed();
                    isvalid = true;
                }
            }
            return isvalid;
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
        private bool getEmployeeId()
        {
            bool isvalid = false;
            bioMetric = ConfigurationManager.AppSettings["BioMetric"];
            if (bioMetric == "False" || bioMetric == "false")
            {
                lblEmpNameValue.Text = Global.OperatorId;
                isvalid = true;
            }
            else
            {
                isvalid = false;
                MessageBox.Show(" BioMetric is Not defined in Configuration.\n Please Contact Administrator  ", "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error,
                       MessageBoxDefaultButton.Button1);
                clear();
            }
            return isvalid;
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
                cmd = new SqlCommand(ApplicationConstants.GetBatteryVehicleDetails, con);
                cmd.Parameters.AddWithValue("@vinnumber", lblVinNoValue.Text);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                int total = dt.Rows.Count;
                if (total == 1)
                {
                    // lblVinNoValue.Text = dt.Rows[0]["VinNumber"].ToString();
                    lblModelCodeValue.Text = dt.Rows[0]["modelCode"].ToString();
                    lblModelDescValue.Text = dt.Rows[0]["ModelDescription"].ToString();
                    //lblPartCodeValue.Text = dt.Rows[0]["VariantCode"].ToString();
                    // lblTypeValue.Text = dt.Rows[0]["VariantName"].ToString();
                    lblOrderTypeValue.Text = dt.Rows[0]["ismyo"].ToString();
                    assemblyLine = dt.Rows[0]["AssemblyLine"].ToString();
                    lblColor.Text = dt.Rows[0]["color"].ToString();
                    vehicleId = int.Parse(dt.Rows[0]["VehicleId"].ToString());
                    plantId = dt.Rows[0]["PlantId"].ToString();
                    //stationId = int.Parse(dt.Rows[0]["StationId"].ToString());
                    //stationNumber = dt.Rows[0]["StationNumber"].ToString();
                    //assignmentId = int.Parse(dt.Rows[0]["Assignment_id"].ToString());
                    //variantId =dt.Rows[0]["VariantCode"].ToString();
                    //variantName = dt.Rows[0]["VariantName"].ToString();
                    //variantImage= dt.Rows[0]["VariantImage"].ToString();
                    regionMappingId = int.Parse(dt.Rows[0]["RegionMappingId"].ToString());
                    IsTcu = Convert.ToBoolean(dt.Rows[0]["TCU"].ToString());
                        if (regionMappingId == 1)
                    {
                        type = "Domestic";
                        lblTypeValue.Text = "Domestic";
                    }
                    else
                    {
                        type = "Export";
                        lblTypeValue.Text = "Export";
                    }
                    isvalid = true;
                }
                else
                {
                    MessageBox.Show("No Vehicle Details.", "Information",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information,
                           MessageBoxDefaultButton.Button1);
                    log.Error("Getting Vehicle Details Failed for vehiclecode " + vehicleCode);
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
                cmd.Parameters.AddWithValue("@plantId", plantId);
                cmd.Parameters.AddWithValue("@stationNo", ConfigurationManager.AppSettings["StationNo"]);
                cmd.Parameters.AddWithValue("@assemblyLine", ConfigurationManager.AppSettings["AssemblyLine"]);
                cmd.Parameters.AddWithValue("@variantId", variantId);
                if (IsTcu)
                {
                    cmd.Parameters.AddWithValue("@IMEI", TCUbarcode[4]);
                    cmd.Parameters.AddWithValue("@PartCode", TCUbarcode[0]);
                }
                //cmd.Parameters.AddWithValue("@Action", Action);
                cmd.CommandType = CommandType.StoredProcedure;
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    log.Info(lblVinNoValue.Text + " " + "VinNo Updated as "+ txtScanPart.Text+ "Battery.");
                    //MessageBox.Show("Added");
                    Global.reworkReason = "";
                    if (ConfigurationManager.AppSettings["PrintAction"] == "True" || ConfigurationManager.AppSettings["PrintAction"] == "true")
                    {
                        if (!IsTcu)
                        {
                            print_label();
                        }
                        timerStatusResult.Start();
                        rbtnStatus.Visible = true;
                        rbtnStatus.Text = "Completed";
                        log.Info("Status Result Timer started");
                        this.txtScanVehicle.Focus();
                        txtScanPart.Enabled = false;
                        IsInserted = true;
                    }
                    else
                    {
                        IsInserted = true;
                        timerStatusResult.Start();
                        rbtnStatus.Visible = true;
                        rbtnStatus.Text = "Completed";
                        log.Info("Status Result Timer started");
                        this.txtScanVehicle.Focus();
                        txtScanPart.Enabled = false;
                    }
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
                    MessageBox.Show(ex.Message, "Error",
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
        private bool getPartUniqueNo()
        {
            bool isvalid = false;
            if(txtScanPart.Text.Length == 0)
            {
                return true;
            }
            try
            {
                log.Info("Initiated to Get Part Unique Number");
                SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
                con.Open();
                SqlCommand cmd;
                cmd = new SqlCommand(ApplicationConstants.GetMlPartUniqueNo, con);
                cmd.Parameters.AddWithValue("@partUniqueNo", txtScanPart.Text);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                int total = dt.Rows.Count;
                if (total == 0)
                {
                    isvalid = true;
                }
                else
                {
                    log.Error(txtScanPart.Text + " Part Already exists");
                    isvalid = false;
                    MessageBox.Show("Part already assigned to another Vehicle\n Please Scan New Battery", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                    clear();
                }
            }
            catch (SqlException ex)
            {
                isvalid = false;
                MessageBox.Show("Sql Error while getting Part Unique Number" + " " + ex.Message, "Information",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information,
                           MessageBoxDefaultButton.Button1);
                log.Error(txtScanPart.Text + " " + "Sql Error while  getting Part Unique Number from DB" + " " + ex.Message);
                clear();
            }

            catch (Exception ex)
            {
                isvalid = false;
                MessageBox.Show("Error while getting Part Unique Number" + " " + ex.Message, "Information",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information,
                           MessageBoxDefaultButton.Button1);
                log.Error(txtScanPart.Text + " " + "Error while  getting Part Unique Number from DB" + " " + ex.Message);
                clear();
            }
            return isvalid;
        }
        private bool validateBattery()
        {
            bool isvalid = false;
            string[] AMARON = ConfigurationManager.AppSettings["AMARON"].Split(',');
            string[] EXIDE = ConfigurationManager.AppSettings["EXIDE"].Split(',');
            int amaronLength = int.Parse(ConfigurationManager.AppSettings["AMARON-BatteryLength"]);
            int amaronCheckCharacter = int.Parse(ConfigurationManager.AppSettings["AMARON-CheckCharacter"]);
            int exideLength = int.Parse(ConfigurationManager.AppSettings["EXIDE-BatteryLength"]);
            int exideCheckCharacter = int.Parse(ConfigurationManager.AppSettings["EXIDE-CheckCharacter"]);
            int totalValue = txtScanPart.Text.Length;
            if (totalValue == amaronLength)
            {
                string amaronResult = txtScanPart.Text.Substring(0, amaronCheckCharacter);
                lblPartCodeValue.Text = "AMARON";
                variantId = "AMARON";
                if (AMARON.Contains(amaronResult))
                {
                    isvalid = true;
                }
                else
                {
                    MessageBox.Show("Characters Mismatched for AMARON Battery", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isvalid = false;
                   
                    this.txtScanVehicle.Focus();
                    txtScanPart.Enabled = false;
                    clear();
                }
            }
            else if (totalValue == exideLength)
            {
                string exideResult = txtScanPart.Text.Substring(0, exideCheckCharacter);
                lblPartCodeValue.Text = "EXIDE";
                variantId = "EXIDE";
                if (EXIDE.Contains(exideResult))
                {
                    isvalid = true;
                }
                else
                {
                    MessageBox.Show("Characters Mismatched for EXIDE Battery", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isvalid = false;
                    this.txtScanVehicle.Focus();
                    txtScanPart.Enabled = false;
                    clear();
                }
            }
            else
            {
                MessageBox.Show("Invalid Battery", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtScanVehicle.Focus();
                txtScanPart.Enabled = false;
                clear();
            }            return isvalid;
        }
        private bool getStationId()
        {
            bool isvalid = false;
            try
            {
                log.Info("Initiated to Get StationId.");
                SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
                con.Open();
                SqlCommand cmd;
                cmd = new SqlCommand(ApplicationConstants.GetStationIDForBattery, con);
                cmd.Parameters.AddWithValue("@stationNo", ConfigurationManager.AppSettings["StationNo"]);
                cmd.Parameters.AddWithValue("@stationType", ConfigurationManager.AppSettings["StationType"]);
                cmd.Parameters.AddWithValue("@assemblyLine", ConfigurationManager.AppSettings["AssemblyLine"]);
                cmd.Parameters.AddWithValue("@plantId", plantId);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                int total = dt.Rows.Count;
                if (total == 1)
                {
                    // lblVinNoValue.Text = dt.Rows[0]["VinNumber"].ToString();
                    stationId = int.Parse(dt.Rows[0]["StationId"].ToString());
                    isvalid = true;
                }
                else
                {
                    MessageBox.Show("StationId is Not available.", "Error",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information,
                           MessageBoxDefaultButton.Button1);
                    log.Error("Getting StationId for Battery failed for  " + ConfigurationManager.AppSettings["StationNo"]);
                    isvalid = false;
                    clear();

                }
            }
            catch (SqlException ex)
            {
                isvalid = false;
                MessageBox.Show("Sql Error while getting StationId for Battery" + " " + ex.Message, "Information",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information,
                           MessageBoxDefaultButton.Button1);
                log.Error(lblVinNoValue.Text + " " + "Sql Error whilegetting StationId for Battery from DB" + " " + ex.Message);
                clear();
            }

            catch (Exception ex)
            {
                isvalid = false;
                MessageBox.Show("Error while getting StationId for Battery" + " " + ex.Message, "Information",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information,
                           MessageBoxDefaultButton.Button1);
                log.Error(lblVinNoValue.Text + " " + "Error while getting StationId for Battery from DB" + " " + ex.Message);
                clear();
            }
            return isvalid;
        }
        private void print_label()
        {
            log.Info("Initiated label print for " + txtScanPart.Text);
            BatteryNo = txtScanPart.Text;
            GetbatteryandTcu();
            if ((!string.IsNullOrEmpty(BatteryNo)) && (BatteryNo != " ") || (!string.IsNullOrEmpty(IMEI)) && (IMEI != " "))
            {
                //string BarCodeSplit1, BarCodeSplit2, BarCodeSplit3;
                string PrinterShareName = ConfigurationManager.AppSettings["PrinterShareName"];
                string PrinterName = ConfigurationManager.AppSettings["PrinterName"];
                string Generationpath = ConfigurationManager.AppSettings["Generationpath"];
                string TemplatePath = ConfigurationManager.AppSettings["TemplatePath"];
                var pd = new PrintDocument();
                //int batteryLength = BatteryNo.Length;
                //int batteryLastSplit = batteryLength - 12;
                //BarCodeSplit1 = BatteryNo.Substring(0, 4);
                //BarCodeSplit2 = BatteryNo.Substring(4, 8);
                //BarCodeSplit3 = BatteryNo.Substring(12, batteryLastSplit);
                string date = DateTime.Now.ToString("dd/MMM/yyyy");
                string time = DateTime.Now.ToString("h.mm");
                string destination = string.Format("{0}\\{1}.prn", Generationpath, BatteryNo);
                string text = File.ReadAllText(TemplatePath + "\\Template.prn");
                if (IMEI.Length > 0 && type != "Domestic")
                {
                    text = text.Replace("@Imei", IMEI);
                    text = text.Replace("BarCodeSplit", IMEI);
                }
                else if (IMEI.Length>0)
                {
                   text = text.Replace("@Imei", IMEI);
                    text = text.Replace("BarCodeSplit", BatteryNo + "@" + IMEI);
                    
                }
                else
                {
                    text = text.Replace("@Imei", "");
                    text = text.Replace("BarCodeSplit", BatteryNo);
                }
                text = text.Replace("BatteryNo", BatteryNo);
                text = text.Replace("Date", date);
                text = text.Replace("Time", time);
                
                //text = text.Replace("BarCodeSplit1", BarCodeSplit1);
                //text = text.Replace("BarCodeSplit2", BarCodeSplit2);
                //text = text.Replace("BarCodeSplit3", BarCodeSplit3);
                File.WriteAllText(destination, text);
                Process proc = null;
                try
                {
                    string path = @"COPY " + Generationpath + "\\" + BatteryNo + ".prn /b \\\\" + PrinterName + "\\" + PrinterShareName;
                    proc = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe", "/c" + path);
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized;
                    startInfo.UseShellExecute = false;
                    startInfo.CreateNoWindow = true;
                    startInfo.RedirectStandardError = true;
                    startInfo.RedirectStandardOutput = true;
                    proc.StartInfo = startInfo;
                    proc.Start();
                    proc.WaitForExit();
                    proc.Close();
                   // clear();
                    //rbtnMexa.Enabled = true;    
                }
                catch (Exception ex)
                {
                    timerStatusResult.Start();
                    rbtnStatus.Visible = true;
                    rbtnStatus.Text = "Validation Passed\n Print Failed";
                    log.Info("Validation Passed Print Failed");
                    // status_Result("Validation Passed\n Print Failed");
                    log.Error(ex.Message.ToString());
                    MessageBox.Show("Error in Printer Connection", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button1);
                    clear();
                    //rbtnMexa.Enabled = true;
                }
            }
            else
            {
                log.Info(BatteryNo + " No Data to Print in Battery Report");
                clear();
            }
            BatteryNo = "";
        }
        public string Getdate(string date)
        {

            string sourceDate = date;// Date in the source format (DDMYY)

            string partBefore = sourceDate.Substring(0, 2);
            string partAfter = sourceDate.Substring(3);
            string mon = "";

            Month selectedMonth = (Month)Enum.Parse(typeof(Month), sourceDate[2].ToString());


            int monthValue = (int)selectedMonth;
            if (monthValue <= 9)
            {
                mon = "0" + monthValue.ToString();
            }
            else
            {
                mon = monthValue.ToString();
            }
            string modifiedString = partBefore + mon + partAfter;

            DateTime parsedDate = DateTime.ParseExact(modifiedString, "ddMMyy", CultureInfo.InvariantCulture);
            string defaultDateFormat = parsedDate.ToString();
            Console.WriteLine("Default Date Format: " + defaultDateFormat);
            return parsedDate.ToString();
        }


        public void GetbatteryandTcu()
        {
            try
            {
                BatteryNo = "";
                IMEI = "";
                SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
                con.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("dwi.usp_GetBatteryandTCU", con);
                cmd.Parameters.AddWithValue("@VinNo", vinnumber);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr  = cmd.ExecuteReader();

                if(dr.Read())
                {
                    BatteryNo = dr.GetValue(0).ToString();
                    IMEI = dr.GetValue(1).ToString();
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

