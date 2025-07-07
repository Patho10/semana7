using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaReservas.Models;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SistemaReservas.Data
{
    public class UsuarioRepository
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public List<Usuario> ObtenerTodos()
        {
            var lista = new List<Usuario>();
            using (var conn = _context.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM usuarios", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Usuario
                    {
                        IdUsuario = reader.GetInt32("id_usuario"),
                        Nombre = reader.GetString("nombre"),
                        Rol = reader.GetString("rol"),
                        Email = reader.GetString("email"),
                        Clave = reader.GetString("clave")
                    });
                }
            }
            return lista;
        }
    }
}
