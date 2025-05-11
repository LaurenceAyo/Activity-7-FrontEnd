using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
namespace Ayo_Laurence_Act7_EDP
{
    public static class DBManager
    {
        public class User
        {
            public int UserId { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
            public string Role { get; set; }
        }

        private static string GetConnectionString()
        {
            var connString = ConfigurationManager.ConnectionStrings["mysql80"]?.ConnectionString;
            return connString ?? throw new Exception("Database connection string is missing in app.config");
        }

        public static (bool Success, User User) AuthenticateUser(string username, string password)
        {
            using (var conn = new MySqlConnection(GetConnectionString()))
            {
                string query = "SELECT user_id, username, email, role FROM users WHERE username = @username AND password = @password";

                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); // Plain text comparison

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (true, new User
                            {
                                UserId = reader.GetInt32("user_id"),
                                Username = reader["username"].ToString(),
                                Email = reader["email"].ToString(),
                                Role = reader["role"].ToString()
                            });
                        }
                    }
                }
            }
            return (false, null);
        }

        public static bool CreateAdminAccount(string username, string password)
        {
            const string email = "scienceUniversity@gmail.com";
            const string role = "admin";

            using (var conn = new MySqlConnection(GetConnectionString()))
            using (var cmd = new MySqlCommand(
                @"INSERT INTO users (username, password, email, role) 
                  VALUES (@username, @password, @email, @role)", conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@role", role);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static DataTable GetAllProfessors()
        {
            DataTable dt = new DataTable();

            using (var conn = new MySqlConnection(GetConnectionString()))
            {
                string query = "SELECT prof_id, F_name, handled_subject FROM professors";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                conn.Open();
                adapter.Fill(dt);
            }

            return dt;
        }

        public static DataTable GetGradesData()
        {
            DataTable dt = new DataTable();

            using (var conn = new MySqlConnection(GetConnectionString()))
            {
                string query = "SELECT grade_id, student_id, course_id, grade FROM grades";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                conn.Open();
                adapter.Fill(dt);
            }

            return dt;
        }

        public static DataTable GetAllCourses()
        {
            DataTable dt = new DataTable();

            using (var conn = new MySqlConnection(GetConnectionString()))
            {
                string query = "SELECT course_id, course_name, professor_id FROM courses";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                conn.Open();
                adapter.Fill(dt);
            }

            return dt;
        }

        public static DataTable GetEnrollmentsData()
        {
            DataTable dt = new DataTable();

            using (var conn = new MySqlConnection(GetConnectionString()))
            {
                string query = "SELECT enrollment_id, student_id, course_id FROM enrollments";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                conn.Open();
                adapter.Fill(dt);
            }

            return dt;
        }

        public static DataTable GetAttendanceData()
        {
            DataTable dt = new DataTable();

            using (var conn = new MySqlConnection(GetConnectionString()))
            {
                string query = @"SELECT attendance_id, student_id, course_id, 
                        DATE_FORMAT(date_log, '%Y-%m-%d %H:%i') as formatted_date, 
                        current_status 
                        FROM attendance";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                conn.Open();
                adapter.Fill(dt);
            }

            return dt;
        }

        public static bool TestConnection()
        {
            try
            {
                using (var conn = new MySqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    return true;
                }
            }
            catch { return false; }
        }
    }
}