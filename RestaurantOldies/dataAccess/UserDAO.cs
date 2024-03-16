using MySql.Data.MySqlClient;
using RestaurantOldies.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOldies.dataAccess
{
    public class UserDAO : AbstractDAO<User>
    {

        public User GetById(int id)
        {
            try
            {
                dBConnect = new DBConnect();
                string query = "select * from `" + typeof(Item).Name.ToLower() + "` where id = @id";

                dBConnect.Open();
                MySqlCommand command = new MySqlCommand(query, dBConnect.connection);
                MySqlDataReader reader = command.ExecuteReader();

                command.Parameters.AddWithValue("@id", id);

                User user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4));
                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dBConnect.Close();
            }
            return null;
        }

        public User GetByUsername(string username)
        {
            try
            {
                dBConnect = new DBConnect();
                string query = "select * from `" + typeof(Item).Name.ToLower() + "` where username = @username";

                dBConnect.Open();
                MySqlCommand command = new MySqlCommand(query, dBConnect.connection);
                MySqlDataReader reader = command.ExecuteReader();

                command.Parameters.AddWithValue("@username", username);

                User user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4));
                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dBConnect.Close();
            }
            return null;
        }

        public List<User> GetAll()
        {
            try
            {
                dBConnect = new DBConnect();
                string query = "select * from `" + typeof(Item).Name.ToLower() + "`";

                dBConnect.Open();
                MySqlCommand command = new MySqlCommand(query, dBConnect.connection);
                MySqlDataReader reader = command.ExecuteReader();

                List<User> users = new List<User>();
                while (reader.Read())
                {
                    User user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4));
                    users.Add(user);
                }
                return users;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dBConnect.Close();
            }
            return null;
        }
    }
}
