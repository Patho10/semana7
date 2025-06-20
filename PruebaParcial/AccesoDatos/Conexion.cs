using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace PruebaParcial.AccesoDatos
{
    public class Conexion
    {
        private static string connStr = "server=localhost;user=root;password=;database=alquiler";

        private MySqlConnection conexion;

        public MySqlConnection AbrirConexion()
        {
            try
            {
                conexion = new MySqlConnection(connStr);
                conexion.Open();
                return conexion;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
                throw;
            }
        }

        public void CerrarConexion()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }

    }
}