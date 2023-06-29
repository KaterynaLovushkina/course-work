using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp2.Helper
{
      static class DB
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;
     


        public static void EstablishConnection()

        {
            
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "192.168.1.100";
                builder.Port = 3306;
                builder.UserID = "my-last-user";
                builder.Password = "root1212";
                builder.Database = "curs_work";
                builder.SslMode = MySqlSslMode.None;
                connection = new MySqlConnection(builder.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating table: " + ex.Message);
            }


        }
        public static void CreateTableSensors()
        {
            try
            {
                string query = "CREATE TABLE IF NOT EXISTS sensor_data " +
                    "(id INT AUTO_INCREMENT PRIMARY KEY," +
                    " humidity FLOAT," +
                    " temp FLOAT, " +
                    "moisture FLOAT," +
                    " ph FLOAT," +
                    " pK FLOAT," +
                    " pAtm FLOAT)";

                connection.Open();
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating table: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void CreateTableUsers()
        {
            try
            {
                string query = "CREATE TABLE IF NOT EXISTS users " +
                    "(   id INT AUTO_INCREMENT PRIMARY KEY," +
                    "    username VARCHAR(255) NOT NULL," +
                    "   password VARCHAR(255) NOT NULL," +
                    "    isAdmin BOOLEAN DEFAULT FALSE," +
                    "   country VARCHAR(255))";

                connection.Open();
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating table: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void InsertDataSensors(float humidity, float temp, float moisture, float ph, float pk, float patm)
        {
            
            try
            {
                string query = "INSERT INTO curs_work.sensor_data (humidity, temp, moisture, ph, pk, patm) " +
                    "VALUES (@humidity, @temp, @moisture, @ph, @pk, @patm)";
                connection.Open();
                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@humidity", humidity);
                cmd.Parameters.AddWithValue("@temp", temp);
                cmd.Parameters.AddWithValue("@moisture", moisture);
                cmd.Parameters.AddWithValue("@ph", ph);
                cmd.Parameters.AddWithValue("@pk", pk);
                cmd.Parameters.AddWithValue("@patm", patm);
                cmd.ExecuteNonQuery();

               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void InsertDataUsers(string username, string password,bool isAdmin, string country)
        {
            try
            {
                string query = "INSERT INTO curs_work.users (username, password, isAdmin, country) " +
                    "VALUES (@username, @password, @isAdmin, @country)";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@isAdmin", isAdmin); // Set isAdmin to false
                cmd.Parameters.AddWithValue("@country", country);
                cmd.ExecuteNonQuery();

                // Optional: Display a success message
                MessageBox.Show("Data inserted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
        public static bool CheckCredentials(string username, string password)
        {
            bool isAuthenticated = false;

            try
            {
                EstablishConnection(); // Ensure the connection is established

                string query = "SELECT COUNT(*) FROM curs_work.users WHERE username = @username AND password = @password";
                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                connection.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    // The credentials are valid
                    isAuthenticated = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking credentials: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isAuthenticated;
        }
        public static bool IsAdmin(string username, string password)
        {
            try
            {
                string query = "SELECT isAdmin FROM curs_work.users WHERE username = @username AND password = @password";
                connection.Open();
                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    bool isAdmin = Convert.ToBoolean(result);
                    return isAdmin;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking admin status: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return false; // Default to non-admin
        }







    }

}
