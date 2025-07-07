using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria.Models
{
    internal class ProvinciaModel
    {
        public int Id { get; set; }
        public string Detalle { get; set; }

        public PaisModel Paises { get; set; }

    }
}
