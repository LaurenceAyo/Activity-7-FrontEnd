using MySql.Data.MySqlClient;

namespace Ayo_Laurence_Act7_EDP
{
    public class DBConnection
    {
        private static string connectionString = "server=localhost;database=block_b_DB;uid=root;pwd=password123;";
        private static MySqlConnection connection = new MySqlConnection(connectionString);

        public static MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}