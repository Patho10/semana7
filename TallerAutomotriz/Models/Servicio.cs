using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerAutomotriz.Models
{
    public class Servicio
    {
        public int Id { get; set; }
        public required string Descripcion { get; set; }
        public decimal Costo { get; set; }
    }
}
