using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSecondUygulama2
{
	internal class ArabaContext : DbContext
	{
        public DbSet<Araba> Arabalar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=ANK3-YZLMORT-14\\MSSQLSERVERANK16;database=ArabaCodeFirst;trusted_connection=true;trustservercertificate=true");
		}
	}
	
}
