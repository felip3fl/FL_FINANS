using FL.Point.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL.Point.Data.Data
{
    public class DataBaseContext : DbContext
    {
        public DbSet<EletronicPoint> EletronicPoints { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqllocaldb;Initial Catalog=CursoEFCore;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Modelo novo de configurar as tabelas, método com 1 linha:
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataBaseContext).Assembly);
        }
    }
}
