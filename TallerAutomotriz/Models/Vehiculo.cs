using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerAutomotriz.Models
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public required string Placa { get; set; }
        public required string Marca { get; set; }
        public required string Modelo { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;
    }
}
