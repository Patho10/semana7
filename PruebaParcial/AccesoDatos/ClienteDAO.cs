using MySql.Data.MySqlClient;
using PruebaParcial.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaParcial.AccesoDatos
{
    class ClienteDAO
    {
        private Conexion _conexion = new Conexion();

        public List<Datos.ClientesDTO> todos()
        {
            List<Datos.ClientesDTO> listaClientesDTO = new List<Datos.ClientesDTO>();
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "SELECT * FROM `clientes`";
                using (MySqlCommand cmd = new MySqlCommand(cadena, cn))
                {
                    using (MySqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Datos.ClientesDTO user = new Datos.ClientesDTO
                            {
                                Id = lector.GetInt32(0),
                                Nombre = lector.GetString(1),
                                Correo = lector.GetString(4),
                            };
                            listaClientesDTO.Add(user);
                        }
                    }
                }
            }
            return listaClientesDTO;
        }

        public string insertar(Datos.ClientesDTO clienteDTO)
        {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena =
                       "INSERT INTO `clientes`(`Nombre`, `Cedula`, `Telefono`, `Email`) VALUES " +
                       "(@Nombre, @Cedula, @Telefono, @Email)";
                MySqlCommand sqlCommand = new MySqlCommand(cadena, cn);
                sqlCommand.Parameters.AddWithValue("@Nombre", clienteDTO.Nombre);
                sqlCommand.Parameters.AddWithValue("@Telefono", clienteDTO.Id);
                sqlCommand.Parameters.AddWithValue("@Email", clienteDTO.Correo);
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
        public string actualizar(Datos.ClientesDTO cliente)
        {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "UPDATE clientes SET Nombre = @Nombre, Correo = @Correo WHERE ClienteID = @ClienteID";
                MySqlCommand cmd = new MySqlCommand(cadena, cn);
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Correo", cliente.Correo);
                cmd.Parameters.AddWithValue("@Id", cliente.Id);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0 ? "ok" : "error";
            }
        }

        public string eliminar(int ClienteID)
        {
            try
            {
                using (MySqlConnection cn = _conexion.AbrirConexion())
                {
                    string cadena = "DELETE FROM `clientes` WHERE `ClienteID` = @ClienteID";
                    MySqlCommand sqlCommand = new MySqlCommand(cadena, cn);
                    sqlCommand.Parameters.AddWithValue("@ClienteID", ClienteID);
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
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("foreign key constraint fails"))
                {
                    return "tiene_vehiculos";
                }
                return "error";
            }
        }
    }
}