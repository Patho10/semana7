using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace login.Models
{
    public class loginModel : UsuarioModel
    {

        private Config.Conexion _conexion = new Config.Conexion();
        public string Error { get; set; }

        public string VerificarLogin(loginModel loginModel)
        {
            try
            {
                using (SqlConnection con = _conexion.AbrirConexion())
                {
                    string cadena =
                        "SELECT * FROM Usuarios where " +
                        "NombreUsuario = @usuario and Contrasenia = @contrasenia";
                    SqlCommand sqlCommand = new SqlCommand(cadena, con);
                    sqlCommand.Parameters.AddWithValue("@usuario", loginModel.NombreUsuario);
                    sqlCommand.Parameters.AddWithValue("@contrasenia", loginModel.Contrasenia);

                    SqlDataReader dr = sqlCommand.ExecuteReader();
                    if (dr.HasRows)
                    {
                        return "ok";
                    }
                    else
                    {
                        Error = "El usuario o la contrasenia son incorrectos";
                        return Error;
                    }
                }
            }
            catch (Exception ex)
            {
                Error = "Error al intentar el login" + ex.Message;
                return Error;
            }
        }
    }
}
