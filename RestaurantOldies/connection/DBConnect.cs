using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RestaurantOldies
{
    public class DBConnect
    {
        public MySqlConnection connection { set; get; }
        private string server;
        private string database;
        private string uid;
        private string password;
        private string connectionString;

        public DBConnect()
        {
            Initialize();
        }



        private void Initialize()
        {
            server = "localhost";
            database = "restaurant_oldies";
            uid = "root";
            password = "root@123";

            connectionString = "server=" + server + ";" + "uid=" +
            uid + ";" + "pwd=" + password + ";" + "database=" + database + ";";

            connection = new MySqlConnection();
            connection.ConnectionString = connectionString;

            /* TEST CONNECTION
            try
            {
                connection.Open();
                Console.WriteLine("conexiune deschisa");
            }
            catch
            {
                Console.WriteLine("conexiune esuata");
            }
            finally
            {
                connection.Close();
            }
            */
        }

        public void Open()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connection open\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection open error:\n" + ex.Message + "\n");
            }
            
        }

        public void Close()
        {
            if (connection != null)
            {
                connection.Close();
                Console.WriteLine("Connection close\n");
            }
        }
    }
}
