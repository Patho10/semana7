using Alertas_Timer.Data;
using Alertas_Timer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alertas_Timer.Controllers
{
    public class AlertaController
    {
        private readonly TimerDbContext _timerDbContext;
        public AlertaController()
        {
            _timerDbContext = new TimerDbContext();
        }
        public List<AlertaModel> todos()
        {

            return _timerDbContext.Alertas
                .Include(parametros => parametros.Parametros)
                .Include(servidores => servidores.Servidores)
                .ToList();
        }
    }
}
