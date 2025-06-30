using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TareaRoles.AccesoDatos
{
    class Conexion
    {
        private readonly string cadenaConexion =
            "Server=localhost;Database=cuarto_maysep2025;Uid=root;Pwd=;";
        private MySqlConnection conexion;

        public MySqlConnection AbrirConexion()
        {
            conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }
    }
}
