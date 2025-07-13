using Alertas_Timer.Data;
using Alertas_Timer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alertas_Timer.Controllers
{
    public class ServidoresController
    {
        private readonly TimerDbContext _timerDbContext;
        public ServidoresController()
        {
            _timerDbContext = new TimerDbContext();
        }

        public List<ServidorModel> todos()
        {
            return _timerDbContext.Servidores.ToList();
        }

        public ServidorModel uno(int id)
        {
            return _timerDbContext.Servidores.Find(id);
        }
        public string insertar(ServidorModel servidorModel)
        {
            if (servidorModel == null)
            {
                MessageBox.Show("Los Datos del Servidor estan vacio, por favor complete los campos");
                return "error";
            }
            else
            {
                _timerDbContext.Servidores.Add(servidorModel);
                _timerDbContext.SaveChanges();
                return "ok";
            }
        }
    }
}
