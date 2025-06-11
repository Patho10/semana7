using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Mi_primera_vez.Controladores
{
    internal class ClientesController
    {
        public List<Modelos.ClienteModelo> _clienteModelo = new List<Modelos.ClienteModelo>();

        public List<Modelos.ClienteModelo> todos()
        {
            return _clienteModelo;
        }
        public Modelos.ClienteModelo uno(int ClienteId)
        {

            return _clienteModelo.Find(c => c.ClienteId == ClienteId);
        }
        public string Insertar(Modelos.ClienteModelo cliente)
        {
            try
            {
                _clienteModelo.Add(cliente);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Actualizar(Modelos.ClienteModelo cliente)
        {
            var cl = _clienteModelo.Find(c => c.ClienteId == cliente.ClienteId);
            if (cl != null)
            {
                cl.CedulaRuc = cliente.CedulaRuc;
                cl.Correo = cliente.Correo;
                cl.Direccion = cliente.Direccion;
                cl.Nombre = cliente.Nombre;
                cl.Telefono = cliente.Telefono;
                return "ok";
            }
            else
            {
                return "cliente no encontrado";
            }
        }
        public string Eliminar(int ClienteId)
        {
            var cl = _clienteModelo.RemoveAll(c => c.ClienteId == ClienteId);
            if (cl > 0)
            {
                return "ok";
            }
            else
            {
                return "No se elimino el cliente";
            }
        }
    }
    }
