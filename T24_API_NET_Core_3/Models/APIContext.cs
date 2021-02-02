using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T24_API_NET_Core_3.Models
{
    public class APIContext: DbContext
    {
        public APIContext(DbContextOptions<APIContext> options) : base(options) { }

        public DbSet<Cientifico> Cientificos { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Asignado_a> Asignado_As { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cientifico>()
                .HasKey(c => c.Dni);
        }
    }
}
