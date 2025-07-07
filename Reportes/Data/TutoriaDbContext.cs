using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tutoria.Models;

namespace Tutoria.Data
{
    internal class TutoriaDbContext : DbContext
    {
        public DbSet<PaisModel> Paises { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conexion = "Server=localhost;database=Paises;pwd=root;uid=root";
            var version_mysql= new MySqlServerVersion(new Version("5, 7, 24"));
            optionsBuilder.UseMySql(conexion, version_mysql);
        }
    }
}
