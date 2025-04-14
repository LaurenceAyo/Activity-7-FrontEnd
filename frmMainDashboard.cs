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
    public partial class frmMainDashboard : Form
    {
        Form previousForm;
        public frmMainDashboard(Form prev)
        {
            InitializeComponent();
            previousForm = prev;

            // Set ComboBox items (you can also do this in frmMainDashboard_Load)
            cmbForms.Items.Clear();
            cmbForms.Items.Add("Student");
            cmbForms.Items.Add("Professor");
            cmbForms.Items.Add("Grades");
            cmbForms.Items.Add("Courses");
            cmbForms.Items.Add("Enrollment");
            cmbForms.Items.Add("Attendance");
            cmbForms.SelectedIndex = -1; // Ensure no role is selected by default
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            string selectedRole = cmbForms.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Please select a Form first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (selectedRole.ToLower())
            {
                case "student":
                    new frmStudentManagement(this).Show();
                    break;
                case "professor":
                    new frmProfessorManagement().Show();
                    break;
                case "grades":
                    new frmGrades().Show();
                    break;
                case "courses":
                    new frmCourseManagement().Show();
                    break;
                case "enrollment":
                    new frmEnrollment().Show();
                    break;
                case "attendance":
                    new frmAttendance().Show(); 
                    break;
                default:
                    MessageBox.Show("Invalid role selected.");
                    return;
            }

            this.Hide(); // Optional: hides current form after redirect
        }

        private void button1_Click(object sender, EventArgs e)
        {
            previousForm.Show(); // Show the form that opened this one
            this.Close();
        }

        
    }
}