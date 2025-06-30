using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TareaRoles.AccesoDatos
{
    class UsuariosDAO
    {
        private Conexion _conexion = new Conexion();

        public List<Datos.UsuariosDTO> todos()
        {
            List<Datos.UsuariosDTO> listaUsuariosDTO = new List<Datos.UsuariosDTO>();
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "SELECT * FROM `usuarios`";
                using (MySqlCommand cmd = new MySqlCommand(cadena, cn))
                {
                    using (MySqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Datos.UsuariosDTO rol = new Datos.UsuariosDTO
                            {
                                UsuarioId = lector.GetInt32(0),
                                Nombre = lector.GetString(1),
                                correo = lector.GetString(2),
                                password = lector.GetString(3),
                                IdRol = lector.GetInt32(4)
                            };
                            listaUsuariosDTO.Add(rol);
                        }
                    }
                    return listaUsuariosDTO;
                }
            }
        }


        public string insertar(Datos.UsuariosDTO UsuariosDTO)
        {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                try
                {
                    string cadena = "INSERT INTO `usuarios` (`UsuarioId`, `Nombre`, `correo`, `password`, `RolesId`) " +
                                    "VALUES (NULL, @nombre, @correo, @password, @IdRol)";
                    MySqlCommand sqlCommand = new MySqlCommand(cadena, cn);

                    sqlCommand.Parameters.AddWithValue("@nombre", UsuariosDTO.Nombre);
                    sqlCommand.Parameters.AddWithValue("@correo", UsuariosDTO.correo);
                    sqlCommand.Parameters.AddWithValue("@password", UsuariosDTO.password);
                    sqlCommand.Parameters.AddWithValue("@IdRol", UsuariosDTO.IdRol);

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

        public string actualizar(Datos.UsuariosDTO UsuariosDTO)
        {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "UPDATE usuarios SET Nombre = @nombre, correo = @correo, password = @password, RolesId = @IdRol " +
                                "WHERE UsuarioId = @UsuarioId";

                MySqlCommand sqlCommand = new MySqlCommand(cadena, cn);
                sqlCommand.Parameters.AddWithValue("@nombre", UsuariosDTO.Nombre);
                sqlCommand.Parameters.AddWithValue("@correo", UsuariosDTO.correo);
                sqlCommand.Parameters.AddWithValue("@password", UsuariosDTO.password);
                sqlCommand.Parameters.AddWithValue("@IdRol", UsuariosDTO.IdRol);
                sqlCommand.Parameters.AddWithValue("@UsuarioId", UsuariosDTO.UsuarioId);

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

        public string eliminar(int UsuarioId)
        {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "DELETE FROM usuarios WHERE UsuarioId = @UsuarioId";

                MySqlCommand sqlCommand = new MySqlCommand(cadena, cn);
                sqlCommand.Parameters.AddWithValue("@UsuarioId", UsuarioId);

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

