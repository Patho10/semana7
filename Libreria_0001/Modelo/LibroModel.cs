using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_01.Modelo
{
    public class LibroModel
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Tipo { get; set; }
        public string EditorialId { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Adelanto { get; set; }
        public int? Regalias { get; set; }
        public int? VentasAnuales { get; set; }
        public string Notas { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public bool Validar(out List<string> errores)
        {
            errores = new List<string>();

            if (string.IsNullOrWhiteSpace(Id))
                errores.Add("El ID del libro es requerido.");

            if (string.IsNullOrWhiteSpace(Titulo))
                errores.Add("El título del libro es requerido.");

            if (string.IsNullOrWhiteSpace(EditorialId))
                errores.Add("Debe seleccionar una editorial.");

            return errores.Count == 0;
        }
    }
}
