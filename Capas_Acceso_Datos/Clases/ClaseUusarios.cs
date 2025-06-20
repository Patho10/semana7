using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data.SqlClient;
using Capas_Acceso_Dato.Config;
namespace Capas_Acceso_Datos.Clases
{
  public class ClaseUusarios
    {
        private Conexion _conexion = new Conexion();
        public List<UsuarioDTO> todos()
        {
            var listaUsuarios = new List<UsuarioDTO>();
            using (SqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "SELECT UsuarioId, Nombre, NombreUsuario, Contrasenia, Correo, Estado FROM Usuarios WHERE  (Estado = 1)";
                using (SqlCommand cmd = new SqlCommand(cadena, cn))
                {
                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            UsuarioDTO usuarioDTO = new UsuarioDTO
                            {
                                UsuarioId = lector.GetInt32(0),
                                Nombre = lector.GetString(1),
                                NombreUsuario = lector.GetString(2),
                                Contrasenia = lector.GetString(3),
                                Correo = lector.GetString(4),
                                Estado = lector.GetBoolean(5)
                            };
                            listaUsuarios.Add(usuarioDTO);
                        }
                    }
                }

            }
            return listaUsuarios;
        }
    }
}
