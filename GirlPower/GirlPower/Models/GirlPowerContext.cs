using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GirlPower.Models
{

    public class GirlPowerContext : DbContext
    {
        public GirlPowerContext(DbContextOptions<GirlPowerContext> options) : base(options)
        {
        }

        public DbSet<Osoba> Osobe { get; set; }
        public DbSet<Klijent> Klijenti { get; set; }
        public DbSet<Uposlenik> Uposlenici { get; set; }
        public DbSet<Administrator> Administratori { get; set; }
        public DbSet<Kategorija> Kategorije { get; set; }
        public DbSet<Tretman> Tretmani { get; set; }
        public DbSet<Poruka> Poruke { get; set; }
        public DbSet<Obavijest> Obavijesti{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Osoba>().ToTable("Osoba");
           // modelBuilder.Entity<Klijent>().ToTable("Klijent");
           // modelBuilder.Entity<Uposlenik>().ToTable("Uposlenik");
           // modelBuilder.Entity<Administrator>().ToTable("Administrator");
            modelBuilder.Entity<Kategorija>().ToTable("Kategorija");
            modelBuilder.Entity<Tretman>().ToTable("Tretman");
            modelBuilder.Entity<Poruka>().ToTable("Poruka");
            modelBuilder.Entity<Obavijest>().ToTable("Obavijest").HasNoKey();
        }


    }
}
