using ASP9IDENTITY.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASP9IDENTITY.Data;

public class ASP9IDENTITYContext : IdentityDbContext<ASP9IDENTITYUser>
{
    public ASP9IDENTITYContext(DbContextOptions<ASP9IDENTITYContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
    
}
