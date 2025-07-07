using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ferreteria.Models;
using Ferreteria.Data;

namespace Ferreteria.Controllers
{
    public class HerramientaControllers
    {
        private readonly HerramientaDbContext _context = new HerramientaDbContext();

        public List<Herramienta> ObtenerHerramientas() => _context.Herramientas.ToList();

        public void AgregarHerramienta(Herramienta herramienta)
        {
            _context.Herramientas.Add(herramienta);
            _context.SaveChanges();
        }

        public void ActualizarHerramienta(Herramienta herramienta)
        {
            _context.Herramientas.Update(herramienta);
            _context.SaveChanges();
        }

        public void EliminarHerramienta(int herramientaId)
        {
            var herramienta = _context.Herramientas.Find(herramientaId);
            if (herramienta != null)
            {
                _context.Herramientas.Remove(herramienta);
                _context.SaveChanges();
            }
        }
    }
}
