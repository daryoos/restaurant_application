using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using RestaurantOldies.model;

namespace RestaurantOldies.dataAccess
{
    public class BillDAO : AbstractDAO<Bill>
    {
        public Bill GetById(int id)
        {
            try
            {
                dBConnect = new DBConnect();
                string query = "select * from `" + typeof(Item).Name.ToLower() + "` where id = @id";

                dBConnect.Open();
                MySqlCommand command = new MySqlCommand(query, dBConnect.connection);
                MySqlDataReader reader = command.ExecuteReader();

                command.Parameters.AddWithValue("@id", id);

                Bill bill = new Bill(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2));
                return bill;
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

        public List<Bill> GetAll()
        {
            try
            {
                dBConnect = new DBConnect();
                string query = "select * from `" + typeof(Item).Name.ToLower() + "`";

                dBConnect.Open();
                MySqlCommand command = new MySqlCommand(query, dBConnect.connection);
                MySqlDataReader reader = command.ExecuteReader();

                List<Bill> bills = new List<Bill>();
                while (reader.Read())
                {
                    Bill bill = new Bill(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2));
                    bills.Add(bill);
                }
                return bills;
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
}
