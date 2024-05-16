using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ASP9IDENTITY.Data;
using ASP9IDENTITY.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ASP9IDENTITYContextConnection") ?? throw new InvalidOperationException("Connection string 'ASP9IDENTITYContextConnection' not found.");

builder.Services.AddDbContext<ASP9IDENTITYContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<ASP9IDENTITYUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ASP9IDENTITYContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
