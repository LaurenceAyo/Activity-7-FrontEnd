using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ayo_Laurence_Act7_EDP;

namespace Ayo_Laurence_Act7_EDP
{
    public partial class frmLoginSignup : Form
    {
        public frmLoginSignup()
        {
            InitializeComponent();
            cmbRole.Items.Add("Student");
            cmbRole.Items.Add("Professor");
            cmbRole.Items.Add("Admin");
            cmbRole.SelectedIndex = 0; // Optional default
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get text from the textbox
            //string Username = username_string.Text;
            //string Password = password_string.Text;

            // Show the text in a message box
            frmMainDashboard dashboard = new frmMainDashboard(this);
            dashboard.Show();
            this.Hide();
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
                password_string.UseSystemPasswordChar = true;
                ShowPassword.Text = "Show Password";
                isPasswordShown = false;
            }
            else
            {
                // Show the password
                password_string.UseSystemPasswordChar = false;
                ShowPassword.Text = "Hide Password";
                isPasswordShown = true;
            }
        }
    }
}
