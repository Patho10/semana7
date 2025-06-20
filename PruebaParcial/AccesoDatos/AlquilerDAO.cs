using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaParcial.AccesoDatos
{
    internal class AlquilerDAO
    {
        private Conexion _conexion = new Conexion();

        // Obtener todos los servicios
        public List<Datos.AlquilerDTO> todos()
        {
            List<Datos.AlquilerDTO> listaServicios = new List<Datos.AlquilerDTO>();

            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "SELECT * FROM servicios";
                using (MySqlCommand cmd = new MySqlCommand(cadena, cn))
                {
                    using (MySqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Datos.AlquilerDTO servicio = new Datos.AlquilerDTO
                            {
                                Id = lector.GetInt32(0),
                                ClienteId = lector.GetInt32(1),
                                VehiculoId = lector.GetInt32(2),
                            };
                            listaServicios.Add(servicio);
                        }
                    }
                }
            }

            return listaServicios;
        }

        // Insertar nuevo servicio
        public string insertar(Datos.AlquilerDTO servicio)
        {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "INSERT INTO servicios (VehiculoID, Fecha, TipoServicio, Costo, Observaciones) " +
                                "VALUES (@VehiculoID, @Fecha, @TipoServicio, @Costo, @Observaciones)";

                using (MySqlCommand cmd = new MySqlCommand(cadena, cn))
                {
                    cmd.Parameters.AddWithValue("@VehiculoID", servicio.VehiculoId);
                    cmd.Parameters.AddWithValue("@Fecha", servicio.Id);
                    cmd.Parameters.AddWithValue("@TipoServicio", servicio.ClienteId);


                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0 ? "ok" : "error";
                }
            }
        }

        // Actualizar un servicio existente
        public string actualizar(Datos.AlquilerDTO servicio)
        {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "UPDATE servicios SET VehiculoID = @VehiculoID, Fecha = @Fecha, TipoServicio = @TipoServicio, " +
                                "Costo = @Costo, Observaciones = @Observaciones WHERE ServicioID = @ServicioID";

                using (MySqlCommand cmd = new MySqlCommand(cadena, cn))
                {
                    cmd.Parameters.AddWithValue("@VehiculoID", servicio.VehiculoId);
                    cmd.Parameters.AddWithValue("@Fecha", servicio.Id);
                    cmd.Parameters.AddWithValue("@TipoServicio", servicio.ClienteId);

                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0 ? "ok" : "error";
                }
            }
        }

        // Eliminar un servicio por ID
        public string eliminar(int servicioID)
        {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "DELETE FROM servicios WHERE ServicioID = @ServicioID";

                using (MySqlCommand cmd = new MySqlCommand(cadena, cn))
                {
                    cmd.Parameters.AddWithValue("@ServicioID", servicioID);
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0 ? "ok" : "error";
                }
            }
        }
    }
}