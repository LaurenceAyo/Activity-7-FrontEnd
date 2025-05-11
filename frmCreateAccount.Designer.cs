namespace Ayo_Laurence_Act7_EDP
{
    partial class frmCreateAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accountName = new System.Windows.Forms.TextBox();
            this.accountPassword = new System.Windows.Forms.TextBox();
            this.saveAccountbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Password";
            // 
            // accountName
            // 
            this.accountName.Location = new System.Drawing.Point(254, 154);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(295, 22);
            this.accountName.TabIndex = 2;
            // 
            // accountPassword
            // 
            this.accountPassword.Location = new System.Drawing.Point(254, 241);
            this.accountPassword.Name = "accountPassword";
            this.accountPassword.Size = new System.Drawing.Size(295, 22);
            this.accountPassword.TabIndex = 3;
            // 
            // saveAccountbtn
            // 
            this.saveAccountbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveAccountbtn.Location = new System.Drawing.Point(314, 280);
            this.saveAccountbtn.Name = "saveAccountbtn";
            this.saveAccountbtn.Size = new System.Drawing.Size(158, 51);
            this.saveAccountbtn.TabIndex = 4;
            this.saveAccountbtn.Text = "Submit";
            this.saveAccountbtn.UseVisualStyleBackColor = false;
            this.saveAccountbtn.Click += new System.EventHandler(this.saveAccountbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 70.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 132);
            this.label3.TabIndex = 5;
            this.label3.Text = "{";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 70.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 132);
            this.label4.TabIndex = 6;
            this.label4.Text = "}";
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(347, 348);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(96, 23);
            this.backbtn.TabIndex = 7;
            this.backbtn.Text = "back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // frmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveAccountbtn);
            this.Controls.Add(this.accountPassword);
            this.Controls.Add(this.accountName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCreateAccount";
            this.Text = "CreateAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accountName;
        private System.Windows.Forms.TextBox accountPassword;
        private System.Windows.Forms.Button saveAccountbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backbtn;
    }
}