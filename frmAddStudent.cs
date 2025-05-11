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
    public partial class frmAddStudent : Form
    {
        // Public properties to access the input values
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public int Age { get; private set; }
        

        public frmAddStudent()
        {
            InitializeComponent();
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

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendToGridViewbtn_Click_1(object sender, EventArgs e)
        {
           
            }

        private void sendToGridViewbtn_Click(object sender, EventArgs e)
        {

            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter both first and last name", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get the owner form (frmStudentManagement)
                if (this.Owner is frmStudentManagement studentManagementForm)
                {
                    // Pass the data to the main form
                    this.FirstName = txtFirstName.Text.Trim();
                    this.LastName = txtLastName.Text.Trim();
                    this.Age = (int)numAge.Value;

                    // Set dialog result and close
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cannot find the parent student management form", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving student data: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
 
