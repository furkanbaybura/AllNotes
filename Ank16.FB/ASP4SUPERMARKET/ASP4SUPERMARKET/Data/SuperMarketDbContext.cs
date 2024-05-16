using ASP4SUPERMARKET.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP4SUPERMARKET.Data
{
    public class SuperMarketDbContext : DbContext
    {
        public SuperMarketDbContext(DbContextOptions<SuperMarketDbContext> contextOptions) : base(contextOptions)
        {
            
        }
        public DbSet<Urun> urunler { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
