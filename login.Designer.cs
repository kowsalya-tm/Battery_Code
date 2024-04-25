
namespace DWI
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAuthStat = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.grpEmpId = new System.Windows.Forms.Panel();
            this.rbtnLogin = new custom.controller.TM_RoundButton();
            this.lblerrorempid = new System.Windows.Forms.Label();
            this.panelFooterStrip = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.rbtnEnter = new custom.controller.TM_RoundButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblUn = new System.Windows.Forms.Label();
            this.erpLoginPage = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpEmpId.SuspendLayout();
            this.panelFooterStrip.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLoginPage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 9);
            this.panel1.TabIndex = 2;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panelHeader.Controls.Add(this.panel2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(1);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1156, 50);
            this.panelHeader.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1156, 16);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 12);
            this.panel5.Margin = new System.Windows.Forms.Padding(1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1156, 4);
            this.panel5.TabIndex = 1;
            // 
            // lblAuthStat
            // 
            this.lblAuthStat.AutoSize = true;
            this.lblAuthStat.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthStat.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblAuthStat.Location = new System.Drawing.Point(368, 224);
            this.lblAuthStat.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAuthStat.Name = "lblAuthStat";
            this.lblAuthStat.Size = new System.Drawing.Size(44, 16);
            this.lblAuthStat.TabIndex = 6;
            this.lblAuthStat.Text = "label1";
            this.lblAuthStat.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(373, 189);
            this.txtPassword.MaxLength = 32;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(187, 26);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(369, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(371, 96);
            this.txtUserName.MaxLength = 32;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(187, 26);
            this.txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(367, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeId.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeId.Location = new System.Drawing.Point(8, 4);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(105, 19);
            this.lblEmployeeId.TabIndex = 8;
            this.lblEmployeeId.Text = "Employee ID";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmployeeId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeId.Location = new System.Drawing.Point(14, 31);
            this.txtEmployeeId.MaxLength = 32;
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(185, 26);
            this.txtEmployeeId.TabIndex = 7;
            this.txtEmployeeId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeId_KeyPress);
            // 
            // grpEmpId
            // 
            this.grpEmpId.Controls.Add(this.rbtnLogin);
            this.grpEmpId.Controls.Add(this.lblEmployeeId);
            this.grpEmpId.Controls.Add(this.txtEmployeeId);
            this.grpEmpId.Location = new System.Drawing.Point(361, 285);
            this.grpEmpId.Margin = new System.Windows.Forms.Padding(1);
            this.grpEmpId.Name = "grpEmpId";
            this.grpEmpId.Size = new System.Drawing.Size(306, 62);
            this.grpEmpId.TabIndex = 12;
            this.grpEmpId.Visible = false;
            // 
            // rbtnLogin
            // 
            this.rbtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnLogin.BorderRadius = 20;
            this.rbtnLogin.BorderSize = 0;
            this.rbtnLogin.FlatAppearance.BorderSize = 0;
            this.rbtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnLogin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLogin.ForeColor = System.Drawing.Color.Transparent;
            this.rbtnLogin.Location = new System.Drawing.Point(199, 19);
            this.rbtnLogin.Name = "rbtnLogin";
            this.rbtnLogin.Size = new System.Drawing.Size(107, 40);
            this.rbtnLogin.TabIndex = 27;
            this.rbtnLogin.Text = "Login";
            this.rbtnLogin.TextColor = System.Drawing.Color.Transparent;
            this.rbtnLogin.UseVisualStyleBackColor = false;
            this.rbtnLogin.Click += new System.EventHandler(this.rbtnLogin_Click);
            this.rbtnLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtnLogin_KeyPress);
            // 
            // lblerrorempid
            // 
            this.lblerrorempid.AutoSize = true;
            this.lblerrorempid.BackColor = System.Drawing.Color.Transparent;
            this.lblerrorempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerrorempid.ForeColor = System.Drawing.Color.Red;
            this.lblerrorempid.Location = new System.Drawing.Point(368, 353);
            this.lblerrorempid.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblerrorempid.Name = "lblerrorempid";
            this.lblerrorempid.Size = new System.Drawing.Size(44, 16);
            this.lblerrorempid.TabIndex = 27;
            this.lblerrorempid.Text = "label2";
            this.lblerrorempid.Visible = false;
            // 
            // panelFooterStrip
            // 
            this.panelFooterStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panelFooterStrip.Controls.Add(this.panel7);
            this.panelFooterStrip.Controls.Add(this.panel8);
            this.panelFooterStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooterStrip.Location = new System.Drawing.Point(0, 518);
            this.panelFooterStrip.Margin = new System.Windows.Forms.Padding(1);
            this.panelFooterStrip.Name = "panelFooterStrip";
            this.panelFooterStrip.Size = new System.Drawing.Size(1156, 16);
            this.panelFooterStrip.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 12);
            this.panel7.Margin = new System.Windows.Forms.Padding(1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1156, 4);
            this.panel7.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1156, 7);
            this.panel8.TabIndex = 0;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.rbtnEnter);
            this.pnlLogin.Controls.Add(this.lblerrorempid);
            this.pnlLogin.Controls.Add(this.grpEmpId);
            this.pnlLogin.Controls.Add(this.pictureBox1);
            this.pnlLogin.Controls.Add(this.lblAuthStat);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.txtUserName);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.lblPwd);
            this.pnlLogin.Controls.Add(this.lblUn);
            this.pnlLogin.Location = new System.Drawing.Point(216, 75);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(840, 459);
            this.pnlLogin.TabIndex = 3;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // rbtnEnter
            // 
            this.rbtnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnEnter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnEnter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(13)))));
            this.rbtnEnter.BorderRadius = 20;
            this.rbtnEnter.BorderSize = 0;
            this.rbtnEnter.FlatAppearance.BorderSize = 0;
            this.rbtnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnEnter.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEnter.ForeColor = System.Drawing.Color.Transparent;
            this.rbtnEnter.Location = new System.Drawing.Point(560, 178);
            this.rbtnEnter.Name = "rbtnEnter";
            this.rbtnEnter.Size = new System.Drawing.Size(107, 40);
            this.rbtnEnter.TabIndex = 28;
            this.rbtnEnter.Text = "Enter";
            this.rbtnEnter.TextColor = System.Drawing.Color.Transparent;
            this.rbtnEnter.UseVisualStyleBackColor = false;
            this.rbtnEnter.Click += new System.EventHandler(this.rbtnEnter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DWI.Properties.Resources.RE_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(61, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd.ForeColor = System.Drawing.Color.Black;
            this.lblPwd.Location = new System.Drawing.Point(369, 164);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(86, 19);
            this.lblPwd.TabIndex = 3;
            this.lblPwd.Text = "Password";
            // 
            // lblUn
            // 
            this.lblUn.AutoSize = true;
            this.lblUn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUn.ForeColor = System.Drawing.Color.Black;
            this.lblUn.Location = new System.Drawing.Point(367, 68);
            this.lblUn.Name = "lblUn";
            this.lblUn.Size = new System.Drawing.Size(87, 19);
            this.lblUn.TabIndex = 1;
            this.lblUn.Text = "Username";
            // 
            // erpLoginPage
            // 
            this.erpLoginPage.ContainerControl = this;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 534);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooterStrip);
            this.Controls.Add(this.pnlLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            this.Load += new System.EventHandler(this.login_Load);
            this.panelHeader.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.grpEmpId.ResumeLayout(false);
            this.grpEmpId.PerformLayout();
            this.panelFooterStrip.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLoginPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAuthStat;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Panel grpEmpId;
        private System.Windows.Forms.Label lblerrorempid;
        private System.Windows.Forms.Panel panelFooterStrip;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblUn;
        private custom.controller.TM_RoundButton rbtnEnter;
        private System.Windows.Forms.ErrorProvider erpLoginPage;
        private custom.controller.TM_RoundButton rbtnLogin;
    }
}

