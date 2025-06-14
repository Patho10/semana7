using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_01.Config
{
    public static class Conexion
    {
        private static readonly string connectionString;
        static Conexion()
        {
            connectionString = "Server = DESKTOP-RKGK4R6 ; Database = pubs; Integrated Security = True; Encrypt = True; TrustServerCertificate = True; ";
        }
        public static SqlConnection GetConnection()
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error al conectar con la base de datos: {ex.Message}");
                throw;
            }
        }
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand(query, connection))
            {
                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                using (var adapter = new SqlDataAdapter(command))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand(query, connection))
            {
                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                return command.ExecuteNonQuery();
            }
        }
    }
}
