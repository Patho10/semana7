using System;
using System.Data.SqlClient;

namespace WindowsFormsCRUD.AccesoDatos
{
    class Conexion
    {

        private readonly string cadenaConexion = "server=(local);database=Cuarto_MaySep2025;uid=sa;pwd=123;Trusted_Connection=True";
        private SqlConnection conexion;
        public SqlConnection AbrirConexion()
        {
            if (conexion == null)
            {
                conexion = new SqlConnection(cadenaConexion);
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }
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
    
        