using DiyetApp.Besinler;
using DiyetApp.Kullanici;
using DiyetApp.Ogunler;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetApp.Contexts
{
    public class DiyetDbContext : DbContext
    {
        public DbSet<Admin> Adminler { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<BesinPorsiyon> BesinPorsiyonlar { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }
        public DbSet<UyeYemek> UyeYemekler { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database=DiyetAppDb; Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ogun>().HasData(
                new Ogun
                {
                    Id = 1,
                    OgunAd = "Sabah"
                },
                new Ogun
                {
                    Id = 2,
                    OgunAd = "Öğle"
                },
                new Ogun
                {
                    Id = 3,
                    OgunAd = "Akşam"
                }
                );
        }
    }
}
