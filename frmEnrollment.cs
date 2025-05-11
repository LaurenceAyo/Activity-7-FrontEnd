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
    public partial class frmEnrollment : Form
    {
        public frmEnrollment()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            frmMainDashboard mainDashboard = new frmMainDashboard(this);
            mainDashboard.Show();
            this.Close();
        }
        private void LoadEnrollmentsData()
        {
            try
            {
                // Get data from database
                DataTable enrollmentsData = DBManager.GetEnrollmentsData();

                // Configure DataGridView
                enrolledStudentsTable.AutoGenerateColumns = false;
                enrolledStudentsTable.DataSource = enrollmentsData;

                // Clear existing columns
                enrolledStudentsTable.Columns.Clear();

                // Add columns with formatting
                enrolledStudentsTable.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "enrollment_id",
                    HeaderText = "Enrollment ID",
                    Name = "colEnrollmentId",
                    Width = 120,
                    ReadOnly = true
                });

                enrolledStudentsTable.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "student_id",
                    HeaderText = "Student ID",
                    Name = "colStudentId",
                    Width = 100
                });

                enrolledStudentsTable.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "course_id",
                    HeaderText = "Course ID",
                    Name = "colCourseId",
                    Width = 100
                });

                // Enable sorting
                foreach (DataGridViewColumn column in enrolledStudentsTable.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }

                // Set selection mode
                enrolledStudentsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                enrolledStudentsTable.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading courses: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void enrolledStudentsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Only handle clicks on data rows (not header)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = enrolledStudentsTable.Rows[e.RowIndex];

                // Get enrollment data
                string enrollmentId = row.Cells["colEnrollmentId"].Value?.ToString();
                string studentId = row.Cells["colStudentId"].Value?.ToString();
                string courseId = row.Cells["colCourseId"].Value?.ToString();

                // Example: Show details when clicked
                MessageBox.Show($"Enrollment ID: {enrollmentId}\nStudent ID: {studentId}\nCourse ID: {courseId}",
                              "Enrollment Details",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);

                // You could also open an edit form here:
                // var editForm = new EditEnrollmentForm(enrollmentId);
                // editForm.ShowDialog();
                // LoadEnrollmentsData(); // Refresh after editing
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadEnrollmentsData();
        }
    }
}
