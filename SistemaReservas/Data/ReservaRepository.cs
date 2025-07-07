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
    public class ReservaRepository
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public List<Reserva> ObtenerTodos()
        {
            var lista = new List<Reserva>();
            using (var conn = _context.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM reservas", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Reserva
                    {
                        IdReserva = reader.GetInt32("id_reserva"),
                        IdUsuario = reader.GetInt32("id_usuario"),
                        IdHorario = reader.GetInt32("id_horario"),
                        IdUnidad = reader.GetInt32("id_unidad"),
                        Fecha = reader.GetDateTime("fecha"),
                        Estado = reader.GetString("estado")
                    });
                }
            }
            return lista;
        }
    }
}
