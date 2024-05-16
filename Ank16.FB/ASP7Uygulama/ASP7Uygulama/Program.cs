namespace ASP7Uygulama
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

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

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            //pattern: "{controller=Home}/{action=Index}/{id?}" //görev11

            //pattern: "{controller=Home}/{action=Index}/{id}"  //görev3

            //pattern: "{controller=Home}/{action=Index}/{id?}" //görev4

            //pattern: "{controller=Home}/{action=Index}/{id?}/{x}" //görev5

            //pattern: "{controller=Home}/{action=Index}/{id}/{x?}" //görev6

            //pattern: "{controller=Home}/{action=Index}/{id?}/{x?}" //görev7

            //pattern: "{controller=Home}/{action=Index}/{id}/{x}" //görev8

            //pattern: "{x}/{action=Index}/{id}/{controller=Home}/{y}" //görev9

            //pattern: "ank16/{controller=Home}/{action=Index}/{id}",//görev10
            //defaults: new { controller = "Home", action = "Index" }

            //pattern: "{controller=Home}/{action=Index}/{id:range(2,6)}" //görev12

            //pattern: "{controller=Home}/{action=Index}/{id:range(4,15)?}" //görev13

            //pattern: "{controller=Home}/{action=Index}/{id:alpha}" //görev14


            app.Run();
        }
    }
}
