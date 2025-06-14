using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_01.Modelo
{
    public class AutorModel
    {
        public string Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string CodigoPostal { get; set; }
        public bool Contrato { get; set; }
        public bool Validar(out List<string> errores)
        {
            errores = new List<string>();

            if (string.IsNullOrWhiteSpace(Id))
                errores.Add("El ID del autor es requerido.");

            if (string.IsNullOrWhiteSpace(Apellido))
                errores.Add("El apellido del autor es requerido.");

            if (string.IsNullOrWhiteSpace(Nombre))
                errores.Add("El nombre del autor es requerido.");

            return errores.Count == 0;
        }

    }

}

