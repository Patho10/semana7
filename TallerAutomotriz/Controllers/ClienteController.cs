using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerAutomotriz.Data;
using TallerAutomotriz.Models;

namespace TallerAutomotriz.Controllers
{
    public class ClienteController
    {
        private readonly TallerContext _context = new();

        public List<Cliente> ObtenerTodos() => _context.Clientes.ToList();

        public Cliente? ObtenerPorId(int id) => _context.Clientes.Find(id);

        public void Agregar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void Actualizar(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var cliente = _context.Clientes.Find(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }
    }
}
