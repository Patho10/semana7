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
    public class VehiculoController
    {
        private readonly TallerContext _context = new();

        public List<Vehiculo> ObtenerTodos() =>
            _context.Vehiculos.Include(v => v.Cliente).ToList();

        public void Agregar(Vehiculo vehiculo)
        {
            _context.Vehiculos.Add(vehiculo);
            _context.SaveChanges();
        }

        public void Actualizar(Vehiculo vehiculo)
        {
            _context.Vehiculos.Update(vehiculo);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var vehiculo = _context.Vehiculos.Find(id);
            if (vehiculo != null)
            {
                _context.Vehiculos.Remove(vehiculo);
                _context.SaveChanges();
            }
        }
    }
}
