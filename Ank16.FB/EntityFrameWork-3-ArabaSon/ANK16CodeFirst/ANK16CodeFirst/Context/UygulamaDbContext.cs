using ANK16CodeFirst.Entitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK16CodeFirst.Context
{
    internal class UygulamaDbContext : DbContext
    {


        public  DbSet<Araba> Arabalar  { get; set; }

        public DbSet<Plaka> Plakalar { get; set; }

        public DbSet<Kisi> Kisiler { get; set; }

        public DbSet<Muhendis> Muhendisler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ANK3-YZLMORT-14\\MSSQLSERVERANK16;Database=ANK16ArabaDb;Trusted_Connection=true;TrustServerCertificate=true");
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

            //8
            modelBuilder.Entity<Muhendis>().ToTable("Engineer");
            //9
            modelBuilder.Entity<Kisi>()
                        .Property(k => k.Ad)
                        .HasColumnName("Surname");
            //10
            modelBuilder.Entity<Araba>()
                        .Property(a => a.Marka)
                        .HasColumnType("nvarchar(20)");
            //11
            modelBuilder.Entity<Kisi>()
                        .Ignore(k => k.Adres);
            //12
            modelBuilder.Entity<Kisi>()
                        .HasIndex(k => k.TcKimlikNo)
                        .IsUnique();
            //13
            modelBuilder.Entity<Kisi>()
                        .HasKey(k => k.KisiTekilAnahtar);
            //14
            modelBuilder.Entity<Araba>().HasOne(a => a.Kisi)
                        .WithMany(k => k.Arabalar)
                        .HasForeignKey(a => a.PersonNo);
            //15
            modelBuilder.Entity<Araba>().HasOne(k => k.Plaka).WithOne(p => p.Araba).HasForeignKey<Araba>(k => k.PLNo);
            
            //16
            

                        
                        
            
                        
                       
		}
	}
}
