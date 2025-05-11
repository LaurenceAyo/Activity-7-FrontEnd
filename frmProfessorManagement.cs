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
    public partial class frmProfessorManagement : Form
    {
        public frmProfessorManagement()
        {
            InitializeComponent();
        }


        private void LoadProfessorsData()
        {
            try
            {
                // Get data from database
                DataTable professorsTable = DBManager.GetAllProfessors();

                // Configure DataGridView
                profListView.AutoGenerateColumns = false;
                profListView.DataSource = professorsTable;

                // Clear existing columns if any
                profListView.Columns.Clear();

                // Add columns manually for better control
                profListView.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "prof_id",
                    HeaderText = "Professor ID",
                    Name = "colProfId",
                    Width = 100
                });

                profListView.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "F_name",
                    HeaderText = "First Name",
                    Name = "colFName",
                    Width = 150
                });

                profListView.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "handled_subject",
                    HeaderText = "Subject",
                    Name = "colSubject",
                    Width = 200
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading professors: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void profListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell clicks if needed
            if (e.RowIndex >= 0) // Ensure not clicking header
            {
                DataGridViewRow row = profListView.Rows[e.RowIndex];
                string profId = row.Cells["colProfId"].Value.ToString();
                // Add your click handling logic here
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            LoadProfessorsData();
        }

        private void goBackbtn_Click(object sender, EventArgs e)
        {
            try
            {
                frmMainDashboard mainDashboard = new frmMainDashboard(this);
                mainDashboard.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reopening dashboard: {ex.Message}");
            }
        }
    }
}
