namespace Ayo_Laurence_Act7_EDP
{
    partial class frmStudentManagement
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
            this.toDatabasebbtn = new System.Windows.Forms.Button();
            this.gotoStudents = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Student_Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.showProfList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.TextBox();
            this.AgeValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameOfStudent = new System.Windows.Forms.TextBox();
            this.exportDatabasebtn = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "STUDENT MANAGEMENT";
            // 
            // toDatabasebbtn
            // 
            this.toDatabasebbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toDatabasebbtn.Location = new System.Drawing.Point(815, 124);
            this.toDatabasebbtn.Margin = new System.Windows.Forms.Padding(4);
            this.toDatabasebbtn.Name = "toDatabasebbtn";
            this.toDatabasebbtn.Size = new System.Drawing.Size(147, 38);
            this.toDatabasebbtn.TabIndex = 5;
            this.toDatabasebbtn.Text = "Submit to Database";
            this.toDatabasebbtn.UseVisualStyleBackColor = false;
            this.toDatabasebbtn.Click += new System.EventHandler(this.toDatabasebbtn_Click);
            // 
            // gotoStudents
            // 
            this.gotoStudents.Location = new System.Drawing.Point(55, 209);
            this.gotoStudents.Name = "gotoStudents";
            this.gotoStudents.Size = new System.Drawing.Size(135, 46);
            this.gotoStudents.TabIndex = 11;
            this.gotoStudents.Text = "Show Student List";
            this.gotoStudents.UseVisualStyleBackColor = true;
            this.gotoStudents.Click += new System.EventHandler(this.gotoStudents_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(642, 181);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(107, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_Names,
            this.Age,
            this.Grades});
            this.dataGridView1.Location = new System.Drawing.Point(208, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(428, 316);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Student_Names
            // 
            this.Student_Names.HeaderText = "Student Names";
            this.Student_Names.MinimumWidth = 6;
            this.Student_Names.Name = "Student_Names";
            this.Student_Names.Width = 125;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.Width = 125;
            // 
            // Grades
            // 
            this.Grades.HeaderText = "Grades";
            this.Grades.MinimumWidth = 6;
            this.Grades.Name = "Grades";
            this.Grades.Width = 125;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(642, 227);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(107, 23);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click_1);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(642, 269);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(107, 23);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(914, 25);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(8);
            this.button5.Size = new System.Drawing.Size(113, 41);
            this.button5.TabIndex = 17;
            this.button5.Text = "Go Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // showProfList
            // 
            this.showProfList.FormattingEnabled = true;
            this.showProfList.Location = new System.Drawing.Point(591, 132);
            this.showProfList.Name = "showProfList";
            this.showProfList.Size = new System.Drawing.Size(158, 24);
            this.showProfList.TabIndex = 9;
            this.showProfList.SelectedIndexChanged += new System.EventHandler(this.showProfList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Assigned Professors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Grades";
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(471, 134);
            this.grade.Margin = new System.Windows.Forms.Padding(4);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(97, 22);
            this.grade.TabIndex = 6;
            this.grade.Text = "i.e. 1.3";
            this.grade.TextChanged += new System.EventHandler(this.grade_TextChanged);
            // 
            // AgeValue
            // 
            this.AgeValue.Location = new System.Drawing.Point(348, 134);
            this.AgeValue.Name = "AgeValue";
            this.AgeValue.Size = new System.Drawing.Size(100, 22);
            this.AgeValue.TabIndex = 8;
            this.AgeValue.TextChanged += new System.EventHandler(this.AgeValue_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name of Student (FN, M.I., LN)";
            // 
            // NameOfStudent
            // 
            this.NameOfStudent.Location = new System.Drawing.Point(55, 135);
            this.NameOfStudent.Margin = new System.Windows.Forms.Padding(4);
            this.NameOfStudent.Name = "NameOfStudent";
            this.NameOfStudent.Size = new System.Drawing.Size(264, 22);
            this.NameOfStudent.TabIndex = 1;
            this.NameOfStudent.Text = "i.e. Juan Dela Cruz";
            this.NameOfStudent.TextChanged += new System.EventHandler(this.NameOfStudent_TextChanged);
            // 
            // exportDatabasebtn
            // 
            this.exportDatabasebtn.BackColor = System.Drawing.Color.Gainsboro;
            this.exportDatabasebtn.Location = new System.Drawing.Point(815, 215);
            this.exportDatabasebtn.Name = "exportDatabasebtn";
            this.exportDatabasebtn.Size = new System.Drawing.Size(147, 35);
            this.exportDatabasebtn.TabIndex = 18;
            this.exportDatabasebtn.Text = "Export Database";
            this.exportDatabasebtn.UseVisualStyleBackColor = false;
            this.exportDatabasebtn.Click += new System.EventHandler(this.exportDatabasebtn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(443, 181);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(193, 22);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.Text = "Filter here";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Search from List";
            // 
            // frmStudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.exportDatabasebtn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.gotoStudents);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.showProfList);
            this.Controls.Add(this.AgeValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.toDatabasebbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameOfStudent);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStudentManagement";
            this.Text = "frmStudentManagement";
            this.Load += new System.EventHandler(this.frmStudentManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button toDatabasebbtn;
        private System.Windows.Forms.Button gotoStudents;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grades;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox showProfList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox grade;
        private System.Windows.Forms.TextBox AgeValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameOfStudent;
        private System.Windows.Forms.Button exportDatabasebtn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
    }
}