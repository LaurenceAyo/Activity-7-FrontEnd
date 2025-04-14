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
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of frmMainDashboard
            frmMainDashboard mainDashboard = new frmMainDashboard(this);

            // Show the main dashboard form
            mainDashboard.Show();

            // Optionally, hide or close the current splash screen
            this.Hide(); // Use this.Close() if you want to close the form instead
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of frmLoginSignup
             frmLoginSignup loginSignup = new frmLoginSignup();

            // Show the login/signup form
            loginSignup.Show();

            // Optionally, hide or close the current splash screen
            this.Hide(); // Use this.Close() if you want to close the form instead
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}