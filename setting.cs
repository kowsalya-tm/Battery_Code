using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DWI
{
    public partial class frmSetting : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static string CsvPath;

        public frmSetting()
        {
            InitializeComponent();
            //loadPlantDropDown();
            // loadAssemblylineDropDown();
            //loadStationType();
            //cmbAssemblyLine.Enabled = false;
            //cmbStation.Enabled = false;
            //config_text();
        }
        private void frmSetting_Load(object sender, EventArgs e)
        {
            cmbPlant.Enabled = true;
            loadPlantDropDown();
            cmbAssemblyLine.Enabled = false;
            cmbStationType.Enabled = false;
            cmbStation.Enabled = false;
            config_text();
        }
        private void clear()
        {
            //cmbPlant.Text = "";
            //cmbAssemblyLine.Text = "";
            //cmbStation.Text = "";
            //cmbStationType.Text = "";
        }

        private void loadPlantDropDown()
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
                DataSet ds = new DataSet();
                con.Open();

                SqlCommand cmdPlant = new SqlCommand(ApplicationConstants.GET_PLANT_NAME, con);
                cmdPlant.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmdPlant;
                da.Fill(ds);
                cmbPlant.DisplayMember = "LocationName";
                cmbPlant.ValueMember = "LocationId";
                cmbPlant.DataSource = ds.Tables[0];
                cmbPlant.SelectedIndex = -1;
                
                con.Close();
                log.Info("Plant Dropdown loaded");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Error while Loading Plant drop down" + " " + ex.Message, "Information",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1);
                log.Error(" " + "Sql Error while Loading Plant drop down" + " " + ex.Message);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Loading Plant drop down" + " " + ex.Message, "Information",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1);
                log.Error(" " + "Error while Loading Plant drop down" + " " + ex.Message);
                
            }
        }
        private void loadAssemblylineDropDown()
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
                DataSet ds = new DataSet();
                con.Open();

                SqlCommand cmdAssemblyline = new SqlCommand(ApplicationConstants.GET_AssemblyLine, con);
                cmdAssemblyline.Parameters.AddWithValue("@Plant", cmbPlant.Text);
                cmdAssemblyline.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmdAssemblyline;
                da.Fill(ds);
                cmbAssemblyLine.DisplayMember = "AssemblyLine";
                cmbAssemblyLine.ValueMember = "AssemblyLineId";
                cmbAssemblyLine.DataSource = ds.Tables[0];
                //cmbAssemblyLine.SelectedIndex = -1;
                con.Close();
                
                log.Info("AssemblyLine Dropdown loaded");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Error while Loading AssemblyLine drop down" + " " + ex.Message, "Information",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1);
                log.Error(" " + "Sql Error while Loading AssemblyLine drop down" + " " + ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Loading AssemblyLine drop down" + " " + ex.Message, "Information",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1);
                log.Error(" " + "Error while Loading AssemblyLine drop down" + " " + ex.Message);

            }
        }
        private void loadStationType()
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
                DataSet ds = new DataSet();
                con.Open();

                SqlCommand cmdStationType = new SqlCommand(ApplicationConstants.Get_LookUpValues, con);
                cmdStationType.Parameters.AddWithValue("@LookUpTypeCode", "WI_STATION_TYPE");
                cmdStationType.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmdStationType;
                da.Fill(ds);
                System.Data.DataTable dt = ds.Tables[0];
                DataRow row1 = dt.NewRow();
                
                row1[0] = "Please select";
                row1[1] = 0;
                dt.Rows.InsertAt(row1, 0);
                cmbStationType.DisplayMember = "LookupCode";
                cmbStationType.ValueMember = "LookupCode";
                cmbStationType.DataSource = dt;
                cmbStationType.SelectedIndex = -1;
                //loadStation();
                con.Close();
                log.Info("StationType Dropdown loaded");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Error while Loading StationType drop down" + " " + ex.Message, "Information",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1);
                log.Error(" " + "Sql Error while Loading StationType drop down" + " " + ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Loading StationType drop down" + " " + ex.Message, "Information",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1);
                log.Error(" " + "Error while Loading StationType drop down" + " " + ex.Message);

            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void lblCsvPath_Click(object sender, EventArgs e)
        {

        }
        private void config_text()
        {
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["Station"].ToString())||(!string.IsNullOrEmpty(ConfigurationManager.AppSettings["Plant"].ToString())))
            {
                                          
                cmbPlant.Text = ConfigurationManager.AppSettings["Plant"];
                cmbAssemblyLine.Text = ConfigurationManager.AppSettings["AssemblyLine"].ToString();
                            
                cmbStationType.Text = ConfigurationManager.AppSettings["StationType"].ToString();
                 
                cmbStation.Text = ConfigurationManager.AppSettings["Station"];
             

            }
            else
            {
                cmbAssemblyLine.Enabled = false;
                cmbStation.Enabled = false;
            }

        }
        private void saveConfig()
        {
           var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            
            config.AppSettings.Settings["Plant"].Value = cmbPlant.Text.Trim();
            config.AppSettings.Settings["AssemblyLine"].Value = cmbAssemblyLine.Text.Trim();
            config.AppSettings.Settings["StationType"].Value = cmbStationType.Text.Trim();
            config.AppSettings.Settings["StationNo"].Value = cmbStation.SelectedValue.ToString();
            config.AppSettings.Settings["Station"].Value = cmbStation.Text.Trim();
            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
            MessageBox.Show("Updated Successfully", "Information",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information,
                               MessageBoxDefaultButton.Button1);
            cmbPlant.Enabled = true;
            cmbAssemblyLine.Enabled = false;
            cmbStationType.Enabled = false;
            cmbStation.Enabled = false;
            clear();

        }
        private void rbtnUpdate_Click(object sender, EventArgs e)
        {
            log.Info("Settings update button clicked" );
            this.rbtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(216)))), ((int)(((byte)(94)))));
            this.rbtnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(216)))), ((int)(((byte)(94)))));
            this.rbtnUpdate.ForeColor = Color.Black;
            if (ValidateData())
            {
                erpSetting.Clear();
                DialogResult resultmsg;
                resultmsg = MessageBox.Show(" Do you want to continue?",
                    "Information",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (resultmsg == DialogResult.Yes)
                {
                    try
                    {
                        saveConfig();
                        config_text();
                        this.rbtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
                        this.rbtnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
                        this.rbtnUpdate.ForeColor = Color.White;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while updating Config data" + " " + ex.Message, "Information",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information,
                               MessageBoxDefaultButton.Button1);
                        log.Error("Error while updating Config data" + " " + ex.Message);
                        clear();
                    }
                }
                else if (resultmsg == DialogResult.No)
                {
                    clear();
                }
            }
            else
            {
                MessageBox.Show($"Please correct validation errors:\n {erpSetting.GetError(cmbPlant)} \n " +
                    $"{erpSetting.GetError(cmbAssemblyLine)}\n"+ $"{erpSetting.GetError(cmbStationType)}\n" + $"{erpSetting.GetError(cmbStation)}\n" ,
             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
        private bool ValidateData()
        {
            
            erpSetting.Clear();
            bool Isvalid = true;

            if (string.IsNullOrEmpty(cmbPlant.Text.Trim()))
            {
                cmbPlant.Focus();
                erpSetting.SetError(cmbPlant, "Please Select Plant");
                Isvalid = false;
            }

            if (string.IsNullOrEmpty(cmbAssemblyLine.Text.Trim()))
            {
                cmbAssemblyLine.Focus();
                erpSetting.SetError(cmbAssemblyLine, "Please Select AssemblyLine");
                Isvalid = false;
            }
            if (string.IsNullOrEmpty(cmbStationType.Text.Trim()))
            {
                cmbStationType.Focus();
                erpSetting.SetError(cmbStationType, "Please Select StationType");
                Isvalid = false;
            }
            if (string.IsNullOrEmpty(cmbStation.Text.Trim())||(cmbStation.SelectedIndex==0))
            {
                cmbStation.Focus();
                erpSetting.SetError(cmbStation, "Please Select Station");
                Isvalid = false;
            }
            return Isvalid;
        
        }

       

        private void cmbPlant_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbPlant.SelectedIndex > -1)
            {
                getPlantId();
                cmbAssemblyLine.Enabled = true;
                loadAssemblylineDropDown();
                cmbAssemblyLine.SelectedIndex = 0;
                cmbAssemblyLine.Enabled = true;
                cmbAssemblyLine.SelectedIndex = -1;
            }
        }
        private void loadStation()
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
                DataSet ds = new DataSet();
                con.Open();
                SqlCommand cmdStation = new SqlCommand(ApplicationConstants.Get_Station, con);
                cmdStation.Parameters.AddWithValue("@LookupCode", cmbStationType.Text);
                cmdStation.Parameters.AddWithValue("@assemblyLineId", ConfigurationManager.AppSettings["AssemblyLineId"]);
                cmdStation.Parameters.AddWithValue("@plantId", ConfigurationManager.AppSettings["PlantId"]);
                cmdStation.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmdStation;
                da.Fill(ds);
                System.Data.DataTable dt = ds.Tables[0];
                DataRow row = dt.NewRow();
                row[0] = 0;
                row[1] = "Please select";
                dt.Rows.InsertAt(row, 0);
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["StationId"].Value = ds.Tables[0].Rows[0]["StationId"].ToString().Trim();
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                // Global.stationId = ds.Tables[0].Rows[0]["StationId"].ToString();.
                cmbStation.DisplayMember = "Name";
                cmbStation.ValueMember = "StationNumber";
                cmbStation.DataSource = ds.Tables[0];
                cmbStation.SelectedIndex = -1;
                con.Close();
                log.Info("Station Dropdown loaded");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Error while Loading Station drop down" + " " + ex.Message, "Information",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1);
                log.Error(" " + "Sql Error while Loading Station drop down" + " " + ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Loading Station drop down" + " " + ex.Message, "Information",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1);
                log.Error(" " + "Error while Loading Station drop down" + " " + ex.Message);

            }
        }

        private void cmbStation_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbStationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStationType.SelectedIndex > 0)
            {
               // cmbStation.Enabled = true;
                loadStation();
                cmbStation.SelectedIndex = 0;
                cmbStation.Enabled = true;
            }
            if (cmbStationType.SelectedIndex == 0)
            {
                //cmbStation.SelectedIndex = 1;
                cmbStation.Enabled = false;
            }
        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Location = new Point(
              this.ClientSize.Width / 2 - panel1.Size.Width / 2,
              this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
        }
        private void getPlantId()
        {
            SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
            con.Open();
            SqlCommand cmdLocationValue;
            string plant = cmbPlant.Text;
            cmdLocationValue = new SqlCommand("Select LocationValue,LocationId from location where LocationName='" + plant + "'", con);
            SqlDataReader readerPlantId = cmdLocationValue.ExecuteReader();
            if (readerPlantId.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(readerPlantId);
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["PlantId"].Value = dt.Rows[0]["LocationId"].ToString().Trim();
                config.AppSettings.Settings["LocationValue"].Value = dt.Rows[0]["LocationValue"].ToString().Trim();
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

               // Global.LocationValue = dt.Rows[0]["LocationValue"].ToString();
                //Global.plantId = int.Parse(dt.Rows[0]["LocationId"].ToString());
            }
            con.Close();
        }
        private void getAssemblyLineId()
        {
            SqlConnection con = new SqlConnection(ConnectionString.GetConnectionString());
            con.Open();
            SqlCommand cmdAssemblyLineId;
            string assemblyLine = cmbAssemblyLine.Text;
            cmdAssemblyLineId = new SqlCommand("Select AssemblyLineId from AssemblyLine where AssemblyLine='" + assemblyLine + "'and PlantId='" + ConfigurationManager.AppSettings["PlantId"].ToString() + "'", con);
            SqlDataReader readerAssemblyLineId = cmdAssemblyLineId.ExecuteReader();
            if (readerAssemblyLineId.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(readerAssemblyLineId);
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["AssemblyLineId"].Value = dt.Rows[0]["AssemblyLineId"].ToString().Trim();
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                cmbStationType.Enabled = true;
               // Global.assemblylineId = int.Parse(dt.Rows[0]["AssemblyLineId"].ToString());
            }
            con.Close();
        }

        private void cmbAssemblyLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            getAssemblyLineId();
            cmbStationType.Enabled = true;
            loadStationType();
        }

       

     
    }
}
