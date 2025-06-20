using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Mysql.AccesoDatos
{
    class UsuarioDAO
    {
        private Conexion _conexion = new Conexion();
        public List<Datos.UsuarioDTO> todos()
        {
            List<Datos.UsuarioDTO> listaUsuariosDTO = new List<Datos.UsuarioDTO>();
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "SELECT * FROM `usuarios`";
                using (MySqlCommand cmd = new MySqlCommand(cadena, cn))
                {
                    using (MySqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Datos.UsuarioDTO user = new Datos.UsuarioDTO
                            {
                                Correo = lector.GetString(2),
                                Nombre = lector.GetString(1),
                                password = lector.GetString(3),
                                UsuarioId = lector.GetInt32(0)
                            };
                            listaUsuariosDTO.Add(user);
                        }
                    }
                }
            }
            return listaUsuariosDTO;
        }
        public string insertar(Datos.UsuarioDTO usuarioDTO)
        {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena =
                       "INSERT INTO `usuarios`(`Nombre`, `correo`, `password`) VALUES " +
                       "(@Nombre, @correo, @pwd)";
                MySqlCommand sqlCommand = new MySqlCommand(cadena, cn);
                sqlCommand.Parameters.AddWithValue("@Nombre", usuarioDTO.Nombre);
                sqlCommand.Parameters.AddWithValue("@correo", usuarioDTO.Correo);
                sqlCommand.Parameters.AddWithValue("@pwd", usuarioDTO.password);
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
                string cadena =
                       "DELETE FROM `usuarios` WHERE `UsuarioId` = @usuarioid";
                MySqlCommand sqlCommand = new MySqlCommand(cadena, cn);
                sqlCommand.Parameters.AddWithValue("@usuarioid", UsuarioId);
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