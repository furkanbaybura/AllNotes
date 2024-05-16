using Microsoft.EntityFrameworkCore;

namespace ASP6UYGULAMA.Context
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options): base(options)
        {
            
        }
    }
}
