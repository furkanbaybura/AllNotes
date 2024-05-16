using EfCore.CodeFirst.ConsoleApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.CodeFirst.ConsoleApp.Data
{
    public class OrnekDbContext : DbContext
    {
        //public OrnekDbContext(DbContextOptions options) :base(options)
        //{}

        private IConfiguration _configuration;

        //public OrnekDbContext()
        //{

        //}

        public OrnekDbContext(IConfiguration configuration = null) {
            if(configuration == null)
            {
                _configuration = new ConfigurationBuilder()
                       .AddJsonFile("appsettings.json")
                       .AddEnvironmentVariables()
                       .Build();
            }
            else
            {
                _configuration = configuration;

            }
        }

        public DbSet<Ogrenci> Ogrenciler { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<BookOne> Books { get; set; }
        public DbSet<BookTypeOne> BookTypes { get; set; }

        public DbSet<BookTwo> BooksTwo { get; set; }
        public DbSet<BookTypeTwo> BookTypesTwo { get; set; }

        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //optionsBuilder.UseSqlServer("Data Source=ANK3-YZLMORT-08\\MSSQLSERVER2;Initial Catalog=OysAnk16;Integrated Security=True;Encrypt=False");
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("OrnekDbConnection-Home"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Category>().HasNoKey();
            //modelBuilder.Entity<Ogrenci>().HasKey("OgrenciNo");

            modelBuilder.Entity<Lesson>().ToTable("Dersler"); //[Table("Dersler")]

            modelBuilder.Entity<Lesson>()
                        .Property(l => l.Name)
                        .HasColumnName("DersAdı")
                        .HasColumnOrder(1)
                        .HasColumnType("nvarchar(10)");

            modelBuilder.Entity<Lesson>()
                        .Property(l => l.Description)
                        .HasColumnName("DersAciklama")
                        .HasColumnOrder(4)
                        .HasColumnType("nvarchar(100)")
                        .IsRequired(false);

            modelBuilder.Entity<Lesson>()
                        .Property(l => l.Credit)
                        .HasColumnOrder(3)
                        .HasColumnType("tinyint");

            modelBuilder.Entity<Lesson>()
                        .Property(l => l.LessonBeginDate)
                        .HasColumnName("DersBaslangicTarihi")
                        .HasColumnType("date");

            modelBuilder.Entity<Lesson>()
                        .Property(l => l.IsActive)
                        .HasColumnType("bit");


            //modelBuilder.Entity<Book>().HasForeingKey(b => b.AuthorFK); // EF 6 da oluşturulan FK yapısı

            modelBuilder.Entity<Book>()
                        .HasOne(b => b.Author)
                        .WithMany(a => a.Books)
                        .HasForeignKey(b => b.AuthorFK)
                        .IsRequired();


        }
    }
}
