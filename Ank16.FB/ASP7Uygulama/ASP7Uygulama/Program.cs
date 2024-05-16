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

            //pattern: "{controller=Home}/{action=Index}/{id?}" //g�rev11

            //pattern: "{controller=Home}/{action=Index}/{id}"  //g�rev3

            //pattern: "{controller=Home}/{action=Index}/{id?}" //g�rev4

            //pattern: "{controller=Home}/{action=Index}/{id?}/{x}" //g�rev5

            //pattern: "{controller=Home}/{action=Index}/{id}/{x?}" //g�rev6

            //pattern: "{controller=Home}/{action=Index}/{id?}/{x?}" //g�rev7

            //pattern: "{controller=Home}/{action=Index}/{id}/{x}" //g�rev8

            //pattern: "{x}/{action=Index}/{id}/{controller=Home}/{y}" //g�rev9

            //pattern: "ank16/{controller=Home}/{action=Index}/{id}",//g�rev10
            //defaults: new { controller = "Home", action = "Index" }

            //pattern: "{controller=Home}/{action=Index}/{id:range(2,6)}" //g�rev12

            //pattern: "{controller=Home}/{action=Index}/{id:range(4,15)?}" //g�rev13

            //pattern: "{controller=Home}/{action=Index}/{id:alpha}" //g�rev14


            app.Run();
        }
    }
}
