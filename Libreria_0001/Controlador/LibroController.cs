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
    public class LibroController
    {
        public List<LibroModel> ObtenerTodos()
        {
            var libros = new List<LibroModel>();

            string query = "SELECT title_id, title, type, pub_id, price, advance, royalty, ytd_sales, notes, pubdate " +
                          "FROM titles";

            DataTable dt = Conexion.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                libros.Add(new LibroModel
                {
                    Id = row["title_id"].ToString(),
                    Titulo = row["title"].ToString(),
                    Tipo = row["type"].ToString(),
                    EditorialId = row["pub_id"].ToString(),
                    Precio = row["price"] != DBNull.Value ? Convert.ToDecimal(row["price"]) : (decimal?)null,
                    Adelanto = row["advance"] != DBNull.Value ? Convert.ToDecimal(row["advance"]) : (decimal?)null,
                    Regalias = row["royalty"] != DBNull.Value ? Convert.ToInt32(row["royalty"]) : (int?)null,
                    VentasAnuales = row["ytd_sales"] != DBNull.Value ? Convert.ToInt32(row["ytd_sales"]) : (int?)null,
                    Notas = row["notes"].ToString(),
                    FechaPublicacion = row["pubdate"] != DBNull.Value ? Convert.ToDateTime(row["pubdate"]) : (DateTime?)null
                });
            }

            return libros;
        }

        public List<LibroModel> BuscarPorTitulo(string busqueda)
        {
            var libros = new List<LibroModel>();

            string query = "SELECT title_id, title, type, pub_id, price, advance, royalty, ytd_sales, notes, pubdate " +
                          "FROM titles WHERE title LIKE @busqueda OR type LIKE @busqueda";

            var parameter = new SqlParameter("@busqueda", $"%{busqueda}%");
            DataTable dt = Conexion.ExecuteQuery(query, new SqlParameter[] { parameter });

            foreach (DataRow row in dt.Rows)
            {
                libros.Add(new LibroModel
                {
                    Id = row["title_id"].ToString(),
                    Titulo = row["title"].ToString(),
                    Tipo = row["type"].ToString(),
                    EditorialId = row["pub_id"].ToString(),
                    Precio = row["price"] != DBNull.Value ? Convert.ToDecimal(row["price"]) : (decimal?)null,
                    Adelanto = row["advance"] != DBNull.Value ? Convert.ToDecimal(row["advance"]) : (decimal?)null,
                    Regalias = row["royalty"] != DBNull.Value ? Convert.ToInt32(row["royalty"]) : (int?)null,
                    VentasAnuales = row["ytd_sales"] != DBNull.Value ? Convert.ToInt32(row["ytd_sales"]) : (int?)null,
                    Notas = row["notes"].ToString(),
                    FechaPublicacion = row["pubdate"] != DBNull.Value ? Convert.ToDateTime(row["pubdate"]) : (DateTime?)null
                });
            }

            return libros;
        }

        public bool Crear(LibroModel libro)
        {
            string query = "INSERT INTO titles (title_id, title, type, pub_id, price, advance, royalty, ytd_sales, notes, pubdate) " +
                          "VALUES (@id, @titulo, @tipo, @editorialId, @precio, @adelanto, @regalias, @ventas, @notas, @fecha)";

            var parameters = new SqlParameter[]
            {
                 new SqlParameter("@id", libro.Id),
                new SqlParameter("@titulo", libro.Titulo),
                new SqlParameter("@tipo", libro.Tipo ?? (object)DBNull.Value),
                new SqlParameter("@editorialId", libro.EditorialId),
                new SqlParameter("@precio", libro.Precio ?? (object)DBNull.Value),
                new SqlParameter("@adelanto", libro.Adelanto ?? (object)DBNull.Value),
                new SqlParameter("@regalias", libro.Regalias ?? (object)DBNull.Value),
                new SqlParameter("@ventas", libro.VentasAnuales ?? (object)DBNull.Value),
                new SqlParameter("@notas", libro.Notas ?? (object)DBNull.Value),
                new SqlParameter("@fecha", libro.FechaPublicacion ?? (object)DBNull.Value)
            };

            int result = Conexion.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        public bool Actualizar(LibroModel libro)
        {
            string query = "UPDATE titles SET " +
                          "title = @titulo, " +
                          "type = @tipo, " +
                          "pub_id = @editorialId, " +
                          "price = @precio, " +
                          "advance = @adelanto, " +
                          "royalty = @regalias, " +
                          "ytd_sales = @ventas, " +
                          "notes = @notas, " +
                          "pubdate = @fecha " +
                          "WHERE title_id = @id";

            var parameters = new SqlParameter[]
            {
                new SqlParameter("@titulo", libro.Titulo),
                new SqlParameter("@tipo", libro.Tipo ?? (object)DBNull.Value),
                new SqlParameter("@editorialId", libro.EditorialId),
                new SqlParameter("@precio", libro.Precio ?? (object)DBNull.Value),
                new SqlParameter("@adelanto", libro.Adelanto ?? (object)DBNull.Value),
                new SqlParameter("@regalias", libro.Regalias ?? (object)DBNull.Value),
                new SqlParameter("@ventas", libro.VentasAnuales ?? (object)DBNull.Value),
                new SqlParameter("@notas", libro.Notas ?? (object)DBNull.Value),
                new SqlParameter("@fecha", libro.FechaPublicacion ?? (object)DBNull.Value),
                new SqlParameter("@id", libro.Id)
            };

            int result = Conexion.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        public bool Eliminar(string id)
        {
            string query = "DELETE FROM titles WHERE title_id = @id";
            var parameter = new SqlParameter("@id", id);

            int result = Conexion.ExecuteNonQuery(query, new SqlParameter[] { parameter });
            return result > 0;
        }
    }
}
