using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerAutomotriz.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Telefono { get; set; }
        public required string Direccion { get; set; }

        public List<Vehiculo> Vehiculos { get; set; } = new();
    }
}
