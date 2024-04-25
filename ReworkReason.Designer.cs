
namespace DWI
{
    partial class ReworkReason
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnPartNotAvailable = new custom.controller.TM_RoundButton();
            this.rbtnPartDamaged = new custom.controller.TM_RoundButton();
            this.rbtnOthers = new custom.controller.TM_RoundButton();
            this.rbtnClose = new custom.controller.TM_RoundButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbtnClose);
            this.panel1.Controls.Add(this.rbtnOthers);
            this.panel1.Controls.Add(this.rbtnPartDamaged);
            this.panel1.Controls.Add(this.rbtnPartNotAvailable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 407);
            this.panel1.TabIndex = 0;
            // 
            // rbtnPartNotAvailable
            // 
            this.rbtnPartNotAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(102)))));
            this.rbtnPartNotAvailable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(102)))));
            this.rbtnPartNotAvailable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(102)))));
            this.rbtnPartNotAvailable.BorderRadius = 20;
            this.rbtnPartNotAvailable.BorderSize = 0;
            this.rbtnPartNotAvailable.FlatAppearance.BorderSize = 0;
            this.rbtnPartNotAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnPartNotAvailable.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPartNotAvailable.ForeColor = System.Drawing.Color.Black;
            this.rbtnPartNotAvailable.Location = new System.Drawing.Point(55, 53);
            this.rbtnPartNotAvailable.Name = "rbtnPartNotAvailable";
            this.rbtnPartNotAvailable.Size = new System.Drawing.Size(324, 52);
            this.rbtnPartNotAvailable.TabIndex = 64;
            this.rbtnPartNotAvailable.Text = "Part Not Available";
            this.rbtnPartNotAvailable.TextColor = System.Drawing.Color.Black;
            this.rbtnPartNotAvailable.UseVisualStyleBackColor = false;
            this.rbtnPartNotAvailable.Click += new System.EventHandler(this.rbtnPartNotAvailable_Click);
            // 
            // rbtnPartDamaged
            // 
            this.rbtnPartDamaged.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(102)))));
            this.rbtnPartDamaged.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(102)))));
            this.rbtnPartDamaged.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(102)))));
            this.rbtnPartDamaged.BorderRadius = 20;
            this.rbtnPartDamaged.BorderSize = 0;
            this.rbtnPartDamaged.FlatAppearance.BorderSize = 0;
            this.rbtnPartDamaged.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnPartDamaged.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPartDamaged.ForeColor = System.Drawing.Color.Black;
            this.rbtnPartDamaged.Location = new System.Drawing.Point(55, 132);
            this.rbtnPartDamaged.Name = "rbtnPartDamaged";
            this.rbtnPartDamaged.Size = new System.Drawing.Size(324, 52);
            this.rbtnPartDamaged.TabIndex = 65;
            this.rbtnPartDamaged.Text = "Part Damaged";
            this.rbtnPartDamaged.TextColor = System.Drawing.Color.Black;
            this.rbtnPartDamaged.UseVisualStyleBackColor = false;
            this.rbtnPartDamaged.Click += new System.EventHandler(this.rbtnPartDamaged_Click);
            // 
            // rbtnOthers
            // 
            this.rbtnOthers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(102)))));
            this.rbtnOthers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(102)))));
            this.rbtnOthers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(102)))));
            this.rbtnOthers.BorderRadius = 20;
            this.rbtnOthers.BorderSize = 0;
            this.rbtnOthers.FlatAppearance.BorderSize = 0;
            this.rbtnOthers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnOthers.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOthers.ForeColor = System.Drawing.Color.Black;
            this.rbtnOthers.Location = new System.Drawing.Point(55, 212);
            this.rbtnOthers.Name = "rbtnOthers";
            this.rbtnOthers.Size = new System.Drawing.Size(324, 52);
            this.rbtnOthers.TabIndex = 66;
            this.rbtnOthers.Text = "Others";
            this.rbtnOthers.TextColor = System.Drawing.Color.Black;
            this.rbtnOthers.UseVisualStyleBackColor = false;
            this.rbtnOthers.Click += new System.EventHandler(this.rbtnOthers_Click);
            // 
            // rbtnClose
            // 
            this.rbtnClose.BackColor = System.Drawing.Color.Red;
            this.rbtnClose.BackgroundColor = System.Drawing.Color.Red;
            this.rbtnClose.BorderColor = System.Drawing.Color.Red;
            this.rbtnClose.BorderRadius = 20;
            this.rbtnClose.BorderSize = 0;
            this.rbtnClose.FlatAppearance.BorderSize = 0;
            this.rbtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnClose.ForeColor = System.Drawing.Color.White;
            this.rbtnClose.Location = new System.Drawing.Point(130, 310);
            this.rbtnClose.Name = "rbtnClose";
            this.rbtnClose.Size = new System.Drawing.Size(159, 47);
            this.rbtnClose.TabIndex = 67;
            this.rbtnClose.Text = "Close";
            this.rbtnClose.TextColor = System.Drawing.Color.White;
            this.rbtnClose.UseVisualStyleBackColor = false;
            this.rbtnClose.Click += new System.EventHandler(this.rbtnClose_Click);
            // 
            // ReworkReason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 407);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReworkReason";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReworkReason";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private custom.controller.TM_RoundButton rbtnPartNotAvailable;
        private custom.controller.TM_RoundButton rbtnOthers;
        private custom.controller.TM_RoundButton rbtnPartDamaged;
        private custom.controller.TM_RoundButton rbtnClose;
    }
}