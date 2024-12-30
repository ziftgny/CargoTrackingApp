using Microsoft.EntityFrameworkCore;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace DataAccess.Concrete.EntityFramework
{
    public class CargoTrackingDatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=cargo_tracking;Username=postgres;Password=admin");
        }
        public DbSet<Kargo> kargolar { get; set; }
        public DbSet<Calisan> calisanlar { get; set; }
        public DbSet<Musteri> musteriler { get; set; }
        public DbSet<Paket_Turu> paket_turu { get; set; }
        public DbSet<Kargo_Durum> kargo_durum { get; set; }
    }
}
