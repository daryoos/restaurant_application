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
        public override void Update(Bill bill)
        {
            StringBuilder query = new StringBuilder("update `bill` set `totalCost` = ");
            query.Append("'" + bill.totalCost + "', ");
            query.Append("`status` = ");
            query.Append("'" + bill.status + "'");
            query.Append("where `id` = ");
            query.Append("'" + bill.id + "'");

            dBConnect.Open();
            MySqlCommand command = new MySqlCommand(query.ToString(), dBConnect.connection);
            command.ExecuteNonQuery();
        }

        public override void Add(Bill bill)
        {
            if (bill.date != null)
            {
                base.Add(bill);
            }
            string query = "insert into `bill` (`totalCost`, `status`) values (@totalCost, @status)";

            dBConnect.Open();
            MySqlCommand command = new MySqlCommand(query, dBConnect.connection);
            command.Parameters.AddWithValue("@totalCost", bill.totalCost);
            command.Parameters.AddWithValue("@status", bill.status);
            command.ExecuteNonQuery();
        }
        public Bill GetById(int id)
        {
            try
            {
                dBConnect = new DBConnect();
                string query = "select * from `" + typeof(Bill).Name.ToLower() + "` where `id` = @id";
                Console.WriteLine(query);

                dBConnect.Open();
                MySqlCommand command = new MySqlCommand(query, dBConnect.connection);
                command.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Bill bill = new Bill(reader.GetInt32(0), reader.GetFloat(1), reader.GetString(2), reader.GetMySqlDateTime(3).ToString());
                    return bill;
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

        public List<Bill> GetAll()
        {
            try
            {
                dBConnect = new DBConnect();
                string query = "select * from `" + typeof(Bill).Name.ToLower() + "`";

                dBConnect.Open();
                MySqlCommand command = new MySqlCommand(query, dBConnect.connection);
                MySqlDataReader reader = command.ExecuteReader();

                List<Bill> bills = new List<Bill>();
                while (reader.Read())
                {
                    Bill bill = new Bill(reader.GetInt32(0), reader.GetFloat(1), reader.GetString(2), reader.GetMySqlDateTime(3).ToString());
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
