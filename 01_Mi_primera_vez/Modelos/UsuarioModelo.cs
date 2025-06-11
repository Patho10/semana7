using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Mi_primera_vez.Modelos
{
    internal class UsuarioModelo
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }

        public override string ToString()
        {
            return $"{Nombre} - {Correo}";
        }
       
    }
}
