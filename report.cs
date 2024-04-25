using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ClosedXML.Excel;
//using Microsoft.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System.Text.RegularExpressions;
using System.Drawing.Printing;
using System.Diagnostics;

namespace DWI
{
    public partial class report : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static string CurrTime = "";
        string engineNo,vinNo,Shift,plantId,assemblyLine,stnNo, BatteryNo;
        List<string> lisShiftFromTime = new List<string>();
        List<string> lisShiftToTime = new List<string>();
        private object interval;
        private bool fromDateChanged;
        private bool toDateChanged;
        public report()
        {
            string var_dte;
            var_dte = System.DateTime.Today.ToString("MM/dd/yyyy");
            InitializeComponent();
           chkListShift.Items.Add("Select All");
            //BindShiftDetails();
            //BindGrid(string.Empty,DateTime.Now.ToString("M/d/yyyy"), DateTime.Now.ToString("M/d/yyyy"),string.Empty,Shift,string.Empty,string.Empty,string.Empty);
            //loadRegionDropDown();
        }
        private void report_Load(object sender, EventArgs e)
        {
            frmDate.Value = DateTime.Now;
            toDate.Value = DateTime.Now;
           chkListShift.Items.Add("Select All");
            VINSmartSearch();
            partNosmart_Search();
            BindShiftDetails();
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["Station"].ToString()) && (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["Plant"].ToString())) && (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["StationType"].ToString())) && (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["StationNo"].ToString())) && (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["AssemblyLine"].ToString())))
            {
                txtPlant.Text = ConfigurationManager.AppSettings["Plant"].ToString();
                txtAssemblyLine.Text = ConfigurationManager.AppSettings["AssemblyLine"].ToString();
                txtStationNo.Text = ConfigurationManager.AppSettings["StationNo"].ToString();
                txtStationName.Text = ConfigurationManager.AppSettings["Station"].ToString();
            }
            BindGrid();
        }
        private void partNosmart_Search()
        {
            SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
            con.Open();
            SqlCommand cmd;
            cmd = new SqlCommand("SELECT Partuniqueno FROM dwi.wi_MainLine", con);
            SqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection MyCollectionPartNo = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollectionPartNo.Add(reader.GetString(0));
            }
            txtPartNo.AutoCompleteCustomSource = MyCollectionPartNo;
            con.Close();
        }
        private void stationNoSmartSearch()
        {
            SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
            con.Open();
            SqlCommand cmd;
            cmd = new SqlCommand("SELECT StationNumber FROM dwi.wi_MainLine", con);
            SqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection MyCollectionStnNo = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollectionStnNo.Add(reader.GetString(0));
            }
            txtStationNo.AutoCompleteCustomSource = MyCollectionStnNo;
            con.Close();
        }
        private void VINSmartSearch()
        {
            SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
            con.Open();
            SqlCommand cmd;
            plantId = ConfigurationManager.AppSettings["PlantId"].ToString();
            assemblyLine = ConfigurationManager.AppSettings["AssemblyLine"].ToString();
            stnNo = ConfigurationManager.AppSettings["StationNo"].ToString();
            cmd = new SqlCommand("SELECT VinNumber FROM dwi.wi_MainLine", con);
            SqlDataReader reader = cmd.ExecuteReader();
            cmd.CommandTimeout = 0;
            AutoCompleteStringCollection MyCollectionVin = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollectionVin.Add(reader.GetString(0));
            }
            txtVn.AutoCompleteCustomSource = MyCollectionVin;
            con.Close();
        }

        private void stationNameSmartSearch()
        {
            SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
            con.Open();
            SqlCommand cmd;
            cmd = new SqlCommand("SELECT Name FROM dwi.wi_Station", con);
            SqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection MyCollectionStationName = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollectionStationName.Add(reader.GetString(0));
            }
            txtStationName.AutoCompleteCustomSource = MyCollectionStationName;
            con.Close();
        }
        private void dateTimePicker1_DropDown(object sender, EventArgs e)
        {
            frmDate.Format = DateTimePickerFormat.Short;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private bool validateData()
        {
            bool Isvalid = true;
            if (string.IsNullOrEmpty(chkListShift.Text) && string.IsNullOrEmpty(txtVn.Text) &&
                string.IsNullOrEmpty(txtEmpId.Text) &&
                string.IsNullOrEmpty(txtStationNo.Text) && string.IsNullOrEmpty(txtPartNo.Text)
                && (frmDate.Text == null || frmDate.Text == " ") && (toDate.Text == null
                || toDate.Text == " ")
                )
            {
                erpReport.SetError(rbtnView, "Please select a field");
                Isvalid = false;
            }
            return Isvalid;
        }

        private void rbtnView_Click(object sender, EventArgs e)
        {
            log.Info("View button clicked by " + Global.OperatorId);
            this.rbtnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(216)))), ((int)(((byte)(94)))));
            this.rbtnView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(216)))), ((int)(((byte)(94)))));
            this.rbtnView.ForeColor = Color.Black;
            
            if (validateData())
            {
                erpReport.Clear();
                BindGrid();
            }
            else
            {
                MessageBox.Show($"Please correct validation errors:\n {erpReport.GetError(rbtnView)}",
             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      /*  private void rbtnExport_Click(object sender, EventArgs e)
        {
            log.Info("Export button clicked by " + Global.OperatorId);
            this.rbtnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(216)))), ((int)(((byte)(94)))));
            this.rbtnExport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(216)))), ((int)(((byte)(94)))));
            this.rbtnExport.ForeColor = Color.Black;
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.DisplayIndex != dataGridView1.Columns.Count - 1)
                {
                    dt.Columns.Add(column.HeaderText, column.ValueType);
                }
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex >= 0 )
                    {
                        dt.Rows[dt.Rows.Count-1 ][cell.ColumnIndex] = cell.Value.ToString();
                       // dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex - 1] = cell.Value.ToString();
                    }
                }
            }

            string folderPath = ConfigurationManager.AppSettings["ExcelPath"];
            string fileName = "COReport" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".xlsx";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, "COReport");

                wb.SaveAs(folderPath + fileName);
                wb.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                wb.Style.Font.Bold = true;
            }

            System.Diagnostics.Process.Start(folderPath + fileName);
        }*/
        private void dateTimePicker2_DropDown(object sender, EventArgs e)
        {
            toDate.Format = DateTimePickerFormat.Short;
            //dateTimePicker2.Value = DateTime.Today;
        }

        /* private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             if (e.ColumnIndex == 0)
             {
                 string EngineNumber = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                 log.Info(EngineNumber+" label Reprint initiated" );
                     string PrinterShareName = ConfigurationManager.AppSettings["PrinterShareName"];
                     string PrinterName = ConfigurationManager.AppSettings["PrinterName"];
                     string Generationpath = ConfigurationManager.AppSettings["Generationpath"];
                     string TemplatePath = ConfigurationManager.AppSettings["TemplatePath"];
                     var pd = new PrintDocument();
                    // string EngineNumber = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                     string dateAndTime = DateTime.Now.ToString("dd/MMM/yyyy");
                     string destination = string.Format("{0}\\{1}.prn", Generationpath, EngineNumber);
                     string text = File.ReadAllText(TemplatePath + "\\Template.prn");
                     text = text.Replace("EngineNo", EngineNumber);
                     text = text.Replace("DateTime", dateAndTime);
                     text = text.Replace("Lambda", dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                     text = text.Replace("COValue", dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                     text = text.Replace("HCValue", dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                     File.WriteAllText(destination, text);
                     Process proc = null;

                     try
                     {
                         string path = @"COPY " + Generationpath + "\\" + EngineNumber + ".prn /b \\\\" + PrinterName + "\\" + PrinterShareName;
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
                         clear();
                     }
                     catch (Exception ex)
                     {
                         log.Error(ex.Message.ToString());
                         MessageBox.Show("Error in Printer Connection", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error,
                                         MessageBoxDefaultButton.Button1);
                         clear();
                     }
             }
             }
        }*/



    private void lblShift_Click_1(object sender, EventArgs e)
        {

        }

        
                private void btnClear_Click(object sender, EventArgs e)
                {
            
                }
                private void clear()
                {
                    chkListShift.Items.Add("Select All");
                  this.rbtnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
                    this.rbtnView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
                    this.rbtnView.ForeColor = Color.White;
                   // this.rbtnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
                   //this.rbtnExport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
                    //this.rbtnExport.ForeColor = Color.White;
                    txtVn.Clear();
                   // txtEng.Clear();
                    txtEmpId.Clear();
                    //txtStationNo.Text = "";
                    txtPartNo.Text = "";
                   // txtStationName.Text = "";
                    this.frmDate.Value = DateTime.Now;
                    this.toDate.Value = DateTime.Now;
                    erpReport.Clear();
                     BindShiftDetails();
                     chkListShift.Text = "";
                     uncheck();
                     
                    
                }
        private void uncheck()
        {
           for (int i = 0; i < chkListShift.Items.Count; i++)
            {
               chkListShift.CheckBoxItems[i].Checked = false;
            }
        }
        private void BindShiftDetails()
         {
            lisShiftFromTime.Clear();
             lisShiftToTime.Clear();
            chkListShift.Items.Clear();
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
                 // cmdSettings = new SqlCommand("usp_GetShiftDetails", conSettings);
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
                    chkListShift.Items.Add(dsRole.Tables[0].Rows[i]["ShiftName"].ToString());
                    int a = chkListShift.Items.Count;
                 }
                 conSettings.Close();
                 TimeSpan today = DateTime.Parse(System.DateTime.Now.ToString("HH:mm")).TimeOfDay;
                int b = chkListShift.Items.Count;
                chkListShift.Items.Add("Select All").ToString();
                int c = chkListShift.Items.Count;
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
                            chkListShift.CheckBoxItems[index].Checked = true;
                            Shift = chkListShift.CheckBoxItems[index].Text;
                         }
                     }
                     else if (fromtime > testTime && totime < testTime && today < testTime)
                     {
                         if ((today <= fromtime) && (today <= totime))
                         {
                          chkListShift.CheckBoxItems[index].Checked = true;
                           Shift = chkListShift.CheckBoxItems[index].Text;
                        }
                     }
                     else
                     {
                         if ((today >= fromtime) && (today <= totime))
                         {
                            int k = chkListShift.Items.Count;
                            chkListShift.CheckBoxItems[index].Checked = true;
                            Shift = chkListShift.CheckBoxItems[index].Text;

                        }
                     }
                 }
             }
             catch (SqlException ex)
             {
                 MessageBox.Show(ex.Message);
                 log.Error(ex.Message);
                 clear();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
                 log.Error(ex.Message);
                 clear();
             }
         }
       
        private void BindGrid()
        {
            try
            {
                chkListShift.Items.Add("Select All");
                Shift = chkListShift.Text.ToString().Replace(" ", "");
                if (Shift == "SelectAll")
                {
                    Shift = "";
                }
                int a = int.Parse(ConfigurationManager.AppSettings["PlantId"]);
                SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
                     con.Open();
                     SqlCommand cmd;
                     cmd = new SqlCommand(ApplicationConstants.Report, con);
                     cmd.Parameters.AddWithValue("@vinnumber", txtVn.Text);
                    // cmd.Parameters.AddWithValue("@enginenumber", engine);
                     cmd.Parameters.AddWithValue("@fromDate", frmDate.Value);
                     cmd.Parameters.AddWithValue("@toDate", toDate.Value);
                     cmd.Parameters.AddWithValue("@employeeid", txtEmpId.Text);
                    cmd.Parameters.AddWithValue("@shift", Shift);// Shift); 
                    cmd.Parameters.AddWithValue("@stationno", txtStationNo.Text);
                    cmd.Parameters.AddWithValue("@partno", txtPartNo.Text);
                    cmd.Parameters.AddWithValue("@stationname", txtStationName.Text);
                    cmd.Parameters.AddWithValue("@plant", ConfigurationManager.AppSettings["PlantId"]);
                    cmd.Parameters.AddWithValue("@assemblyline", txtAssemblyLine.Text);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    int total = dt.Rows.Count;
                    dgvReport.DataSource = dt;
                    chkListShift.SelectedText = "";
                    if (ConfigurationManager.AppSettings["PrintAction"] == "True" || ConfigurationManager.AppSettings["PrintAction"] == "true")
                    {
                        dynamicButton();
                    }
                    this.rbtnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
                    this.rbtnView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
                    this.rbtnView.ForeColor = Color.White;
                clear();
                con.Close();
            }
            catch (SqlException ex)
            {
                    MessageBox.Show("Sql Error in Report Bind grid" + " " + ex.Message, "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                log.Error(" " + "Sql Error in Report Bind grid" + " " + ex.Message);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Report Bind grid" + " " + ex.Message, "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                log.Error(" " + "Error in Report Bind grid" + " " + ex.Message);
                clear();
            }
        }
        private void txtVn_TextChanged(object sender, EventArgs e)
        {
            
            //VINSmartSearch();
        }

        private void txtEmpId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void chkListShift_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmDate_ValueChanged(object sender, EventArgs e)
        {
            fromDateChanged = true;
        }

        private void toDate_ValueChanged(object sender, EventArgs e)
        {
            toDateChanged = true;
        }

        private void rbtnExport_Click(object sender, EventArgs e)
        {
            log.Info("Export button clicked by " + Global.OperatorId);
            this.rbtnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(216)))), ((int)(((byte)(94)))));
            this.rbtnExport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(216)))), ((int)(((byte)(94)))));
            this.rbtnExport.ForeColor = Color.Black;
            DataTable dt = new DataTable();
            string Reprint = ConfigurationManager.AppSettings["PrintAction"].ToString();
            if (string.Compare(Reprint.ToLower(), "false") == 0)
            {
                foreach (DataGridViewColumn column in dgvReport.Columns)
                {
                    if (column.DisplayIndex != dgvReport.Columns.Count)
                    {
                        dt.Columns.Add(column.HeaderText, column.ValueType);
                    }
                }

                foreach (DataGridViewRow row in dgvReport.Rows)
                {
                    dt.Rows.Add();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex >= 0)
                        {
                            dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                        }
                    }
                }
            }
            else
            {
                foreach (DataGridViewColumn column in dgvReport.Columns)
                {
                    if (column.DisplayIndex != dgvReport.Columns.Count-1)
                    {
                        dt.Columns.Add(column.HeaderText, column.ValueType);
                    }
                }

                foreach (DataGridViewRow row in dgvReport.Rows)
                {
                    dt.Rows.Add();
                    
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex >= 1)//&& (cell.ColumnIndex < dgvReport.Columns.Count - 1))
                        {
                            dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex-1] = cell.Value.ToString();

                            // dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                        }
                    }
                }
            }
            
            

            string folderPath = ConfigurationManager.AppSettings["ExcelPath"];
            string fileName = "MIYBatteryReport" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".xlsx";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, "MIYBatteryReport");

                wb.SaveAs(folderPath + fileName);
                wb.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                wb.Style.Font.Bold = true;
            }

            System.Diagnostics.Process.Start(folderPath + fileName);
            this.rbtnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnExport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnExport.ForeColor = Color.White;
        }

        private void chkListShift_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void txtStationName_TextChanged(object sender, EventArgs e)
        {
            //stationNameSmartSearch();
        }

        private void chkListShift_CheckBoxCheckedChanged(object sender, EventArgs e)
        {
           // int items = chkListShift.Items.Count;
            int lastItem = chkListShift.Items.Count-1;
            if (chkListShift.CheckBoxItems[lastItem].Checked == true)
            {
                for (int i = 0; i < chkListShift.Items.Count; i++) // loop to set all items checked or unchecked
                {
                    chkListShift.CheckBoxItems[i].Checked = true;
                }
                // string A = string.Join(",", lisSelectedItems);
                //chkListAssemblyLine.Text=A;
            }
            chkListShift.CheckBoxItems[lastItem].Checked = false;
        }

        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 0) && (e.RowIndex > -1))
            {
                int ClumnIndex = dgvReport.Columns["Battery No"].Index;
                int ClumnIndex1 = dgvReport.Columns["IMEI No."].Index;
                log.Info("Initiated label print for " + dgvReport.Rows[e.RowIndex].Cells[5].Value.ToString());
                BatteryNo = dgvReport.Rows[e.RowIndex].Cells[ClumnIndex].Value.ToString();
                string IMEI = dgvReport.Rows[e.RowIndex].Cells[ClumnIndex1].Value.ToString();
                if ((!string.IsNullOrEmpty(BatteryNo)) && (BatteryNo != " ") || (!string.IsNullOrEmpty(IMEI)) && (IMEI != ""))
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
                    if(BatteryNo.Length>0 && IMEI.Length>0)
                    {
                        text = text.Replace("BarCodeSplit", BatteryNo + "@" + IMEI);
                    }
                    else if(BatteryNo.Length>0)
                    {
                        text = text.Replace("BarCodeSplit", BatteryNo);
                    }
                    else
                    {
                        text = text.Replace("BarCodeSplit", IMEI);
                    }
                    text = text.Replace("BatteryNo", BatteryNo);
                    text = text.Replace("Date", date);
                    text = text.Replace("Time", time);
                    text = text.Replace("@Imei", IMEI);
                    //text = text.Replace("BarCodeSplit1", BarCodeSplit1);
                    //text = text.Replace("BarCodeSplit2", BarCodeSplit2);
                    //text = text.Replace("BarCodeSplit3", BarCodeSplit3);
                    //text = text.Replace("BarCodeSplit", BatteryNo);
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
                         clear();
                        //rbtnMexa.Enabled = true;    
                    }
                    catch (Exception ex)
                    {
                        log.Error(ex.Message.ToString());
                        MessageBox.Show("Error in Printer Connection", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error,
                                        MessageBoxDefaultButton.Button1);
                        clear();
                        //rbtnMexa.Enabled = true;
                    }
                }
                else
                {
                    log.Info(dgvReport.Rows[e.RowIndex].Cells[7].Value.ToString() + " No Data to Print in Battery Report");
                    clear();
                }
                BatteryNo = "";
            }
        }

        private void chkListShift_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-z\b\,^A-Z]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtPartNo_TextChanged(object sender, EventArgs e)
        {
            //partNosmart_Search();
        }

        private void txtStationNo_TextChanged(object sender, EventArgs e)
        {
            //stationNoSmartSearch();
        }

        private void txtPlant_TextChanged(object sender, EventArgs e)
        {

        }

        /*  private void getdate()
 {
     if ( txtVn.Text != "" || txtEng.Text != "" || txtEmpId.Text!="" || chkListShift.Text!="" || cmbRegion.SelectedIndex >0 || cmbCountry.SelectedIndex>0)
     {
         frmDate.Format = DateTimePickerFormat.Custom;
         frmDate.CustomFormat = " ";
         toDate.Format = DateTimePickerFormat.Custom;
         toDate.CustomFormat = " ";
     }
     else
     {

     }
 }*/

        private void txtEng_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dynamicButton()
        {
            log.Info("Initializing to Generate Dynamic Reprint Button");
            DataGridViewButtonColumn printButtonColumn = new DataGridViewButtonColumn();
            printButtonColumn.Name = "btnReprint";
            printButtonColumn.HeaderText = "Reprint";
            printButtonColumn.UseColumnTextForButtonValue = true;
            printButtonColumn.Text = "Reprint";
            printButtonColumn.DefaultCellStyle.BackColor = Color.FromArgb(131, 216, 94);
            printButtonColumn.FlatStyle = FlatStyle.Flat;
            int column = 12;
            if (dgvReport.Columns["btnReprint"] == null)
            {
                dgvReport.Columns.Insert(column, printButtonColumn);
            }
            log.Info("Dynamic Reprint Button Generated in Report");
        }
    }
}

