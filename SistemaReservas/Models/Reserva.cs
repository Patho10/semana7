using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservas.Models
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public int IdUsuario { get; set; }
        public int IdHorario { get; set; }
        public int IdUnidad { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; } // "pendiente", "confirmada", "cancelada"
    }
}
