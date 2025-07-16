using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerAutomotriz.Data;
using TallerAutomotriz.Models;
using Microsoft.EntityFrameworkCore;

namespace TallerAutomotriz.Controllers
{
    public class FacturaController
    {
        private readonly TallerContext _context = new();

        public List<Factura> ObtenerTodas() =>
            _context.Facturas
                .Include(f => f.Vehiculo)
                .Include(f => f.Servicio)
                .Include(f => f.Empleado)
                .ToList();

        public void Agregar(Factura factura)
        {
            _context.Facturas.Add(factura);
            _context.SaveChanges();
        }

        public void Actualizar(Factura factura)
        {
            _context.Facturas.Update(factura);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var factura = _context.Facturas.Find(id);
            if (factura != null)
            {
                _context.Facturas.Remove(factura);
                _context.SaveChanges();
            }
        }
    }
}
