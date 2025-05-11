using System;
using System.Windows.Forms;

namespace Ayo_Laurence_Act7_EDP
{
    public partial class frmMainDashboard : Form
    {
        private readonly Form _previousForm;

        public frmMainDashboard(Form previousForm)
        {
            InitializeComponent();
            _previousForm = previousForm;

            // Initialize ComboBox
            cmbForms.Items.AddRange(new object[] {
                "Student",
                "Professor",
                "Grades",
                "Courses",
                "Enrollment",
                "Attendance"
            });
            cmbForms.SelectedIndex = -1;
        }

        private void BtnProceed_Click(object sender, EventArgs e)
        {
            if (cmbForms.SelectedItem == null)
            {
                MessageBox.Show("Please select a Form first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form formToOpen = null;
            string selectedForm = cmbForms.SelectedItem.ToString();

            // Traditional switch statement for C# 7.3 compatibility
            switch (selectedForm)
            {
                case "Student":
                    formToOpen = new frmStudentManagement(this);
                    break;
                case "Professor":
                    formToOpen = new frmProfessorManagement();
                    break;
                case "Grades":
                    formToOpen = new frmGrades();
                    break;
                case "Courses":
                    formToOpen = new frmCourseManagement();
                    break;
                case "Enrollment":
                    formToOpen = new frmEnrollment();
                    break;
                case "Attendance":
                    formToOpen = new frmAttendance();
                    break;
            }

            if (formToOpen != null)
            {
                formToOpen.Show();
                this.Hide();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Return to login form
            ReturnToLogin();
        }

        private void ReturnToLogin()
        {
            // First make sure the login form exists and isn't disposed
            if (_previousForm != null && !_previousForm.IsDisposed)
            {
                // Show the login form
                _previousForm.Show();

                // Reset login form state if needed
                if (_previousForm is frmLoginSignup loginForm)
                {
                    loginForm.ResetForm(); // Add this method to your login form
                }

                // Close the dashboard
                this.Close();
            }
            else
            {
                // If login form was disposed, create a new one
                frmLoginSignup newLogin = new frmLoginSignup();
                newLogin.Show();
                this.Close();
            }
        }


        private void frmMainDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If user closes via X button, show login form
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (_previousForm != null && !_previousForm.IsDisposed)
                {
                    _previousForm.Show();
                }
            }
        }

        private void frmMainDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}