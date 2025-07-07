using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SistemaReservas.Data
{
    public class ApplicationDbContext
    {
        private readonly string connectionString = "server=localhost;database=sistema_reservas;user=root;password=;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
