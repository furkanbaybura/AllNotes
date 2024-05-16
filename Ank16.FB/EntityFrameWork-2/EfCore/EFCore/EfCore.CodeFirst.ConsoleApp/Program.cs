using EfCore.CodeFirst.ConsoleApp.Data;
using EfCore.CodeFirst.ConsoleApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;

namespace EfCore.CodeFirst.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            IConfiguration configuration = new ConfigurationBuilder()
                                               .AddJsonFile("appsettings.json")
                                               .AddEnvironmentVariables()
                                               .Build();

            string? connectionStr = configuration.GetConnectionString("OrnekDbConnection-Home");

            var appValue = configuration.GetSection("Cache:Dev").Value;
            var appValue2 = configuration.GetSection("Cache").GetSection("Test").Value;

            //DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseSqlServer(connectionStr);

            OrnekDbContext dbContext = new OrnekDbContext(configuration);

            //IEnumerable<Ogrenci> ogrenciler =  dbContext.Ogrenciler.ToList();
            //foreach (Ogrenci ogrenci in ogrenciler)
            //{
            //    Console.WriteLine(ogrenci.Id + " " + ogrenci.Adi + " " + ogrenci.Soyadi);
            //}

            var entries = dbContext.ChangeTracker.Entries();
            Console.WriteLine("ChangeTracker İlk");
            foreach (EntityEntry item in entries)
            {
                Console.WriteLine(item.Entity + " => " + item.State);
            }
            Console.WriteLine("ChangeTracker İlk bitti");

            while (true)
            {
                Console.Write("Yazar Adı : ");
                string yazarAdi = Console.ReadLine();

                Author author = new Author() { Name = yazarAdi };

                dbContext.Author.Add(author);

                Console.WriteLine("Devam etmek için Enter'a basınız");
                if (Console.ReadKey().Key != ConsoleKey.Enter)
                    break;
            }

            Console.WriteLine("Yazar ekleme işlemi bitti");


            int catId = 10; //(dbContext.Categories.MaxBy(c=>c.Id).Id) + 1;

            while (true)
            {
                Console.Write("Kategori Adı : ");
                string kategoriAdi = Console.ReadLine();

                Category category = new Category() { Id= catId, Name = kategoriAdi };

                dbContext.Categories.Add(category);

                Console.WriteLine("Devam etmek için Enter'a basınız");
                if (Console.ReadKey().Key != ConsoleKey.Enter)
                    break;

                catId++;
            }

            Console.WriteLine("Kategori ekleme işlemi bitti");

            entries = dbContext.ChangeTracker.Entries();

            foreach (EntityEntry item in entries)
            {
                Console.WriteLine(item.Entity + " => " + item.State);
            }

            dbContext.SaveChanges(); //Added => Insert Sorgusu, Modifed => Update Sorgusu, Deleted => Delete Sorgusu


            entries = dbContext.ChangeTracker.Entries();

            foreach (EntityEntry item in entries)
            {
                Console.WriteLine(item.Entity + " => " + item.State);
            }

            foreach (Author author in dbContext.Author)
            {
                Console.WriteLine(author.Id + " " + author.Name);

                if(author.Id % 2 == 0)
                {
                    author.Name += " Çift";
                }

            }

            entries = dbContext.ChangeTracker.Entries();

            foreach (EntityEntry item in entries)
            {
                Console.WriteLine(item.Entity + " => " + item.State);
            }


            Console.ReadLine();

        }
    }
}
