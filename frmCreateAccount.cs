using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ayo_Laurence_Act7_EDP
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private string GetConnectionString()
        {
            try
            {
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["MyDB"];
                if (settings == null)
                {
                    throw new Exception("MyDB connection string not found in app.config");
                }
                return settings.ConnectionString;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Configuration Error: {ex.Message}");
                return null;
            }
        }

        private void saveAccountbtn_Click(object sender, EventArgs e)
        {
            // 1. Get inputs
            string username = accountName.Text.Trim();
            string password = accountPassword.Text;

            // 2. Validate
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password are required!");
                return;
            }

            // 3. Test connection first
            if (!DBManager.TestConnection())
            {
                MessageBox.Show("Cannot connect to database. Check if MySQL is running on port 3307.");
                return;
            }

            // 4. Create account
            try
            {
                bool success = DBManager.CreateAdminAccount(username, password);
                MessageBox.Show(success ? "Admin account created!" : "Failed to create account");
                if (success) { accountName.Clear(); accountPassword.Clear(); }
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Username already exists!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            // Create an instance of the login/signup form
            frmLoginSignup loginSignupForm = new frmLoginSignup();

            // Show the login/signup form
            loginSignupForm.Show();

            // Close the current form
            this.Close();
        }
    }
}

