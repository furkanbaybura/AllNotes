using Galeri.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.DAL.Data
{
    public class GaleriDbContext : DbContext
    {
        public DbSet<Marka> Markalar {  get; set; }
        public DbSet<Mode> Modeller { get; set; }
        public GaleriDbContext(DbContextOptions options) : base(options) { }
    }
}
