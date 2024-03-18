using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using MySql.Data.MySqlClient;
using RestaurantOldies.model;

namespace RestaurantOldies.dataAccess
{
    public class OrderDAO : AbstractDAO<Order>
    {
        public List<Order> GetByBillId(int billId)
        {
            try
            {
                dBConnect = new DBConnect();
                string query = "select * from `" + typeof(Order).Name.ToLower() + "` where `billId` = @billId";
                Console.WriteLine(query);

                dBConnect.Open();
                MySqlCommand command = new MySqlCommand(query, dBConnect.connection);
                command.Parameters.AddWithValue("@billId", billId);
                MySqlDataReader reader = command.ExecuteReader();

                List<Order> orders = new List<Order>();
                while (reader.Read())
                {
                    Order order = new Order(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2));
                    orders.Add(order);
                }
                return orders;

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
        public Order GetById(int id)
        {
            try
            {
                dBConnect = new DBConnect();
                string query = "select * from `" + typeof(Order).Name.ToLower() + "` where `id` = @id";
                Console.WriteLine(query);

                dBConnect.Open();
                MySqlCommand command = new MySqlCommand(query, dBConnect.connection);
                command.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Order order = new Order(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2));
                    return order;
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

        public List<Order> GetAll()
        {
            try
            {
                dBConnect = new DBConnect();
                string query = "select * from `" + typeof(Order).Name.ToLower() + "`";

                dBConnect.Open();
                MySqlCommand command = new MySqlCommand(query, dBConnect.connection);
                MySqlDataReader reader = command.ExecuteReader();

                List<Order> orders = new List<Order>();
                while (reader.Read())
                {
                    Order order = new Order(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2));
                    orders.Add(order);
                }
                return orders;
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

        public bool Add(Order order, Bill bill, Item item)
        {
            if (order.quantity <= item.quantity)
            {
                ItemDAO itemDAO = new ItemDAO();
                item.quantity -= order.quantity;
                itemDAO.Update(item);

                BillDAO billDAO = new BillDAO();
                bill.totalCost += item.price * order.quantity;
                billDAO.Update(bill);

                base.Add(order);
                return true;
            }
            return false;
        }
    }
}
