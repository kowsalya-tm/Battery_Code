
namespace DWI
{
    partial class report
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
            PresentationControls.CheckBoxProperties checkBoxProperties1 = new PresentationControls.CheckBoxProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report));
            this.erpReport = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlReport = new System.Windows.Forms.Panel();
            this.txtAssemblyLine = new System.Windows.Forms.TextBox();
            this.lblAssemblyLine = new System.Windows.Forms.Label();
            this.txtPlant = new System.Windows.Forms.TextBox();
            this.lblPlant = new System.Windows.Forms.Label();
            this.rbtnExport = new custom.controller.TM_RoundButton();
            this.txtStationName = new System.Windows.Forms.TextBox();
            this.lblStationName = new System.Windows.Forms.Label();
            this.txtPartNo = new System.Windows.Forms.TextBox();
            this.lblPartNo = new System.Windows.Forms.Label();
            this.txtStationNo = new System.Windows.Forms.TextBox();
            this.lblStationNo = new System.Windows.Forms.Label();
            this.chkListShift = new PresentationControls.CheckBoxComboBox();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.frmDate = new System.Windows.Forms.DateTimePicker();
            this.rbtnView = new custom.controller.TM_RoundButton();
            this.txtVn = new System.Windows.Forms.TextBox();
            this.lblReport = new System.Windows.Forms.Label();
            this.lblFd = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.lblTd = new System.Windows.Forms.Label();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.lblVn = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erpReport)).BeginInit();
            this.pnlReport.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // erpReport
            // 
            this.erpReport.ContainerControl = this;
            // 
            // pnlReport
            // 
            this.pnlReport.BackColor = System.Drawing.Color.White;
            this.pnlReport.Controls.Add(this.label2);
            this.pnlReport.Controls.Add(this.label1);
            this.pnlReport.Controls.Add(this.txtAssemblyLine);
            this.pnlReport.Controls.Add(this.lblAssemblyLine);
            this.pnlReport.Controls.Add(this.txtPlant);
            this.pnlReport.Controls.Add(this.lblPlant);
            this.pnlReport.Controls.Add(this.rbtnExport);
            this.pnlReport.Controls.Add(this.txtStationName);
            this.pnlReport.Controls.Add(this.lblStationName);
            this.pnlReport.Controls.Add(this.txtPartNo);
            this.pnlReport.Controls.Add(this.lblPartNo);
            this.pnlReport.Controls.Add(this.txtStationNo);
            this.pnlReport.Controls.Add(this.lblStationNo);
            this.pnlReport.Controls.Add(this.chkListShift);
            this.pnlReport.Controls.Add(this.toDate);
            this.pnlReport.Controls.Add(this.frmDate);
            this.pnlReport.Controls.Add(this.rbtnView);
            this.pnlReport.Controls.Add(this.txtVn);
            this.pnlReport.Controls.Add(this.lblReport);
            this.pnlReport.Controls.Add(this.lblFd);
            this.pnlReport.Controls.Add(this.lblShift);
            this.pnlReport.Controls.Add(this.txtEmpId);
            this.pnlReport.Controls.Add(this.lblTd);
            this.pnlReport.Controls.Add(this.lblEmpId);
            this.pnlReport.Controls.Add(this.lblVn);
            this.pnlReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReport.Location = new System.Drawing.Point(3, 3);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(1364, 171);
            this.pnlReport.TabIndex = 25;
            // 
            // txtAssemblyLine
            // 
            this.txtAssemblyLine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAssemblyLine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAssemblyLine.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssemblyLine.Location = new System.Drawing.Point(335, 128);
            this.txtAssemblyLine.Name = "txtAssemblyLine";
            this.txtAssemblyLine.ReadOnly = true;
            this.txtAssemblyLine.Size = new System.Drawing.Size(251, 32);
            this.txtAssemblyLine.TabIndex = 66;
            // 
            // lblAssemblyLine
            // 
            this.lblAssemblyLine.AutoSize = true;
            this.lblAssemblyLine.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssemblyLine.ForeColor = System.Drawing.Color.Black;
            this.lblAssemblyLine.Location = new System.Drawing.Point(337, 166);
            this.lblAssemblyLine.Name = "lblAssemblyLine";
            this.lblAssemblyLine.Size = new System.Drawing.Size(158, 24);
            this.lblAssemblyLine.TabIndex = 67;
            this.lblAssemblyLine.Text = "Assembly Line";
            // 
            // txtPlant
            // 
            this.txtPlant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPlant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPlant.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlant.Location = new System.Drawing.Point(335, 58);
            this.txtPlant.Name = "txtPlant";
            this.txtPlant.ReadOnly = true;
            this.txtPlant.Size = new System.Drawing.Size(251, 32);
            this.txtPlant.TabIndex = 64;
            this.txtPlant.TextChanged += new System.EventHandler(this.txtPlant_TextChanged);
            // 
            // lblPlant
            // 
            this.lblPlant.AutoSize = true;
            this.lblPlant.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlant.ForeColor = System.Drawing.Color.Black;
            this.lblPlant.Location = new System.Drawing.Point(341, 95);
            this.lblPlant.Name = "lblPlant";
            this.lblPlant.Size = new System.Drawing.Size(61, 24);
            this.lblPlant.TabIndex = 65;
            this.lblPlant.Text = "Plant";
            // 
            // rbtnExport
            // 
            this.rbtnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnExport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnExport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnExport.BorderRadius = 20;
            this.rbtnExport.BorderSize = 0;
            this.rbtnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(137)))), ((int)(((byte)(27)))));
            this.rbtnExport.FlatAppearance.BorderSize = 0;
            this.rbtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnExport.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnExport.ForeColor = System.Drawing.Color.White;
            this.rbtnExport.Location = new System.Drawing.Point(1479, 119);
            this.rbtnExport.Name = "rbtnExport";
            this.rbtnExport.Size = new System.Drawing.Size(147, 60);
            this.rbtnExport.TabIndex = 63;
            this.rbtnExport.Text = "Export";
            this.rbtnExport.TextColor = System.Drawing.Color.White;
            this.rbtnExport.UseVisualStyleBackColor = false;
            this.rbtnExport.Click += new System.EventHandler(this.rbtnExport_Click);
            // 
            // txtStationName
            // 
            this.txtStationName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtStationName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtStationName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStationName.Location = new System.Drawing.Point(613, 128);
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.ReadOnly = true;
            this.txtStationName.Size = new System.Drawing.Size(251, 32);
            this.txtStationName.TabIndex = 61;
            this.txtStationName.TextChanged += new System.EventHandler(this.txtStationName_TextChanged);
            // 
            // lblStationName
            // 
            this.lblStationName.AutoSize = true;
            this.lblStationName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStationName.ForeColor = System.Drawing.Color.Black;
            this.lblStationName.Location = new System.Drawing.Point(615, 166);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(144, 24);
            this.lblStationName.TabIndex = 62;
            this.lblStationName.Text = "Station Name";
            // 
            // txtPartNo
            // 
            this.txtPartNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPartNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPartNo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartNo.Location = new System.Drawing.Point(66, 128);
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.Size = new System.Drawing.Size(251, 32);
            this.txtPartNo.TabIndex = 61;
            this.txtPartNo.TextChanged += new System.EventHandler(this.txtPartNo_TextChanged);
            // 
            // lblPartNo
            // 
            this.lblPartNo.AutoSize = true;
            this.lblPartNo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartNo.ForeColor = System.Drawing.Color.Black;
            this.lblPartNo.Location = new System.Drawing.Point(72, 166);
            this.lblPartNo.Name = "lblPartNo";
            this.lblPartNo.Size = new System.Drawing.Size(136, 24);
            this.lblPartNo.TabIndex = 62;
            this.lblPartNo.Text = "Part Number";
            // 
            // txtStationNo
            // 
            this.txtStationNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtStationNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtStationNo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStationNo.Location = new System.Drawing.Point(613, 58);
            this.txtStationNo.Name = "txtStationNo";
            this.txtStationNo.ReadOnly = true;
            this.txtStationNo.Size = new System.Drawing.Size(251, 32);
            this.txtStationNo.TabIndex = 59;
            this.txtStationNo.TextChanged += new System.EventHandler(this.txtStationNo_TextChanged);
            // 
            // lblStationNo
            // 
            this.lblStationNo.AutoSize = true;
            this.lblStationNo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStationNo.ForeColor = System.Drawing.Color.Black;
            this.lblStationNo.Location = new System.Drawing.Point(619, 95);
            this.lblStationNo.Name = "lblStationNo";
            this.lblStationNo.Size = new System.Drawing.Size(166, 24);
            this.lblStationNo.TabIndex = 60;
            this.lblStationNo.Text = "Station Number";
            // 
            // chkListShift
            // 
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkListShift.CheckBoxProperties = checkBoxProperties1;
            this.chkListShift.DisplayMemberSingleItem = "";
            this.chkListShift.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListShift.FormattingEnabled = true;
            this.chkListShift.Location = new System.Drawing.Point(1183, 128);
            this.chkListShift.Name = "chkListShift";
            this.chkListShift.Size = new System.Drawing.Size(251, 32);
            this.chkListShift.TabIndex = 26;
            this.chkListShift.CheckBoxCheckedChanged += new System.EventHandler(this.chkListShift_CheckBoxCheckedChanged);
            this.chkListShift.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chkListShift_KeyPress);
            // 
            // toDate
            // 
            this.toDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDate.Location = new System.Drawing.Point(898, 129);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(251, 32);
            this.toDate.TabIndex = 8;
            this.toDate.Value = new System.DateTime(2021, 7, 28, 0, 0, 0, 0);
            this.toDate.ValueChanged += new System.EventHandler(this.toDate_ValueChanged);
            this.toDate.DropDown += new System.EventHandler(this.dateTimePicker2_DropDown);
            // 
            // frmDate
            // 
            this.frmDate.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.frmDate.Location = new System.Drawing.Point(898, 59);
            this.frmDate.Name = "frmDate";
            this.frmDate.Size = new System.Drawing.Size(251, 32);
            this.frmDate.TabIndex = 7;
            this.frmDate.Value = new System.DateTime(2021, 7, 28, 0, 0, 0, 0);
            this.frmDate.ValueChanged += new System.EventHandler(this.frmDate_ValueChanged);
            this.frmDate.DropDown += new System.EventHandler(this.dateTimePicker1_DropDown);
            // 
            // rbtnView
            // 
            this.rbtnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnView.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnView.BorderRadius = 20;
            this.rbtnView.BorderSize = 0;
            this.rbtnView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(137)))), ((int)(((byte)(27)))));
            this.rbtnView.FlatAppearance.BorderSize = 0;
            this.rbtnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnView.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnView.ForeColor = System.Drawing.Color.White;
            this.rbtnView.Location = new System.Drawing.Point(1480, 42);
            this.rbtnView.Name = "rbtnView";
            this.rbtnView.Size = new System.Drawing.Size(147, 60);
            this.rbtnView.TabIndex = 58;
            this.rbtnView.Text = "View";
            this.rbtnView.TextColor = System.Drawing.Color.White;
            this.rbtnView.UseVisualStyleBackColor = false;
            this.rbtnView.Click += new System.EventHandler(this.rbtnView_Click);
            // 
            // txtVn
            // 
            this.txtVn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtVn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtVn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVn.Location = new System.Drawing.Point(66, 58);
            this.txtVn.Name = "txtVn";
            this.txtVn.Size = new System.Drawing.Size(251, 32);
            this.txtVn.TabIndex = 1;
            this.txtVn.TextChanged += new System.EventHandler(this.txtVn_TextChanged);
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblReport.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.ForeColor = System.Drawing.Color.Black;
            this.lblReport.Location = new System.Drawing.Point(24, 13);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(129, 32);
            this.lblReport.TabIndex = 27;
            this.lblReport.Text = "REPORT";
            // 
            // lblFd
            // 
            this.lblFd.AutoSize = true;
            this.lblFd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFd.ForeColor = System.Drawing.Color.Black;
            this.lblFd.Location = new System.Drawing.Point(902, 98);
            this.lblFd.Name = "lblFd";
            this.lblFd.Size = new System.Drawing.Size(115, 24);
            this.lblFd.TabIndex = 42;
            this.lblFd.Text = "From Date";
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShift.ForeColor = System.Drawing.Color.Black;
            this.lblShift.Location = new System.Drawing.Point(1191, 166);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(56, 24);
            this.lblShift.TabIndex = 28;
            this.lblShift.Text = "Shift";
            this.lblShift.Click += new System.EventHandler(this.lblShift_Click_1);
            // 
            // txtEmpId
            // 
            this.txtEmpId.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpId.Location = new System.Drawing.Point(1183, 58);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(251, 32);
            this.txtEmpId.TabIndex = 3;
            this.txtEmpId.TextChanged += new System.EventHandler(this.txtEmpId_TextChanged);
            // 
            // lblTd
            // 
            this.lblTd.AutoSize = true;
            this.lblTd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTd.ForeColor = System.Drawing.Color.Black;
            this.lblTd.Location = new System.Drawing.Point(902, 166);
            this.lblTd.Name = "lblTd";
            this.lblTd.Size = new System.Drawing.Size(86, 24);
            this.lblTd.TabIndex = 43;
            this.lblTd.Text = "To Date";
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpId.ForeColor = System.Drawing.Color.Black;
            this.lblEmpId.Location = new System.Drawing.Point(1191, 97);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(133, 24);
            this.lblEmpId.TabIndex = 39;
            this.lblEmpId.Text = "Employee Id\r\n";
            // 
            // lblVn
            // 
            this.lblVn.AutoSize = true;
            this.lblVn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVn.ForeColor = System.Drawing.Color.Black;
            this.lblVn.Location = new System.Drawing.Point(72, 95);
            this.lblVn.Name = "lblVn";
            this.lblVn.Size = new System.Drawing.Size(127, 24);
            this.lblVn.TabIndex = 13;
            this.lblVn.Text = "VIN Number";
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Controls.Add(this.dgvReport);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(3, 194);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1364, 552);
            this.pnlGrid.TabIndex = 27;
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.EnableHeadersVisualStyles = false;
            this.dgvReport.GridColor = System.Drawing.Color.Black;
            this.dgvReport.Location = new System.Drawing.Point(0, 0);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.Size = new System.Drawing.Size(1364, 552);
            this.dgvReport.TabIndex = 25;
            this.dgvReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnlReport, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlGrid, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.76238F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.980198F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.25742F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 749);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1010, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 68;
            this.label1.Text = "*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(982, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 69;
            this.label2.Text = "*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // report
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "report";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpReport)).EndInit();
            this.pnlReport.ResumeLayout(false);
            this.pnlReport.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider erpReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Panel pnlReport;
        private System.Windows.Forms.TextBox txtPartNo;
        private System.Windows.Forms.Label lblPartNo;
        private System.Windows.Forms.TextBox txtStationNo;
        private System.Windows.Forms.Label lblStationNo;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.DateTimePicker frmDate;
        private custom.controller.TM_RoundButton rbtnView;
        private System.Windows.Forms.TextBox txtVn;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Label lblFd;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label lblTd;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Label lblVn;
        private System.Windows.Forms.TextBox txtStationName;
        private System.Windows.Forms.Label lblStationName;
        private custom.controller.TM_RoundButton rbtnExport;
        private System.Windows.Forms.TextBox txtAssemblyLine;
        private System.Windows.Forms.Label lblAssemblyLine;
        private System.Windows.Forms.TextBox txtPlant;
        private System.Windows.Forms.Label lblPlant;
        private PresentationControls.CheckBoxComboBox chkListShift;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        // private PresentationControls.CheckBoxComboBox chkListShift;
    }
}