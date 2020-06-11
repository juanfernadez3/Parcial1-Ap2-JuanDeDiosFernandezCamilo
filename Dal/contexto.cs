using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Parcial1_Ap2_JuanDeDiosFernandezCamilo.Models;
using Microsoft.EntityFrameworkCore;

namespace Parcial1_Ap2_JuanDeDiosFernandezCamilo.Dal
{
    public class contexto : DbContext
    {
        public DbSet<Articulos> Articulos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source = Data/Articulos.db");
        }
    }
}
