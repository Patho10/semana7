using System;
using MySql.Data.MySqlClient;

namespace Mysql.AccesoDatos
{
    class Conexion
    {
        //sqlconnecction    Sirve para abrir o cerar la conexion a la base de datos
        private readonly string cadenaConexion =
           "server=localhost;database=Cuarto_maysep2025;uid=root;pwd=root;";
        private MySqlConnection conexion;

        public MySqlConnection AbrirConexion()
        {
            conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
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
