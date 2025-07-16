using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerAutomotriz.Data;
using TallerAutomotriz.Models;

namespace TallerAutomotriz.Controllers
{
    public class ServicioController
    {
        private readonly TallerContext _context = new();

        public List<Servicio> ObtenerTodos() => _context.Servicios.ToList();

        public void Agregar(Servicio servicio)
        {
            _context.Servicios.Add(servicio);
            _context.SaveChanges();
        }

        public void Actualizar(Servicio servicio)
        {
            _context.Servicios.Update(servicio);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var servicio = _context.Servicios.Find(id);
            if (servicio != null)
            {
                _context.Servicios.Remove(servicio);
                _context.SaveChanges();
            }
        }
    }
}
