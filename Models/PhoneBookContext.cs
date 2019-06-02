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

    }
}