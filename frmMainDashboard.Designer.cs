using System;
using System.Windows.Forms;

namespace Ayo_Laurence_Act7_EDP
{
    partial class frmMainDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbForms;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbForms = new System.Windows.Forms.ComboBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbForms
            // 
            this.cmbForms.FormattingEnabled = true;
            this.cmbForms.Location = new System.Drawing.Point(440, 216);
            this.cmbForms.Name = "cmbForms";
            this.cmbForms.Size = new System.Drawing.Size(162, 24);
            this.cmbForms.TabIndex = 11;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.YellowGreen;
            this.btnProceed.Location = new System.Drawing.Point(469, 263);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(101, 41);
            this.btnProceed.TabIndex = 10;
            this.btnProceed.Text = "Confirm";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.BtnProceed_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Information System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(422, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Form to Access";
            // 
            // frmMainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cmbForms);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMainDashboard";
            this.Text = "Main Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}