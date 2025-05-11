using MySql.Data.MySqlClient;
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
    public partial class frmStudentManagement : Form
    {
        private readonly string connectionString = "server=localhost;database=block_b;uid=root;pwd=laurenceayo25;port=3307";
        private readonly Form previousForm;

        public frmStudentManagement(Form prev)
        {
            InitializeComponent();
            previousForm = prev;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void gotoStudents_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                DataTable dtStudents = new DataTable();

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "SELECT student_id AS ID, L_name AS 'Last Name', " +
                                 "F_name AS 'First Name', age AS Age FROM students";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtStudents.Load(reader);
                }
                dataGridView1.DataSource = dtStudents;

                dataGridView1.Columns["ID"].Width = 60;
                dataGridView1.Columns["Age"].Width = 50;

                dataGridView1.RowHeadersWidth = 50;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}\n\n" +
                               "Please check:\n" +
                               "1. MySQL service is running\n" +
                               "2. Your connection string\n" +
                               "3. Table structure matches expected format",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Ignore header clicks
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var addForm = new frmAddStudent())
                {
                    if (addForm.ShowDialog() == DialogResult.OK)
                    {
                        using (var conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();
                            var cmd = new MySqlCommand(
                                "INSERT INTO students (L_name, F_name, age) VALUES (@lname, @fname, @age)",
                                conn);

                            cmd.Parameters.AddWithValue("@lname", addForm.LastName);
                            cmd.Parameters.AddWithValue("@fname", addForm.FirstName);
                            cmd.Parameters.AddWithValue("@age", addForm.Age);

                            cmd.ExecuteNonQuery();
                        }
                        RefreshStudentGrid();
                        MessageBox.Show("Student added successfully!", "Success",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding student: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student first.", "No Selection",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int studentId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                using (var editForm = new frmEditStudent(
                    studentId,
                    selectedRow.Cells["First Name"].Value.ToString(),
                    selectedRow.Cells["Last Name"].Value.ToString(),
                    Convert.ToInt32(selectedRow.Cells["Age"].Value)))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        using (var conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();
                            var cmd = new MySqlCommand(
                                "UPDATE students SET F_name = @fname, L_name = @lname, age = @age " +
                                "WHERE student_id = @id", conn);

                            cmd.Parameters.AddWithValue("@fname", editForm.FirstName);
                            cmd.Parameters.AddWithValue("@lname", editForm.LastName);
                            cmd.Parameters.AddWithValue("@age", editForm.Age);
                            cmd.Parameters.AddWithValue("@id", studentId);

                            cmd.ExecuteNonQuery();
                        }
                        RefreshStudentGrid();
                        MessageBox.Show("Update successful!", "Success",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating student: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student first.", "No Selection",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedRow = dataGridView1.SelectedRows[0];
            string fullName = $"{selectedRow.Cells["First Name"].Value} {selectedRow.Cells["Last Name"].Value}";

            if (MessageBox.Show($"Delete {fullName}? This cannot be undone.", "Confirm Deletion",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int studentId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                    using (var conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        var cmd = new MySqlCommand(
                            "DELETE FROM students WHERE student_id = @id", conn);
                        cmd.Parameters.AddWithValue("@id", studentId);

                        int affected = cmd.ExecuteNonQuery();
                        if (affected > 0)
                        {
                            RefreshStudentGrid();
                            MessageBox.Show("Student deleted successfully.", "Success",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}\n\n" +
                                  "Student might be enrolled in courses.",
                                  "Deletion Failed",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting student: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            MessageBox.Show("Selection cleared.", "Info",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RefreshStudentGrid()
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    var adapter = new MySqlDataAdapter(
                        "SELECT student_id AS ID, L_name AS 'Last Name', F_name AS 'First Name', age AS Age FROM students", conn);
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmStudentManagement_Load(object sender, EventArgs e)
        {
           // dataGridView1.AutoGenerateColumns = false; // Add this line
            RefreshStudentGrid();
            // Load professor list when form loads
            LoadProfessorList();
        }

        private void LoadProfessorList()
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    var adapter = new MySqlDataAdapter("SELECT prof_id, F_name FROM professors", conn);
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind the DataTable to the ComboBox
                    showProfList.DataSource = dt;
                    showProfList.DisplayMember = "F_name";  // What to display
                    showProfList.ValueMember = "prof_id";   // Hidden value
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading professors: {ex.Message}\n\n" +
                              "Please verify:\n" +
                              "1. The 'professors' table exists\n" +
                              "2. It contains 'prof_id' and 'F_name' columns\n" +
                              "3. Database connection is valid",
                              "Database Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }




        // Helper class remains the same
        public class ProfessorItem
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public ProfessorItem(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public override string ToString() => Name;
        }

        private void updateButton_Click_1(object sender, EventArgs e)
        {
            // Redirect to EditStudent form
            UpdateButton_Click(sender, e);

        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            // Redirect to AddStudent form
          //  AddButton_Click(sender, e);

            using (var addForm = new frmAddStudent())
            {
                // Set the owner before showing the form
                addForm.Owner = this;

                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // These properties should exist in frmAddStudent
                    AddNewStudent(addForm.FirstName, addForm.LastName, addForm.Age);
                    RefreshStudentGrid();
                }
            }
        }

        public void AddNewStudent(string firstName, string lastName, int age)
        {
            try
            {
                // Add to database first
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new MySqlCommand(
                        "INSERT INTO students (F_name, L_name, age) VALUES (@fname, @lname, @age)",
                        conn);

                    cmd.Parameters.AddWithValue("@fname", firstName);
                    cmd.Parameters.AddWithValue("@lname", lastName);
                    cmd.Parameters.AddWithValue("@age", age);

                    cmd.ExecuteNonQuery();
                }

                // Refresh the grid from database
                RefreshStudentGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving student: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; // Re-throw to let the calling form handle it
            }
        }


        private void NameOfStudent_TextChanged(object sender, EventArgs e)
        {
            // Filter students based on name input
            if (dataGridView1.DataSource is DataTable dt)
            {
                string filter = NameOfStudent.Text.Trim();
                if (!string.IsNullOrEmpty(filter))
                {
                    dt.DefaultView.RowFilter = $"`First Name` LIKE '%{filter}%' OR `Last Name` LIKE '%{filter}%'";
                }
                else
                {
                    dt.DefaultView.RowFilter = string.Empty;
                }
            }
        }

        private void AgeValue_TextChanged(object sender, EventArgs e)
        {
            // Validate and filter by age if it's a number
            if (dataGridView1.DataSource is DataTable dt)
            {
                if (int.TryParse(AgeValue.Text, out int age))
                {
                    dt.DefaultView.RowFilter = $"Age = {age}";
                }
                else if (string.IsNullOrEmpty(AgeValue.Text))
                {
                    dt.DefaultView.RowFilter = string.Empty;
                }
            }
        }

        private void grade_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(grade.Text))
            {
                // Check if input is a valid decimal number
                if (decimal.TryParse(grade.Text, out decimal gradeValue))
                {
                    // Validate grade range (1.0 to 5.0)
                    if (gradeValue < 1.0m || gradeValue > 5.0m)
                    {
                        MessageBox.Show("Grade must be between 1.0 and 5.0", "Invalid Input",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        grade.Text = string.Empty;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please enter a numeric value (e.g., 1.5, 2.75, etc.)", "Invalid Input",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grade.Text = string.Empty;
                }
            }
        }

        // Handle selection changes
        private void showProfList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This is the only change needed to fix the casting error
            if (showProfList.SelectedItem is DataRowView selectedRow)
            {
                try
                {
                    int professorId = Convert.ToInt32(selectedRow["prof_id"]);
                    string professorName = selectedRow["F_name"].ToString();

                    // Your existing logic here (without the MessageBox example)
                    // ... rest of your original code ...
                }
                catch (Exception ex)
                {
                    // Your existing error handling
                    MessageBox.Show($"Error processing selection: {ex.Message}",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }
        }



        private void toDatabasebbtn_Click(object sender, EventArgs e)
        {
            // Save all new data to database
            try
            {
                // Example implementation - you'll need to adapt this to your specific needs
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Example: Save student data if modified
                    if (dataGridView1.DataSource is DataTable dt && dt.GetChanges() != null)
                    {
                        var adapter = new MySqlDataAdapter(
                            "SELECT student_id AS ID, L_name AS 'Last Name', F_name AS 'First Name', age AS Age FROM students", conn);
                        var builder = new MySqlCommandBuilder(adapter);
                        adapter.Update(dt);
                    }

                    // Add other data saving logic here as needed

                    MessageBox.Show("All data saved to database successfully!", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data to database: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportDatabasebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource is DataTable data)
            {
                ExcelExporter.ExportToExcel(data, "Students");
            }
            else
            {
                MessageBox.Show("No data to export", "Warning",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource is DataTable dt)
            {
                string filter = $"CONVERT([ID], System.String) LIKE '%{txtSearch.Text}%' OR " +
                               $"[First Name] LIKE '%{txtSearch.Text}%' OR " +
                               $"[Last Name] LIKE '%{txtSearch.Text}%'";

                dt.DefaultView.RowFilter = filter;
            }
        }
    }
}