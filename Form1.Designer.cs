
namespace DWI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1mid = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmp12345678 = new System.Windows.Forms.Label();
            this.lblManual = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblQHold = new System.Windows.Forms.Label();
            this.lblMlh22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1mid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1mid
            // 
            this.pictureBox1mid.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1mid.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1mid.Image")));
            this.pictureBox1mid.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1mid.Name = "pictureBox1mid";
            this.pictureBox1mid.Size = new System.Drawing.Size(342, 449);
            this.pictureBox1mid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1mid.TabIndex = 2;
            this.pictureBox1mid.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblEmp12345678);
            this.panel1.Controls.Add(this.lblManual);
            this.panel1.Controls.Add(this.lblMode);
            this.panel1.Controls.Add(this.lblQHold);
            this.panel1.Controls.Add(this.lblMlh22);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(342, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 449);
            this.panel1.TabIndex = 3;
            // 
            // lblEmp12345678
            // 
            this.lblEmp12345678.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmp12345678.AutoSize = true;
            this.lblEmp12345678.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp12345678.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmp12345678.Location = new System.Drawing.Point(388, 52);
            this.lblEmp12345678.Name = "lblEmp12345678";
            this.lblEmp12345678.Size = new System.Drawing.Size(141, 22);
            this.lblEmp12345678.TabIndex = 4;
            this.lblEmp12345678.Text = "EMP12345678";
            this.lblEmp12345678.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblManual
            // 
            this.lblManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManual.AutoSize = true;
            this.lblManual.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManual.ForeColor = System.Drawing.Color.Red;
            this.lblManual.Location = new System.Drawing.Point(459, 10);
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(78, 22);
            this.lblManual.TabIndex = 3;
            this.lblManual.Text = "Manual";
            // 
            // lblMode
            // 
            this.lblMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(388, 10);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(74, 22);
            this.lblMode.TabIndex = 2;
            this.lblMode.Text = "Mode :";
            // 
            // lblQHold
            // 
            this.lblQHold.AutoSize = true;
            this.lblQHold.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQHold.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblQHold.Location = new System.Drawing.Point(9, 43);
            this.lblQHold.Name = "lblQHold";
            this.lblQHold.Size = new System.Drawing.Size(165, 22);
            this.lblQHold.TabIndex = 1;
            this.lblQHold.Text = "Q Hold LH - VA01";
            // 
            // lblMlh22
            // 
            this.lblMlh22.AutoSize = true;
            this.lblMlh22.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMlh22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMlh22.Location = new System.Drawing.Point(9, 10);
            this.lblMlh22.Name = "lblMlh22";
            this.lblMlh22.Size = new System.Drawing.Size(80, 22);
            this.lblMlh22.TabIndex = 0;
            this.lblMlh22.Text = "MLH-22";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 449);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1mid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1mid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1mid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmp12345678;
        private System.Windows.Forms.Label lblManual;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblQHold;
        private System.Windows.Forms.Label lblMlh22;
    }
}