namespace Ayo_Laurence_Act7_EDP
{
    partial class frmEnrollment
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.enrolledStudentsTable = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.enrolledStudentsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(275, 134);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(178, 24);
            this.comboBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name of Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "ENROLL STUDENT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // enrolledStudentsTable
            // 
            this.enrolledStudentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enrolledStudentsTable.Location = new System.Drawing.Point(32, 211);
            this.enrolledStudentsTable.Name = "enrolledStudentsTable";
            this.enrolledStudentsTable.RowHeadersWidth = 51;
            this.enrolledStudentsTable.RowTemplate.Height = 24;
            this.enrolledStudentsTable.Size = new System.Drawing.Size(939, 316);
            this.enrolledStudentsTable.TabIndex = 5;
            this.enrolledStudentsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.enrolledStudentsTable_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "ENROLLED STUDENTS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(377, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(437, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "OFFICIAL ENROLLMENT PAGE";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1000, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete Student";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(32, 40);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(192, 173);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(93, 23);
            this.refreshBtn.TabIndex = 10;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // frmEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 552);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enrolledStudentsTable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmEnrollment";
            this.Text = "frmEnrollment";
            ((System.ComponentModel.ISupportInitialize)(this.enrolledStudentsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView enrolledStudentsTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button refreshBtn;
    }
}