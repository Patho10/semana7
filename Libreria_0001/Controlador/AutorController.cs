using Libreria_01.Config;
using Libreria_01.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Libreria_01.Controlador
{
    public class AutorController
    {
        public List<AutorModel> ObtenerTodos()
        {
            var autores = new List<AutorModel>();

            string query = "SELECT au_id, au_lname, au_fname, phone, address, city, state, zip, contract " +
                          "FROM authors";
            DataTable dt = Conexion.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                autores.Add(new AutorModel
                {
                    Id = row["au_id"].ToString(),
                    Apellido = row["au_lname"].ToString(),
                    Nombre = row["au_fname"].ToString(),
                    Telefono = row["phone"].ToString(),
                    Direccion = row["address"].ToString(),
                    Ciudad = row["city"].ToString(),
                    Estado = row["state"].ToString(),
                    CodigoPostal = row["zip"].ToString(),
                    Contrato = Convert.ToBoolean(row["contract"])
                });
            }
            return autores;
        }

        public AutorModel ObtenerPorId(string id)
        {
            string query = "SELECT au_id, au_lname, au_fname, phone, address, city, state, zip, contract " +
                          "FROM authors WHERE au_id = @id";

            var parameter = new SqlParameter("@id", id);
            DataTable dt = Conexion.ExecuteQuery(query, new SqlParameter[] { parameter });

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new AutorModel
                {
                    Id = row["au_id"].ToString(),
                    Apellido = row["au_lname"].ToString(),
                    Nombre = row["au_fname"].ToString(),
                    Telefono = row["phone"].ToString(),
                    Direccion = row["address"].ToString(),
                    Ciudad = row["city"].ToString(),
                    Estado = row["state"].ToString(),
                    CodigoPostal = row["zip"].ToString(),
                    Contrato = Convert.ToBoolean(row["contract"])
                };
            }
            return null;
        }

        public bool Crear(AutorModel autor)
        {
            string query = "INSERT INTO authors (au_id, au_lname, au_fname, phone, address, city, state, zip, contract) " +
                          "VALUES (@id, @apellido, @nombre, @telefono, @direccion, @ciudad, @estado, @codigo, @contrato)";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@id", autor.Id),
                new SqlParameter("@apellido", autor.Apellido),
                new SqlParameter("@nombre", autor.Nombre),
                new SqlParameter("@telefono", autor.Telefono ?? (object)DBNull.Value),
                new SqlParameter("@direccion", autor.Direccion ?? (object)DBNull.Value),
                new SqlParameter("@ciudad", autor.Ciudad ?? (object)DBNull.Value),
                new SqlParameter("@estado", autor.Estado ?? (object)DBNull.Value),
                new SqlParameter("@codigo", autor.CodigoPostal ?? (object)DBNull.Value),
                new SqlParameter("@contrato", autor.Contrato)
            };

            int result = Conexion.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        public bool Actualizar(AutorModel autor)
        {
            string query = "UPDATE authors SET " +
                          "au_lname = @apellido, " +
                          "au_fname = @nombre, " +
                          "phone = @telefono, " +
                          "address = @direccion, " +
                          "city = @ciudad, " +
                          "state = @estado, " +
                          "zip = @codigo, " +
                          "contract = @contrato " +
                          "WHERE au_id = @id";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@apellido", autor.Apellido),
                new SqlParameter("@nombre", autor.Nombre),
                new SqlParameter("@telefono", autor.Telefono ?? (object)DBNull.Value),
                new SqlParameter("@direccion", autor.Direccion ?? (object)DBNull.Value),
                new SqlParameter("@ciudad", autor.Ciudad ?? (object)DBNull.Value),
                new SqlParameter("@estado", autor.Estado ?? (object)DBNull.Value),
                new SqlParameter("@codigo", autor.CodigoPostal ?? (object)DBNull.Value),
                new SqlParameter("@contrato", autor.Contrato),
                new SqlParameter("@id", autor.Id)
            };
            int result = Conexion.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool Eliminar(string id)
        {
            string query = "DELETE FROM authors WHERE au_id = @id";
            var parameter = new SqlParameter("@id", id);

            int result = Conexion.ExecuteNonQuery(query, new SqlParameter[] { parameter });
            return result > 0;
        }
    }
    }
