using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace phonebook.Models
{
    public class PhoneBookContext
    {
        public string ConnectionString { get; set; }

        public PhoneBookContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection() => new MySqlConnection(ConnectionString);

        public List<PhoneNumber> GetAllNumbers()
        {
            List<PhoneNumber> list = new List<PhoneNumber>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from Album where id < 10", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new PhoneNumber()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            LastName = reader["lastname"].ToString(),
                            FirstName = reader["firstname"].ToString(),
                            Address = reader["address"].ToString(),
                            PhoneNum = reader["phonenumber"].ToString(),
                        });
                    }
                }
            }
            return list;
        }
    }
}