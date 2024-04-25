
namespace DWI
{
    partial class frmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbAssemblyLine = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblConfiguration = new System.Windows.Forms.Label();
            this.cmbStation = new System.Windows.Forms.ComboBox();
            this.lblStation = new System.Windows.Forms.Label();
            this.cmbStationType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAssembly = new System.Windows.Forms.Label();
            this.cmbPlant = new System.Windows.Forms.ComboBox();
            this.lblWheelAlignCheck = new System.Windows.Forms.Label();
            this.rbtnUpdate = new custom.controller.TM_RoundButton();
            this.lblPlant = new System.Windows.Forms.Label();
            this.erpSetting = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 749);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cmbAssemblyLine);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cmbStation);
            this.panel1.Controls.Add(this.lblStation);
            this.panel1.Controls.Add(this.cmbStationType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblAssembly);
            this.panel1.Controls.Add(this.cmbPlant);
            this.panel1.Controls.Add(this.lblWheelAlignCheck);
            this.panel1.Controls.Add(this.rbtnUpdate);
            this.panel1.Controls.Add(this.lblPlant);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 743);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbAssemblyLine
            // 
            this.cmbAssemblyLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAssemblyLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssemblyLine.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAssemblyLine.FormattingEnabled = true;
            this.cmbAssemblyLine.Location = new System.Drawing.Point(645, 303);
            this.cmbAssemblyLine.Name = "cmbAssemblyLine";
            this.cmbAssemblyLine.Size = new System.Drawing.Size(251, 32);
            this.cmbAssemblyLine.TabIndex = 74;
            this.cmbAssemblyLine.SelectedIndexChanged += new System.EventHandler(this.cmbAssemblyLine_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblConfiguration);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1839, 79);
            this.panel2.TabIndex = 73;
            // 
            // lblConfiguration
            // 
            this.lblConfiguration.AutoSize = true;
            this.lblConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConfiguration.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguration.ForeColor = System.Drawing.Color.Black;
            this.lblConfiguration.Location = new System.Drawing.Point(85, 18);
            this.lblConfiguration.Name = "lblConfiguration";
            this.lblConfiguration.Size = new System.Drawing.Size(245, 32);
            this.lblConfiguration.TabIndex = 61;
            this.lblConfiguration.Text = "CONFIGURATION";
            // 
            // cmbStation
            // 
            this.cmbStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStation.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStation.FormattingEnabled = true;
            this.cmbStation.Location = new System.Drawing.Point(645, 409);
            this.cmbStation.Name = "cmbStation";
            this.cmbStation.Size = new System.Drawing.Size(251, 32);
            this.cmbStation.TabIndex = 72;
            this.cmbStation.SelectedIndexChanged += new System.EventHandler(this.cmbStation_SelectedIndexChanged);
            // 
            // lblStation
            // 
            this.lblStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStation.AutoSize = true;
            this.lblStation.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation.Location = new System.Drawing.Point(471, 417);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(147, 24);
            this.lblStation.TabIndex = 71;
            this.lblStation.Text = "          Station ";
            // 
            // cmbStationType
            // 
            this.cmbStationType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbStationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStationType.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStationType.FormattingEnabled = true;
            this.cmbStationType.Location = new System.Drawing.Point(645, 354);
            this.cmbStationType.Name = "cmbStationType";
            this.cmbStationType.Size = new System.Drawing.Size(251, 32);
            this.cmbStationType.TabIndex = 70;
            this.cmbStationType.SelectedIndexChanged += new System.EventHandler(this.cmbStationType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 24);
            this.label3.TabIndex = 69;
            this.label3.Text = "          Station Type";
            // 
            // lblAssembly
            // 
            this.lblAssembly.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAssembly.AutoSize = true;
            this.lblAssembly.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssembly.Location = new System.Drawing.Point(401, 306);
            this.lblAssembly.Name = "lblAssembly";
            this.lblAssembly.Size = new System.Drawing.Size(217, 24);
            this.lblAssembly.TabIndex = 67;
            this.lblAssembly.Text = "          Assembly Line";
            // 
            // cmbPlant
            // 
            this.cmbPlant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPlant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlant.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlant.FormattingEnabled = true;
            this.cmbPlant.Location = new System.Drawing.Point(645, 246);
            this.cmbPlant.Name = "cmbPlant";
            this.cmbPlant.Size = new System.Drawing.Size(251, 32);
            this.cmbPlant.TabIndex = 66;
            this.cmbPlant.SelectedIndexChanged += new System.EventHandler(this.cmbPlant_SelectedIndexChanged_1);
            // 
            // lblWheelAlignCheck
            // 
            this.lblWheelAlignCheck.AutoSize = true;
            this.lblWheelAlignCheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWheelAlignCheck.Location = new System.Drawing.Point(263, 428);
            this.lblWheelAlignCheck.Name = "lblWheelAlignCheck";
            this.lblWheelAlignCheck.Size = new System.Drawing.Size(0, 19);
            this.lblWheelAlignCheck.TabIndex = 62;
            // 
            // rbtnUpdate
            // 
            this.rbtnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnUpdate.BorderRadius = 20;
            this.rbtnUpdate.BorderSize = 0;
            this.rbtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(137)))), ((int)(((byte)(27)))));
            this.rbtnUpdate.FlatAppearance.BorderSize = 0;
            this.rbtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnUpdate.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnUpdate.ForeColor = System.Drawing.Color.White;
            this.rbtnUpdate.Location = new System.Drawing.Point(669, 465);
            this.rbtnUpdate.Name = "rbtnUpdate";
            this.rbtnUpdate.Size = new System.Drawing.Size(166, 78);
            this.rbtnUpdate.TabIndex = 59;
            this.rbtnUpdate.Text = "Update";
            this.rbtnUpdate.TextColor = System.Drawing.Color.White;
            this.rbtnUpdate.UseVisualStyleBackColor = false;
            this.rbtnUpdate.Click += new System.EventHandler(this.rbtnUpdate_Click);
            // 
            // lblPlant
            // 
            this.lblPlant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlant.AutoSize = true;
            this.lblPlant.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlant.Location = new System.Drawing.Point(497, 254);
            this.lblPlant.Name = "lblPlant";
            this.lblPlant.Size = new System.Drawing.Size(121, 24);
            this.lblPlant.TabIndex = 2;
            this.lblPlant.Text = "          Plant";
            // 
            // erpSetting
            // 
            this.erpSetting.ContainerControl = this;
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "settings";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpSetting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPlant;
        private custom.controller.TM_RoundButton rbtnUpdate;
        private System.Windows.Forms.ErrorProvider erpSetting;
        private System.Windows.Forms.Label lblWheelAlignCheck;
        private System.Windows.Forms.ComboBox cmbStationType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAssembly;
        private System.Windows.Forms.ComboBox cmbPlant;
        private System.Windows.Forms.ComboBox cmbStation;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Label lblConfiguration;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbAssemblyLine;
    }
}