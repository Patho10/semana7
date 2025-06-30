using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace TareaRoles.AccesoDatos
{
    class RolesDAO
    {
        private Conexion _conexion = new Conexion();

        public List<Datos.RolesDTO> todos()
        {
            List<Datos.RolesDTO> listaRolesDTO = new List<Datos.RolesDTO>();
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "SELECT * FROM `roles`";
                using (MySqlCommand cmd = new MySqlCommand(cadena, cn))
                {
                    using (MySqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Datos.RolesDTO rol = new Datos.RolesDTO
                            {
                                RolesId = lector.GetInt32(0),
                                Detalle = lector.GetString(1),
                            };
                            listaRolesDTO.Add(rol);
                        }
                    }

                }
                return listaRolesDTO;
            }
        }

        public string insertar(Datos.RolesDTO RolesDTO)
        {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                try
                {
                    string cadena = "INSERT INTO `roles` (`RolesId`, `Detalle`) VALUES (NULL, @rDetalle);";
                    MySqlCommand sqlCommand = new MySqlCommand(cadena, cn);
                    sqlCommand.Parameters.AddWithValue("@rDetalle", RolesDTO.Detalle);
                    int filasAfectadas = sqlCommand.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        return "ok";
                    }
                    else
                    {

                        return "error";
                    }
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                    {
                        return "duplicado";
                    }
                    else
                    {
                        return "error_sql";
                    }
                }
            }
        }

        public string actualizar(Datos.RolesDTO RolesDTO)
        {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena =
                    "UPDATE roles SET Detalle = @Detalle WHERE RolesId = @RolesId";

                MySqlCommand sqlCommand = new MySqlCommand(cadena, cn);
                sqlCommand.Parameters.AddWithValue("@Detalle", RolesDTO.Detalle);
                sqlCommand.Parameters.AddWithValue("@RolesId", RolesDTO.RolesId);

                int filasAfectadas = sqlCommand.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    return "ok";
                }
                else
                {
                    return "error";
                }
            }
        }

        public string eliminar(int RolesId)
        {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena =
                       "DELETE FROM Roles WHERE RolesId = @RolesId";
                MySqlCommand sqlCommand = new MySqlCommand(cadena, cn);
                sqlCommand.Parameters.AddWithValue("RolesId", RolesId);
                int filasAfectadas = sqlCommand.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    return "ok";
                }
                else
                {
                    return "error";
                }
            }
        }
    }
}
