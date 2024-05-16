using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CeylanMotors.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            
        }
    }
}
