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
    public partial class frmCourseManagement : Form
    {
        public frmCourseManagement()
        {
            InitializeComponent();
        }

        private void LoadCoursesData()
        {
            try
            {
                // Get data from database
                DataTable coursesData = DBManager.GetAllCourses();

                // Configure DataGridView (not DataTable)
                coursesTable.AutoGenerateColumns = false;  // This is for DataGridView
                coursesTable.DataSource = coursesData;    // This is for DataGridView

                // Clear existing columns
                coursesTable.Columns.Clear();

                // Add columns to the DataGridView (not DataTable)
                coursesTable.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "course_id",
                    HeaderText = "Course ID",
                    Name = "colCourseId",
                    Width = 100,
                    ReadOnly = true
                });

                coursesTable.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "course_name",
                    HeaderText = "Course Name",
                    Name = "colCourseName",
                    Width = 200
                });

                coursesTable.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "professor_id",
                    HeaderText = "Professor ID",
                    Name = "colProfessorId",
                    Width = 100
                });

                // Enable sorting
                foreach (DataGridViewColumn column in coursesTable.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading courses: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void YourForm_Load(object sender, EventArgs e)
        {
            LoadCoursesData();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            frmMainDashboard mainDashboard = new frmMainDashboard(this);
            mainDashboard.Show();
            this.Close();
        }

        private void coursesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Only handle valid row clicks (not header)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = coursesTable.Rows[e.RowIndex];

                // Get course data
                string courseId = row.Cells["colCourseId"].Value.ToString();
                string courseName = row.Cells["colCourseName"].Value.ToString();
                string professorId = row.Cells["colProfessorId"].Value.ToString();

                // Example: Show details in MessageBox
                MessageBox.Show($"Course: {courseName}\nID: {courseId}\nProfessor ID: {professorId}",
                              "Course Details",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);

                // Alternatively: Open an edit form
                // var editForm = new EditCourseForm(courseId);
                // editForm.ShowDialog();
                // LoadCoursesData(); // Refresh after editing
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadCoursesData();
        }
    }
}
