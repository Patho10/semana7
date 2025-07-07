using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaReservas.Data;
using SistemaReservas.Models;
using System.Collections.Generic;


namespace SistemaReservas.Services
{
    public class ReservaService
    {
        private readonly ReservaRepository _repo = new ReservaRepository();

        public List<Reserva> ObtenerReservas()
        {
            return _repo.ObtenerTodos();
        }
    }
}
