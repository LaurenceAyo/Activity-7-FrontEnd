using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ayo_Laurence_Act7_EDP;
using MySql.Data.MySqlClient;

namespace Ayo_Laurence_Act7_EDP
{
    public partial class frmLoginSignup : Form
    {
        public frmLoginSignup()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password are required!");
                return;
            }

            // Authenticate user
            var (success, user) = DBManager.AuthenticateUser(username, password);

            if (success)
            {
                // Login successful
                frmMainDashboard dashboard = new frmMainDashboard(this);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials", "Login Failed",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void role(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private bool isPasswordShown = false;
        private void ShowPassword_Click(object sender, EventArgs e)
        {
            if (isPasswordShown)
            {
                // Hide the password
                txtPassword.UseSystemPasswordChar = true;
                ShowPassword.Text = "Show Password";
                isPasswordShown = false;
            }
            else
            {
                // Show the password
                txtPassword.UseSystemPasswordChar = false;
                ShowPassword.Text = "Hide Password";
                isPasswordShown = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtPasswod(object sender, EventArgs e)
        {

        }

        private void txtUsernme(object sender, EventArgs e)
        {

        }

        private void password_string_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            // Create and show the account creation form
            frmCreateAccount createAccountForm = new frmCreateAccount();
            createAccountForm.Show();
        }

        public void ResetForm()
        {
            // Clear any existing inputs
            txtUsername.Text = "";
            txtPassword.Text = "";

            // Reset focus
            txtUsername.Focus();

            // Optional: Reset any other state
            // errorLabel.Visible = false;
        }
    }
}
