using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Ayo_Laurence_Act7_EDP
{
    public partial class frmEditStudent : Form
    {
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public int Age { get; private set; }

        public frmEditStudent(int studentId, string currentFName, string currentLName, int currentAge)
        {
            InitializeComponent();

            // Set current values
            txtFirstName.Text = currentFName;
            txtLastName.Text = currentLName;
            numAge.Value = currentAge;

            // Store student ID if needed
            // this.studentId = studentId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                LastName = txtLastName.Text;
                FirstName = txtFirstName.Text;
                Age = (int)numAge.Value;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidateInputs()
        {
            // Same validation as frmAddStudent
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter last name", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter first name", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (numAge.Value <= 0)
            {
                MessageBox.Show("Please enter valid age", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


       
    }
}

