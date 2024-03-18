using RestaurantOldies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RestaurantOldies
{
    public class AbstractDAO<T>
    {
        protected static DBConnect dBConnect;

        private Type type;

        public AbstractDAO() {
            type = typeof(T);
        }

        public virtual void Add(T entity)
        {
            Console.WriteLine("Add operation:\n");
            try
            {
                dBConnect = new DBConnect();

                PropertyInfo[] properties = typeof(T).GetProperties();
                StringBuilder propertyNames = new StringBuilder();
                StringBuilder parameterNames = new StringBuilder();

                for (int i = 1;  i < properties.Length; i++)
                {
                    propertyNames.Append(properties[i].Name.ToLower());
                    parameterNames.Append($"@{properties[i].Name.ToLower()}");
                    if (i < properties.Length - 1)
                    {
                        propertyNames.Append(", ");
                        parameterNames.Append(", ");
                    }
                }

                String query = "insert into `" + type.Name.ToLower() + "` (" + propertyNames.ToString() + ") values (" + parameterNames + ")";
                Console.WriteLine(query + "\n");

                dBConnect.Open();
                MySqlCommand command = new MySqlCommand(query, dBConnect.connection);

                for (int i = 0; i < properties.Length; i++)
                {
                    command.Parameters.AddWithValue($"@{properties[i].Name.ToLower()}", properties[i].GetValue(entity));
                }

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dBConnect.Close();
            }
        }

        public virtual void Update(T entity)
        {
            Console.WriteLine("Update operation:\n");
            try
            {
                dBConnect = new DBConnect();

                PropertyInfo[] properties = typeof(T).GetProperties();

                StringBuilder query = new StringBuilder("update `" + type.Name.ToLower() + "` set ");

                for (int i = 1; i < properties.Length; i++)
                {
                    query.Append(properties[i].Name.ToLower());
                    query.Append("= '");
                    query.Append(properties[i].GetValue(entity));
                    query.Append("' ");
                    if (i < properties.Length - 1)
                    {
                        query.Append(',');
                    }
                }
                query.Append(" where id = '");
                query.Append(properties[0].GetValue(entity));
                query.Append("'");

                Console.WriteLine(query + "\n");

                dBConnect.Open();
                MySqlCommand command = new MySqlCommand(query.ToString(), dBConnect.connection);

                for (int i = 0; i < properties.Length; i++)
                {
                    command.Parameters.AddWithValue($"@{properties[i].Name.ToLower()}", properties[i].GetValue(entity));
                }

                command.ExecuteNonQuery();
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message);
            }
            finally
            { 
                dBConnect.Close();
            }
        }

        public void Delete(T entity)
        {
            Console.WriteLine("Delete operation:\n");
            try
            {
                dBConnect = new DBConnect();

                PropertyInfo[] properties = typeof(T).GetProperties();

                string query = "delete from `" + type.Name.ToLower() + "` where id = @id";
                Console.WriteLine(query + "\n");

                dBConnect.Open();
                MySqlCommand command = new MySqlCommand(query, dBConnect.connection);

                command.Parameters.AddWithValue("@id", properties[0].GetValue(entity));

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dBConnect.Close();
            }
        }

    }
}
