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
    public partial class AnswerMePrompt : Form
    {
        public AnswerMePrompt()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void answerToQuestion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void submitAnswerBtn_Click(object sender, EventArgs e)
        {
            string userAnswer = answerToQuestion.Text.Trim();

            if (userAnswer.Equals("Emilio Aguinaldo", StringComparison.OrdinalIgnoreCase) ||
                userAnswer.Equals("Emilio", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Accepted!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("User: Admin\nPassword: password123", "Credentials", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Proceed to main application form if needed
                // var mainForm = new frmMain();
                // mainForm.Show();
                // this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Return to splash screen
                this.Hide();
                var splashScreen = new frmSplashScreen();
                splashScreen.Show();
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            // Return to splash screen
            this.Hide();
            var splashScreen = new frmSplashScreen();
            splashScreen.Show();
        }
    }
}
