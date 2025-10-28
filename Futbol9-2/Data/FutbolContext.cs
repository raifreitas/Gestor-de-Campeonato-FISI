using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Futbol9_2.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Futbol9_2.Data
{
    class FutbolContext : DbContext 
    {
        // Se definen que clases se convertiran en tablas
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }

        // Definimos donde se conectara 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=RAI-FREITAS\SQLEXPRESS;Database=CampeonatoFISI_DB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
