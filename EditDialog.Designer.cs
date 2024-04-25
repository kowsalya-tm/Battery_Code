namespace DWI
{
    partial class EditDialog
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbtn_battery = new System.Windows.Forms.RadioButton();
            this.rdbtn_TCU = new System.Windows.Forms.RadioButton();
            this.lblwarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(404, 138);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(110, 30);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Do you want edit?";
            // 
            // rdbtn_battery
            // 
            this.rdbtn_battery.AutoSize = true;
            this.rdbtn_battery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_battery.Location = new System.Drawing.Point(96, 87);
            this.rdbtn_battery.Name = "rdbtn_battery";
            this.rdbtn_battery.Size = new System.Drawing.Size(79, 22);
            this.rdbtn_battery.TabIndex = 2;
            this.rdbtn_battery.TabStop = true;
            this.rdbtn_battery.Text = "Battery";
            this.rdbtn_battery.UseVisualStyleBackColor = true;
            this.rdbtn_battery.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbtn_TCU
            // 
            this.rdbtn_TCU.AutoSize = true;
            this.rdbtn_TCU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_TCU.Location = new System.Drawing.Point(367, 87);
            this.rdbtn_TCU.Name = "rdbtn_TCU";
            this.rdbtn_TCU.Size = new System.Drawing.Size(60, 22);
            this.rdbtn_TCU.TabIndex = 3;
            this.rdbtn_TCU.TabStop = true;
            this.rdbtn_TCU.Text = "TCU";
            this.rdbtn_TCU.UseVisualStyleBackColor = true;
            this.rdbtn_TCU.CheckedChanged += new System.EventHandler(this.rdbtn_TCU_CheckedChanged);
            // 
            // lblwarning
            // 
            this.lblwarning.AutoSize = true;
            this.lblwarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwarning.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblwarning.Location = new System.Drawing.Point(179, 152);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(161, 16);
            this.lblwarning.TabIndex = 4;
            this.lblwarning.Text = "Please select any one";
            this.lblwarning.Visible = false;
            // 
            // EditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(544, 180);
            this.ControlBox = false;
            this.Controls.Add(this.lblwarning);
            this.Controls.Add(this.rdbtn_TCU);
            this.Controls.Add(this.rdbtn_battery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbtn_battery;
        private System.Windows.Forms.RadioButton rdbtn_TCU;
        private System.Windows.Forms.Label lblwarning;
    }
}