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
    public partial class frmAttendance : Form
    {
        public frmAttendance()
        {
            InitializeComponent();
        }

        private void frmAttendance_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            frmMainDashboard mainDashboard = new frmMainDashboard(this);
            mainDashboard.Show();
            this.Close();
        }

        private void LoadAttendanceData()
        {
            try
            {
                // Get data from database
                DataTable attendanceData = DBManager.GetAttendanceData();

                // Configure DataGridView
                attendanceTable.AutoGenerateColumns = false;
                attendanceTable.DataSource = attendanceData;

                // Clear existing columns
                attendanceTable.Columns.Clear();

                // Add columns with formatting
                attendanceTable.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "attendance_id",
                    HeaderText = "Attendance ID",
                    Name = "colAttendanceId",
                    Width = 100,
                    ReadOnly = true
                });

                attendanceTable.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "student_id",
                    HeaderText = "Student ID",
                    Name = "colStudentId",
                    Width = 100
                });

                attendanceTable.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "course_id",
                    HeaderText = "Course ID",
                    Name = "colCourseId",
                    Width = 100
                });

                attendanceTable.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "formatted_date",
                    HeaderText = "Date/Time",
                    Name = "colDateLog",
                    Width = 150
                });

                attendanceTable.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "current_status",
                    HeaderText = "Status",
                    Name = "colStatus",
                    Width = 100
                });

                // Enable sorting
                foreach (DataGridViewColumn column in attendanceTable.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }

                // Set selection mode
                attendanceTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                attendanceTable.MultiSelect = false;

                // Style the status column
                attendanceTable.Columns["colStatus"].DefaultCellStyle.ForeColor = Color.White;
                attendanceTable.Columns["colStatus"].DefaultCellStyle.BackColor = Color.DodgerBlue;
                attendanceTable.Columns["colStatus"].DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading attendance: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void attendanceTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Only handle clicks on data rows (not header)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = attendanceTable.Rows[e.RowIndex];

                // Get attendance data
                string attendanceId = row.Cells["colAttendanceId"].Value?.ToString();
                string studentId = row.Cells["colStudentId"].Value?.ToString();
                string courseId = row.Cells["colCourseId"].Value?.ToString();
                string dateLog = row.Cells["colDateLog"].Value?.ToString();
                string status = row.Cells["colStatus"].Value?.ToString();

                // Example: Show details when clicked
                string message = $"Attendance ID: {attendanceId}\n" +
                               $"Student ID: {studentId}\n" +
                               $"Course ID: {courseId}\n" +
                               $"Date: {dateLog}\n" +
                               $"Status: {status}";

                MessageBox.Show(message, "Attendance Record",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);

                
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadAttendanceData();
        }
    }
}
