using Alertas_Timer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alertas_Timer.Data
{
    internal class TimerDbContext : DbContext
    {
        public DbSet<ParametroModel> Parametros { get; set; }
        public DbSet<ServidorModel> Servidores { get; set; }


        public DbSet<AlertaModel> Alertas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var conexion = "server=localhost;database=Relaciones;uid=root;pwd=";
            var version_mysql = new MySqlServerVersion(new Version("8.0.33"));
            optionsBuilder.UseMySql(conexion, version_mysql);
        }
    }
}
