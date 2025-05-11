using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayo_Laurence_Act7_EDP
{
    public partial class frmGrades : Form
    {
        public frmGrades()
        {
            InitializeComponent();
        }
        private void LoadGradesData()
        {
            try
            {
                // Get data from database
                DataTable gradesTable = DBManager.GetGradesData();

                // Configure DataGridView
                gradesViewTable.AutoGenerateColumns = false;
                gradesViewTable.DataSource = gradesTable;

                // Clear existing columns
                gradesViewTable.Columns.Clear();

                // Add columns with proper formatting
                gradesViewTable.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "grade_id",
                    HeaderText = "Grade ID",
                    Name = "colGradeId",
                    Width = 80
                });

                gradesViewTable.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "student_id",
                    HeaderText = "Student ID",
                    Name = "colStudentId",
                    Width = 100
                });

                gradesViewTable.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "course_id",
                    HeaderText = "Course ID",
                    Name = "colCourseId",
                    Width = 100
                });

                gradesViewTable.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "grade",
                    HeaderText = "Grade",
                    Name = "colGrade",
                    Width = 80
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading grades: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void gradesViewTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Only handle clicks on valid rows (not header)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gradesViewTable.Rows[e.RowIndex];

                // Get the grade data
                string gradeId = row.Cells["colGradeId"].Value.ToString();
                string studentId = row.Cells["colStudentId"].Value.ToString();
                string courseId = row.Cells["colCourseId"].Value.ToString();
                string grade = row.Cells["colGrade"].Value.ToString();

                // Example: Show details when clicked
                MessageBox.Show($"Grade ID: {gradeId}\nStudent: {studentId}\nCourse: {courseId}\nGrade: {grade}",
                              "Grade Details",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            }

        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            LoadGradesData();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            frmMainDashboard mainDashboard = new frmMainDashboard(this);
            mainDashboard.Show();
            this.Close();
        }
    }
}
