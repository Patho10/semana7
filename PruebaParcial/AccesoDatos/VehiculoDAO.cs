using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaParcial.AccesoDatos
{
    class VehiculoDAO
    {
        private Conexion _conexion = new Conexion();

        public List<Datos.VehiculoDTO> todos()
        {
            List<Datos.VehiculoDTO> listaVehiculosDTO = new List<Datos.VehiculoDTO>();
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "SELECT * FROM `vehiculos`";
                using (MySqlCommand cmd = new MySqlCommand(cadena, cn))
                {
                    using (MySqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Datos.VehiculoDTO vehiculo = new Datos.VehiculoDTO
                            {
                                Id = lector.GetInt32(0),
                                Marca = lector.GetString(2),
                                Modelo = lector.GetString(3),
                                Anio = lector.GetInt32(4),
                                PrecioPorDia = lector.GetInt32(5),
                            };
                            listaVehiculosDTO.Add(vehiculo);
                        }
                    }
                }
            }
            return listaVehiculosDTO;
        }

        public string insertar(Datos.VehiculoDTO vehiculoDTO)
        {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena =
                    "INSERT INTO `vehiculos`(`Placa`, `Marca`, `Modelo`, `Anio`, `ClienteID`) VALUES " +
                    "(@Placa, @Marca, @Modelo, @Anio, @ClienteID)";
                MySqlCommand sqlCommand = new MySqlCommand(cadena, cn);
                sqlCommand.Parameters.AddWithValue("@Marca", vehiculoDTO.Marca);
                sqlCommand.Parameters.AddWithValue("@Modelo", vehiculoDTO.Modelo);
                sqlCommand.Parameters.AddWithValue("@Anio", vehiculoDTO.Anio);
                sqlCommand.Parameters.AddWithValue("@ClienteID", vehiculoDTO.PrecioPorDia);

                int filasAfectadas = sqlCommand.ExecuteNonQuery();

                return filasAfectadas > 0 ? "ok" : "error";
            }
        }

        public string actualizar(Datos.VehiculoDTO vehiculo)
        {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena =
                    "UPDATE vehiculos SET Placa = @Placa, Marca = @Marca, Modelo = @Modelo, Anio = @Anio, ClienteID = @ClienteID " +
                    "WHERE VehiculoID = @VehiculoID";

                MySqlCommand cmd = new MySqlCommand(cadena, cn);
                cmd.Parameters.AddWithValue("@Marca", vehiculo.Marca);
                cmd.Parameters.AddWithValue("@Modelo", vehiculo.Modelo);
                cmd.Parameters.AddWithValue("@Anio", vehiculo.Anio);
                cmd.Parameters.AddWithValue("@ClienteID", vehiculo.Id);
                cmd.Parameters.AddWithValue("@VehiculoID", vehiculo.PrecioPorDia);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0 ? "ok" : "error";
            }
        }

        public string eliminar(int VehiculoID)
        {
            try
            {
                using (MySqlConnection cn = _conexion.AbrirConexion())
                {
                    string cadena = "DELETE FROM vehiculos WHERE VehiculoID = @VehiculoID";
                    MySqlCommand cmd = new MySqlCommand(cadena, cn);
                    cmd.Parameters.AddWithValue("@VehiculoID", VehiculoID);
                    int filas = cmd.ExecuteNonQuery();

                    return filas > 0 ? "ok" : "error";
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("foreign key constraint fails"))
                {
                    return "tiene_servicios"; // clave foránea bloquea la eliminación
                }
                return "error";
            }
        }
    }
}
