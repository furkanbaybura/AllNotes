using ANK16EsyaAJAX.Data;
using Microsoft.EntityFrameworkCore;

namespace ANK16EsyaAJAX.Context
{
    public class EsyaDbContext : DbContext
    {
        public DbSet<Esya> Esyalar { get; set; }
        public EsyaDbContext
            (DbContextOptions<EsyaDbContext>
            options) : base(options)
        {
        }
    }
}
