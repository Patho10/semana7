using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ferreteria.Models;
using Microsoft.EntityFrameworkCore;

namespace Ferreteria.Data
{
    public class HerramientaDbContext
    {
        public DbSet<Herramienta> Herramientas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            var conexion = "server=localhost;database=ferreteria;uid=root;pwd=";
            var version_mysql = new MySqlServerVersion(new Version("10.4.32"));
            optionsBuilder.UseMySql(conexion, version_mysql);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
