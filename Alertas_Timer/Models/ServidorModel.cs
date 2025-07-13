using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alertas_Timer.Models
{
    public class ServidorModel
    {
        public int Id { get; set; }
        public string nombre_servidor { get; set; }
        public string ip { get; set; }
        public string ubicacion { get; set; }
        public string sistema_operativo { get; set; }
        public string estado { get; set; }
    }
}
