using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using RestaurantOldies.model;

namespace RestaurantOldies.dataAccess
{
    public class ItemDAO : AbstractDAO<Item>
    {
        public Item GetById(int id)
        {
            try
            {
                dBConnect = new DBConnect();
                string query = "select * from `" + typeof(Item).Name.ToLower() + "` where `id` = @id";
                Console.WriteLine(query);

                dBConnect.Open();
                MySqlCommand command = new MySqlCommand(query, dBConnect.connection);
                command.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Item item = new Item(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));
                    return item;
                }

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

        public List<Item> GetAll()
        {
            try
            {
                dBConnect = new DBConnect();
                string query = "select * from `" + typeof(Item).Name.ToLower() + "`";

                dBConnect.Open();
                MySqlCommand command = new MySqlCommand(query, dBConnect.connection);
                MySqlDataReader reader = command.ExecuteReader();

                List<Item> items = new List<Item>();
                while (reader.Read())
                {
                    Item item = new Item(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));
                    items.Add(item);
                }
                return items;
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

        public List<Item> GetAllInStock()
        {
            try
            {
                dBConnect = new DBConnect();
                string query = "select * from `" + typeof(Item).Name.ToLower() + "`";

                dBConnect.Open();
                MySqlCommand command = new MySqlCommand(query, dBConnect.connection);
                MySqlDataReader reader = command.ExecuteReader();

                List<Item> items = new List<Item>();
                while (reader.Read())
                {
                    Item item = new Item(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));
                    if (item.quantity > 0)
                    {
                        items.Add(item);
                    }
                }
                return items;
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
