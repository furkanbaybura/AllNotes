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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ANK3-YZLMORT-14\\MSSQLSERVERANK16;Database=ArabaDB;Trusted_Connection=true;TrustServerCertificate=true");
        }

    }
}
