using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReservaApp.Data.Mappings;
using ReservaApp.Models;

namespace ReservaApp.Data
{
    public class ReservaDataContext : DbContext
    {
        public DbSet<Equipamento> Equipamentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=ReservaApp;User ID=sa;Password=1q2w3e4r@#$;Encrypt=True;TrustServerCertificate=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EquipamentoMap());
        }
    }
}