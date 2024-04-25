
namespace DWI
{
    partial class frmBattery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBattery));
            this.tpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStationNo = new System.Windows.Forms.Label();
            this.lblManual = new System.Windows.Forms.Label();
            this.lblEmpNameValue = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblStationName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Midrightpanel4 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtScanTCU = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtnExportNotification = new custom.controller.TM_RoundButton();
            this.rbtnStatus = new custom.controller.TM_RoundButton();
            this.txtScanPart = new System.Windows.Forms.TextBox();
            this.txtScanVehicle = new System.Windows.Forms.TextBox();
            this.lblPart = new System.Windows.Forms.Label();
            this.lblScan = new System.Windows.Forms.Label();
            this.rbtnComleted = new custom.controller.TM_RoundButton();
            this.rbtnRework = new custom.controller.TM_RoundButton();
            this.tM_RoundButton5 = new custom.controller.TM_RoundButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tM_RoundButton4 = new custom.controller.TM_RoundButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tM_RoundButton3 = new custom.controller.TM_RoundButton();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.tM_RoundButton2 = new custom.controller.TM_RoundButton();
            this.lblMlhh06 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblScanVinNumber = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblScanPart = new System.Windows.Forms.Label();
            this.lblScanVehicle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblColor = new System.Windows.Forms.Label();
            this.picBoxPartVariant = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPartCode = new System.Windows.Forms.Label();
            this.lblPartCodeValue = new System.Windows.Forms.Label();
            this.lblModelCode = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblVinNumber = new System.Windows.Forms.Label();
            this.lblModelDesc = new System.Windows.Forms.Label();
            this.lblVinNoValue = new System.Windows.Forms.Label();
            this.lblModelCodeValue = new System.Windows.Forms.Label();
            this.lblOrderTypeValue = new System.Windows.Forms.Label();
            this.lblTypeValue = new System.Windows.Forms.Label();
            this.lblModelDescValue = new System.Windows.Forms.Label();
            this.erpMainLine = new System.Windows.Forms.ErrorProvider(this.components);
            this.timerStatusResult = new System.Windows.Forms.Timer(this.components);
            this.timerExport = new System.Windows.Forms.Timer(this.components);
            this.tpnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Midrightpanel4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPartVariant)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpMainLine)).BeginInit();
            this.SuspendLayout();
            // 
            // tpnlMain
            // 
            this.tpnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tpnlMain.ColumnCount = 1;
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.Controls.Add(this.panel1, 0, 0);
            this.tpnlMain.Controls.Add(this.panel2, 0, 4);
            this.tpnlMain.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlMain.Location = new System.Drawing.Point(0, 0);
            this.tpnlMain.MinimumSize = new System.Drawing.Size(800, 600);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.RowCount = 5;
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.38245F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.53918F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tpnlMain.Size = new System.Drawing.Size(1386, 788);
            this.tpnlMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblStationNo);
            this.panel1.Controls.Add(this.lblManual);
            this.panel1.Controls.Add(this.lblEmpNameValue);
            this.panel1.Controls.Add(this.lblMode);
            this.panel1.Controls.Add(this.lblStationName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1380, 90);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1004, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "Employee Id :";
            // 
            // lblStationNo
            // 
            this.lblStationNo.AutoSize = true;
            this.lblStationNo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStationNo.Location = new System.Drawing.Point(3, 6);
            this.lblStationNo.Name = "lblStationNo";
            this.lblStationNo.Size = new System.Drawing.Size(0, 37);
            this.lblStationNo.TabIndex = 6;
            // 
            // lblManual
            // 
            this.lblManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManual.AutoSize = true;
            this.lblManual.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManual.ForeColor = System.Drawing.Color.Red;
            this.lblManual.Location = new System.Drawing.Point(1217, 6);
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(154, 37);
            this.lblManual.TabIndex = 4;
            this.lblManual.Text = "MANUAL";
            // 
            // lblEmpNameValue
            // 
            this.lblEmpNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpNameValue.AutoSize = true;
            this.lblEmpNameValue.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpNameValue.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblEmpNameValue.Location = new System.Drawing.Point(1221, 52);
            this.lblEmpNameValue.Name = "lblEmpNameValue";
            this.lblEmpNameValue.Size = new System.Drawing.Size(72, 32);
            this.lblEmpNameValue.TabIndex = 3;
            this.lblEmpNameValue.Text = "emp";
            // 
            // lblMode
            // 
            this.lblMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(1096, 6);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(140, 37);
            this.lblMode.TabIndex = 2;
            this.lblMode.Text = "MODE : ";
            // 
            // lblStationName
            // 
            this.lblStationName.AccessibleName = "";
            this.lblStationName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStationName.AutoSize = true;
            this.lblStationName.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStationName.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblStationName.Location = new System.Drawing.Point(1, 47);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(0, 32);
            this.lblStationName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 27);
            this.label1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Midrightpanel4);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.lblScanPart);
            this.panel2.Controls.Add(this.lblScanVehicle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 595);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1380, 190);
            this.panel2.TabIndex = 1;
            // 
            // Midrightpanel4
            // 
            this.Midrightpanel4.BackColor = System.Drawing.Color.White;
            this.Midrightpanel4.Controls.Add(this.panel4);
            this.Midrightpanel4.Controls.Add(this.tM_RoundButton3);
            this.Midrightpanel4.Controls.Add(this.lblCompleted);
            this.Midrightpanel4.Controls.Add(this.tM_RoundButton2);
            this.Midrightpanel4.Controls.Add(this.lblMlhh06);
            this.Midrightpanel4.Controls.Add(this.textBox3);
            this.Midrightpanel4.Controls.Add(this.lblScanVinNumber);
            this.Midrightpanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Midrightpanel4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Midrightpanel4.Location = new System.Drawing.Point(0, 0);
            this.Midrightpanel4.Name = "Midrightpanel4";
            this.Midrightpanel4.Size = new System.Drawing.Size(1380, 190);
            this.Midrightpanel4.TabIndex = 62;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.tM_RoundButton5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.tM_RoundButton4);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1380, 190);
            this.panel4.TabIndex = 63;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.txtScanTCU);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.rbtnExportNotification);
            this.panel5.Controls.Add(this.rbtnStatus);
            this.panel5.Controls.Add(this.txtScanPart);
            this.panel5.Controls.Add(this.txtScanVehicle);
            this.panel5.Controls.Add(this.lblPart);
            this.panel5.Controls.Add(this.lblScan);
            this.panel5.Controls.Add(this.rbtnComleted);
            this.panel5.Controls.Add(this.rbtnRework);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1380, 190);
            this.panel5.TabIndex = 63;
            // 
            // txtScanTCU
            // 
            this.txtScanTCU.Enabled = false;
            this.txtScanTCU.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScanTCU.Location = new System.Drawing.Point(939, 115);
            this.txtScanTCU.Name = "txtScanTCU";
            this.txtScanTCU.Size = new System.Drawing.Size(388, 39);
            this.txtScanTCU.TabIndex = 72;
            this.txtScanTCU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScanTCU_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(935, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 34);
            this.label6.TabIndex = 73;
            this.label6.Text = "Scan TCU";
            // 
            // rbtnExportNotification
            // 
            this.rbtnExportNotification.BackColor = System.Drawing.Color.Red;
            this.rbtnExportNotification.BackgroundColor = System.Drawing.Color.Red;
            this.rbtnExportNotification.BorderColor = System.Drawing.Color.Red;
            this.rbtnExportNotification.BorderRadius = 30;
            this.rbtnExportNotification.BorderSize = 0;
            this.rbtnExportNotification.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(137)))), ((int)(((byte)(27)))));
            this.rbtnExportNotification.FlatAppearance.BorderSize = 0;
            this.rbtnExportNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnExportNotification.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnExportNotification.ForeColor = System.Drawing.Color.White;
            this.rbtnExportNotification.Location = new System.Drawing.Point(1353, 58);
            this.rbtnExportNotification.Name = "rbtnExportNotification";
            this.rbtnExportNotification.Size = new System.Drawing.Size(216, 98);
            this.rbtnExportNotification.TabIndex = 71;
            this.rbtnExportNotification.Text = "EXPORT";
            this.rbtnExportNotification.TextColor = System.Drawing.Color.White;
            this.rbtnExportNotification.UseVisualStyleBackColor = false;
            // 
            // rbtnStatus
            // 
            this.rbtnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(216)))), ((int)(((byte)(94)))));
            this.rbtnStatus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(216)))), ((int)(((byte)(94)))));
            this.rbtnStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(216)))), ((int)(((byte)(94)))));
            this.rbtnStatus.BorderRadius = 40;
            this.rbtnStatus.BorderSize = 0;
            this.rbtnStatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(137)))), ((int)(((byte)(27)))));
            this.rbtnStatus.FlatAppearance.BorderSize = 0;
            this.rbtnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnStatus.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnStatus.ForeColor = System.Drawing.Color.White;
            this.rbtnStatus.Location = new System.Drawing.Point(1339, 54);
            this.rbtnStatus.Name = "rbtnStatus";
            this.rbtnStatus.Size = new System.Drawing.Size(185, 107);
            this.rbtnStatus.TabIndex = 69;
            this.rbtnStatus.TextColor = System.Drawing.Color.White;
            this.rbtnStatus.UseVisualStyleBackColor = false;
            // 
            // txtScanPart
            // 
            this.txtScanPart.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScanPart.Location = new System.Drawing.Point(510, 115);
            this.txtScanPart.Name = "txtScanPart";
            this.txtScanPart.Size = new System.Drawing.Size(388, 39);
            this.txtScanPart.TabIndex = 2;
            this.txtScanPart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScanPart_KeyDown);
            this.txtScanPart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScanVehicle_KeyPress);
            // 
            // txtScanVehicle
            // 
            this.txtScanVehicle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScanVehicle.Location = new System.Drawing.Point(28, 115);
            this.txtScanVehicle.Name = "txtScanVehicle";
            this.txtScanVehicle.Size = new System.Drawing.Size(434, 39);
            this.txtScanVehicle.TabIndex = 1;
            this.txtScanVehicle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScanVehicle_KeyDown);
            this.txtScanVehicle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScanVehicle_KeyPress);
            // 
            // lblPart
            // 
            this.lblPart.AutoSize = true;
            this.lblPart.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPart.Location = new System.Drawing.Point(506, 51);
            this.lblPart.Name = "lblPart";
            this.lblPart.Size = new System.Drawing.Size(191, 34);
            this.lblPart.TabIndex = 66;
            this.lblPart.Text = "Scan Battery";
            // 
            // lblScan
            // 
            this.lblScan.AutoSize = true;
            this.lblScan.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScan.Location = new System.Drawing.Point(33, 51);
            this.lblScan.Name = "lblScan";
            this.lblScan.Size = new System.Drawing.Size(191, 34);
            this.lblScan.TabIndex = 65;
            this.lblScan.Text = "Scan Vehicle";
            // 
            // rbtnComleted
            // 
            this.rbtnComleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(216)))), ((int)(((byte)(94)))));
            this.rbtnComleted.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(216)))), ((int)(((byte)(94)))));
            this.rbtnComleted.BorderColor = System.Drawing.Color.AliceBlue;
            this.rbtnComleted.BorderRadius = 20;
            this.rbtnComleted.BorderSize = 0;
            this.rbtnComleted.FlatAppearance.BorderSize = 0;
            this.rbtnComleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnComleted.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnComleted.ForeColor = System.Drawing.Color.White;
            this.rbtnComleted.Location = new System.Drawing.Point(1514, 69);
            this.rbtnComleted.Name = "rbtnComleted";
            this.rbtnComleted.Size = new System.Drawing.Size(262, 112);
            this.rbtnComleted.TabIndex = 64;
            this.rbtnComleted.Text = "Completed";
            this.rbtnComleted.TextColor = System.Drawing.Color.White;
            this.rbtnComleted.UseVisualStyleBackColor = false;
            this.rbtnComleted.Visible = false;
            this.rbtnComleted.Click += new System.EventHandler(this.rbtnComleted_Click);
            // 
            // rbtnRework
            // 
            this.rbtnRework.BackColor = System.Drawing.Color.Red;
            this.rbtnRework.BackgroundColor = System.Drawing.Color.Red;
            this.rbtnRework.BorderColor = System.Drawing.Color.AliceBlue;
            this.rbtnRework.BorderRadius = 20;
            this.rbtnRework.BorderSize = 0;
            this.rbtnRework.FlatAppearance.BorderSize = 0;
            this.rbtnRework.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnRework.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRework.ForeColor = System.Drawing.Color.White;
            this.rbtnRework.Location = new System.Drawing.Point(1339, 76);
            this.rbtnRework.Name = "rbtnRework";
            this.rbtnRework.Size = new System.Drawing.Size(172, 84);
            this.rbtnRework.TabIndex = 63;
            this.rbtnRework.Text = "Rework";
            this.rbtnRework.TextColor = System.Drawing.Color.White;
            this.rbtnRework.UseVisualStyleBackColor = false;
            this.rbtnRework.Visible = false;
            // 
            // tM_RoundButton5
            // 
            this.tM_RoundButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.tM_RoundButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.tM_RoundButton5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.tM_RoundButton5.BorderRadius = 20;
            this.tM_RoundButton5.BorderSize = 0;
            this.tM_RoundButton5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(137)))), ((int)(((byte)(27)))));
            this.tM_RoundButton5.FlatAppearance.BorderSize = 0;
            this.tM_RoundButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tM_RoundButton5.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tM_RoundButton5.ForeColor = System.Drawing.Color.White;
            this.tM_RoundButton5.Location = new System.Drawing.Point(381, 180);
            this.tM_RoundButton5.Name = "tM_RoundButton5";
            this.tM_RoundButton5.Size = new System.Drawing.Size(160, 72);
            this.tM_RoundButton5.TabIndex = 62;
            this.tM_RoundButton5.Text = "Update";
            this.tM_RoundButton5.TextColor = System.Drawing.Color.White;
            this.tM_RoundButton5.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(32, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Completed";
            // 
            // tM_RoundButton4
            // 
            this.tM_RoundButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.tM_RoundButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.tM_RoundButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.tM_RoundButton4.BorderRadius = 20;
            this.tM_RoundButton4.BorderSize = 0;
            this.tM_RoundButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(137)))), ((int)(((byte)(27)))));
            this.tM_RoundButton4.FlatAppearance.BorderSize = 0;
            this.tM_RoundButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tM_RoundButton4.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tM_RoundButton4.ForeColor = System.Drawing.Color.White;
            this.tM_RoundButton4.Location = new System.Drawing.Point(195, 180);
            this.tM_RoundButton4.Name = "tM_RoundButton4";
            this.tM_RoundButton4.Size = new System.Drawing.Size(160, 72);
            this.tM_RoundButton4.TabIndex = 61;
            this.tM_RoundButton4.Text = "Update";
            this.tM_RoundButton4.TextColor = System.Drawing.Color.White;
            this.tM_RoundButton4.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "MLH -06";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(239, 135);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(302, 29);
            this.textBox4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Scan VIN Number";
            // 
            // tM_RoundButton3
            // 
            this.tM_RoundButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.tM_RoundButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.tM_RoundButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.tM_RoundButton3.BorderRadius = 20;
            this.tM_RoundButton3.BorderSize = 0;
            this.tM_RoundButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(137)))), ((int)(((byte)(27)))));
            this.tM_RoundButton3.FlatAppearance.BorderSize = 0;
            this.tM_RoundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tM_RoundButton3.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tM_RoundButton3.ForeColor = System.Drawing.Color.White;
            this.tM_RoundButton3.Location = new System.Drawing.Point(381, 180);
            this.tM_RoundButton3.Name = "tM_RoundButton3";
            this.tM_RoundButton3.Size = new System.Drawing.Size(160, 72);
            this.tM_RoundButton3.TabIndex = 62;
            this.tM_RoundButton3.Text = "Update";
            this.tM_RoundButton3.TextColor = System.Drawing.Color.White;
            this.tM_RoundButton3.UseVisualStyleBackColor = false;
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCompleted.Location = new System.Drawing.Point(32, 43);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(110, 22);
            this.lblCompleted.TabIndex = 1;
            this.lblCompleted.Text = "Completed";
            // 
            // tM_RoundButton2
            // 
            this.tM_RoundButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.tM_RoundButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.tM_RoundButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.tM_RoundButton2.BorderRadius = 20;
            this.tM_RoundButton2.BorderSize = 0;
            this.tM_RoundButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(137)))), ((int)(((byte)(27)))));
            this.tM_RoundButton2.FlatAppearance.BorderSize = 0;
            this.tM_RoundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tM_RoundButton2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tM_RoundButton2.ForeColor = System.Drawing.Color.White;
            this.tM_RoundButton2.Location = new System.Drawing.Point(195, 180);
            this.tM_RoundButton2.Name = "tM_RoundButton2";
            this.tM_RoundButton2.Size = new System.Drawing.Size(160, 72);
            this.tM_RoundButton2.TabIndex = 61;
            this.tM_RoundButton2.Text = "Update";
            this.tM_RoundButton2.TextColor = System.Drawing.Color.White;
            this.tM_RoundButton2.UseVisualStyleBackColor = false;
            // 
            // lblMlhh06
            // 
            this.lblMlhh06.AutoSize = true;
            this.lblMlhh06.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMlhh06.Location = new System.Drawing.Point(32, 11);
            this.lblMlhh06.Name = "lblMlhh06";
            this.lblMlhh06.Size = new System.Drawing.Size(85, 22);
            this.lblMlhh06.TabIndex = 0;
            this.lblMlhh06.Text = "MLH -06";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(239, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(302, 29);
            this.textBox3.TabIndex = 4;
            // 
            // lblScanVinNumber
            // 
            this.lblScanVinNumber.AutoSize = true;
            this.lblScanVinNumber.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanVinNumber.Location = new System.Drawing.Point(3, 135);
            this.lblScanVinNumber.Name = "lblScanVinNumber";
            this.lblScanVinNumber.Size = new System.Drawing.Size(171, 22);
            this.lblScanVinNumber.TabIndex = 0;
            this.lblScanVinNumber.Text = "Scan VIN Number";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Location = new System.Drawing.Point(169, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(169, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblScanPart
            // 
            this.lblScanPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblScanPart.AutoSize = true;
            this.lblScanPart.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanPart.Location = new System.Drawing.Point(20, 146);
            this.lblScanPart.Name = "lblScanPart";
            this.lblScanPart.Size = new System.Drawing.Size(98, 23);
            this.lblScanPart.TabIndex = 1;
            this.lblScanPart.Text = "Scan Part";
            // 
            // lblScanVehicle
            // 
            this.lblScanVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblScanVehicle.AutoSize = true;
            this.lblScanVehicle.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanVehicle.Location = new System.Drawing.Point(21, 100);
            this.lblScanVehicle.Name = "lblScanVehicle";
            this.lblScanVehicle.Size = new System.Drawing.Size(125, 23);
            this.lblScanVehicle.TabIndex = 0;
            this.lblScanVehicle.Text = "Scan Vehicle";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.45293F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.54707F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 104);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1380, 480);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.picBoxPartVariant, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.63049F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.36951F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(742, 474);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblColor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 423);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(736, 48);
            this.panel3.TabIndex = 0;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(7, 7);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(0, 29);
            this.lblColor.TabIndex = 0;
            // 
            // picBoxPartVariant
            // 
            this.picBoxPartVariant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxPartVariant.Image = global::DWI.Properties.Resources.Battery;
            this.picBoxPartVariant.Location = new System.Drawing.Point(3, 3);
            this.picBoxPartVariant.Name = "picBoxPartVariant";
            this.picBoxPartVariant.Size = new System.Drawing.Size(736, 414);
            this.picBoxPartVariant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPartVariant.TabIndex = 1;
            this.picBoxPartVariant.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.44521F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.55479F));
            this.tableLayoutPanel3.Controls.Add(this.lblPartCode, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblPartCodeValue, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblModelCode, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblOrderType, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblType, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblVinNumber, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblModelDesc, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblVinNoValue, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblModelCodeValue, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblOrderTypeValue, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblTypeValue, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblModelDescValue, 1, 2);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(756, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.05426F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.50388F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.31266F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.53747F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(621, 474);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // lblPartCode
            // 
            this.lblPartCode.AutoSize = true;
            this.lblPartCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPartCode.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartCode.Location = new System.Drawing.Point(3, 394);
            this.lblPartCode.Name = "lblPartCode";
            this.lblPartCode.Size = new System.Drawing.Size(214, 80);
            this.lblPartCode.TabIndex = 12;
            this.lblPartCode.Text = "     PartCode";
            this.lblPartCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPartCodeValue
            // 
            this.lblPartCodeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPartCodeValue.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartCodeValue.Location = new System.Drawing.Point(223, 394);
            this.lblPartCodeValue.Name = "lblPartCodeValue";
            this.lblPartCodeValue.Size = new System.Drawing.Size(395, 80);
            this.lblPartCodeValue.TabIndex = 13;
            this.lblPartCodeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblModelCode
            // 
            this.lblModelCode.AutoSize = true;
            this.lblModelCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelCode.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelCode.Location = new System.Drawing.Point(3, 79);
            this.lblModelCode.Name = "lblModelCode";
            this.lblModelCode.Size = new System.Drawing.Size(214, 79);
            this.lblModelCode.TabIndex = 1;
            this.lblModelCode.Text = "     Vehicle Code";
            this.lblModelCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderType.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderType.Location = new System.Drawing.Point(3, 239);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(214, 73);
            this.lblOrderType.TabIndex = 3;
            this.lblOrderType.Text = "     OrderType";
            this.lblOrderType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(3, 312);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(214, 82);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "     Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVinNumber
            // 
            this.lblVinNumber.AutoSize = true;
            this.lblVinNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVinNumber.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVinNumber.Location = new System.Drawing.Point(3, 0);
            this.lblVinNumber.Name = "lblVinNumber";
            this.lblVinNumber.Size = new System.Drawing.Size(214, 79);
            this.lblVinNumber.TabIndex = 0;
            this.lblVinNumber.Text = "     VIN ";
            this.lblVinNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblModelDesc
            // 
            this.lblModelDesc.AutoSize = true;
            this.lblModelDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelDesc.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelDesc.Location = new System.Drawing.Point(3, 158);
            this.lblModelDesc.Name = "lblModelDesc";
            this.lblModelDesc.Size = new System.Drawing.Size(214, 81);
            this.lblModelDesc.TabIndex = 2;
            this.lblModelDesc.Text = "     Vehicle Desc";
            this.lblModelDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVinNoValue
            // 
            this.lblVinNoValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVinNoValue.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVinNoValue.Location = new System.Drawing.Point(223, 0);
            this.lblVinNoValue.Name = "lblVinNoValue";
            this.lblVinNoValue.Size = new System.Drawing.Size(395, 79);
            this.lblVinNoValue.TabIndex = 6;
            this.lblVinNoValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblModelCodeValue
            // 
            this.lblModelCodeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelCodeValue.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelCodeValue.Location = new System.Drawing.Point(223, 79);
            this.lblModelCodeValue.Name = "lblModelCodeValue";
            this.lblModelCodeValue.Size = new System.Drawing.Size(395, 79);
            this.lblModelCodeValue.TabIndex = 7;
            this.lblModelCodeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrderTypeValue
            // 
            this.lblOrderTypeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderTypeValue.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTypeValue.Location = new System.Drawing.Point(223, 239);
            this.lblOrderTypeValue.Name = "lblOrderTypeValue";
            this.lblOrderTypeValue.Size = new System.Drawing.Size(395, 73);
            this.lblOrderTypeValue.TabIndex = 9;
            this.lblOrderTypeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTypeValue
            // 
            this.lblTypeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTypeValue.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeValue.Location = new System.Drawing.Point(223, 312);
            this.lblTypeValue.Name = "lblTypeValue";
            this.lblTypeValue.Size = new System.Drawing.Size(395, 82);
            this.lblTypeValue.TabIndex = 10;
            this.lblTypeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblModelDescValue
            // 
            this.lblModelDescValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelDescValue.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelDescValue.Location = new System.Drawing.Point(223, 158);
            this.lblModelDescValue.Name = "lblModelDescValue";
            this.lblModelDescValue.Size = new System.Drawing.Size(395, 81);
            this.lblModelDescValue.TabIndex = 8;
            this.lblModelDescValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // erpMainLine
            // 
            this.erpMainLine.ContainerControl = this;
            // 
            // timerStatusResult
            // 
            this.timerStatusResult.Interval = 1000;
            this.timerStatusResult.Tick += new System.EventHandler(this.timerStatusResult_Tick);
            // 
            // timerExport
            // 
            this.timerExport.Interval = 1000;
            this.timerExport.Tick += new System.EventHandler(this.timerExport_Tick);
            // 
            // frmBattery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.tpnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBattery";
            this.Text = "Mainline";
            this.Load += new System.EventHandler(this.frmMainLine_Load);
            this.tpnlMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Midrightpanel4.ResumeLayout(false);
            this.Midrightpanel4.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPartVariant)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpMainLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblEmpNameValue;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblStationName;
        private System.Windows.Forms.Label lblManual;
        private System.Windows.Forms.Label lblModelCode;
        private System.Windows.Forms.Label lblModelDesc;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblVinNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVinNoValue;
        private System.Windows.Forms.Label lblModelCodeValue;
        private System.Windows.Forms.Label lblModelDescValue;
        private System.Windows.Forms.Label lblOrderTypeValue;
        private System.Windows.Forms.Label lblTypeValue;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblScanPart;
        private System.Windows.Forms.Label lblScanVehicle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.PictureBox picBoxPartVariant;
        private System.Windows.Forms.Panel Midrightpanel4;
        private System.Windows.Forms.Panel panel4;
        private custom.controller.TM_RoundButton tM_RoundButton5;
        private System.Windows.Forms.Label label3;
        private custom.controller.TM_RoundButton tM_RoundButton4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private custom.controller.TM_RoundButton tM_RoundButton3;
        private System.Windows.Forms.Label lblCompleted;
        private custom.controller.TM_RoundButton tM_RoundButton2;
        private System.Windows.Forms.Label lblMlhh06;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblScanVinNumber;
        private System.Windows.Forms.Panel panel5;
        private custom.controller.TM_RoundButton rbtnComleted;
        private custom.controller.TM_RoundButton rbtnRework;
        private System.Windows.Forms.TextBox txtScanPart;
        private System.Windows.Forms.TextBox txtScanVehicle;
        private System.Windows.Forms.Label lblPart;
        private System.Windows.Forms.Label lblScan;
        private System.Windows.Forms.ErrorProvider erpMainLine;
        private System.Windows.Forms.Label lblStationNo;
        private System.Windows.Forms.Label lblPartCode;
        private System.Windows.Forms.Label lblPartCodeValue;
        private System.Windows.Forms.Timer timerStatusResult;
        private custom.controller.TM_RoundButton rbtnStatus;
        private custom.controller.TM_RoundButton rbtnExportNotification;
        private System.Windows.Forms.Timer timerExport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtScanTCU;
        private System.Windows.Forms.Label label6;
    }
}