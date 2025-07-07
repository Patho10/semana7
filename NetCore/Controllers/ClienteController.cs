using NetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Controllers
{
    public class ClienteController
    {
        private readonly JardineriaContext _jardineriaContext;
        public ClienteController(JardineriaContext jardineriaContext)
        {
            _jardineriaContext = jardineriaContext;
        }
        public List<Cliente> GetClientes()
        {
            return _jardineriaContext.Clientes.ToList();
        }
        public Cliente? GetCliente(int clienteid)
        {
            return _jardineriaContext.Clientes.FirstOrDefault(c => c.CodigoCliente == clienteid);
        }
        public string insert(Cliente cliente)
        {
            _jardineriaContext.Clientes.Add(cliente);
            _jardineriaContext.SaveChanges();
            return "ok";
        }
        public string update(Cliente cliente)
        {
            _jardineriaContext.Clientes.Add(cliente);
            _jardineriaContext.SaveChanges();
            return "ok";
        }
         
        }
    }

