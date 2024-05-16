using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Ev_Exercise.Context
{
	internal class EvContext : DbContext
	{
		public DbSet<Daire> Daireler { get; set; }
		public DbSet<Kisi> Kisiler { get; set; }
		public DbSet<Tapu> Tapular { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=ANK3-YZLMORT-14\\MSSQLSERVERANK16;Database=EvTapu;Trusted_Connection=true;TrustServerCertificate=true");
		}

	}

}
