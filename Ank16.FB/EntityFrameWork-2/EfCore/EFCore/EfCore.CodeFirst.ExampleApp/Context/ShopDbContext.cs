using EfCore.CodeFirst.ExampleApp.Context.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.CodeFirst.ExampleApp.Context
{
	public class ShopDbContext : DbContext
	{

		//public DbSet<Customer> Customers { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<EmployeeInfo> EmployeesInfo { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Server=ANK3-YZLMORT-14\\MSSQLSERVERANK16;Initial Catalog=ShopDb;Integrated Security=True;Encrypt=False");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			//modelBuilder.Entity<Customer>().HasKey(c => c.CustomerNumber);
			//modelBuilder.Entity<Customer>().Property(c => c.CustomerNumber).UseIdentityColumn(5, 10);
			//modelBuilder.Entity<Customer>().Property(c => c.Surname).HasMaxLength(10).IsUnicode(false);
			//modelBuilder.Entity<Customer>().Property(c => c.Address).IsFixedLength().HasMaxLength(50);

			//modelBuilder.Entity<Customer>().Property(c => c.Address).IsRequired(false);
			//modelBuilder.Entity<Customer>().Property(c => c.Email).IsRequired();

			//modelBuilder.Entity<Customer>().ToTable("Müşterler");

			//modelBuilder.Entity<Customer>().Property(c => c.Surname)

			// char(5)      IsFixedLength().HasMaxLength(5).IsUnicode(false);
			// nchar(5)     IsFixedLength().HasMaxLength(5).IsUnicode(true);

			// varchar(5)      IsFixedLength(false).HasMaxLength(5).IsUnicode(false);
			// nvarchar(5)      IsFixedLength(true).HasMaxLength(5).IsUnicode(true);

			modelBuilder.Entity<Employee>()
						.HasOne(e => e.EmployeeInfo)
						.WithOne(ei => ei.Employee)
						.HasForeignKey<EmployeeInfo>(ei => ei.Id);

			modelBuilder.Entity<Order>()
						.HasOne(o => o.Customer)
						.WithMany(c => c.Orders);

			//modelBuilder.Entity<Customer>()
			//            .HasMany(c => c.Orders)
			//            .WithOne(o => o.Customer);

			modelBuilder.Entity<Order>()
						.HasOne(o => o.Employee)
						.WithMany(e => e.Orders);

			modelBuilder.Entity<Order>()
						.HasMany(o => o.OrderDetails)
						.WithOne(od => od.Order);

			modelBuilder.Entity<Product>()
						.HasMany(p => p.OrderDetails)
						.WithOne(od => od.Product);

			modelBuilder.Entity<OrderShipping>()
						.HasKey(os => new { os.OrderId, os.ShippingId });

			//modelBuilder.Entity<OrderShipping>().HasNoKey();
			//modelBuilder.Entity<OrderShipping>().HasIndex(os => new { os.OrderId, os.ShippingId }).IsUnique();

			modelBuilder.Entity<Order>()
						.HasOne(o => o.OrderShipping)
						.WithOne(os => os.Order)
						.HasForeignKey<OrderShipping>(os => os.OrderId);

			modelBuilder.Entity<OrderShipping>()
						.HasOne(os => os.Shipping)
						.WithMany(s => s.OrderShippings);
			//modelBuilder.Entity<Employee>().HasData(
			//	new Employee() { Id = 1, Name = "Çalışan Adı 1", Surname = "Çalışan Soyadı 1", Title = "Beyaz Çalışan" },
			//	new Employee()
			//	{
			//		Id = 2,
			//		Name = "Çalışan Adı 2",
			//		Surname = "Çalışan Soyadı 2",
			//		Title = "Beyaz Çalışan",
			//		EmployeeInfo = new EmployeeInfo()
			//		{
			//			Id = 2,
			//			Phone = "0123456789",
			//			Email = "info@gmail.com",
			//			BirthDate = new DateOnly(1998, 31, 07)
			//		}
			//	});
			modelBuilder.Entity<Product>().HasData(
				new Product() { Id = 1, Name = "TV", Description = "Güzel", Price = 1200.0m, Stock = 15, IsActive = true },
				new Product() { Id = 2, Name = "PC", Description = "Güzel", Price = 1500.0m, Stock = 15, IsActive = true },
				new Product() { Id = 3, Name = "PS", Description = "Güzel", Price = 1100.0m, Stock = 15, IsActive = true },
				new Product() { Id = 4, Name = "PHONE", Description = "Güzel", Price = 1900.0m, Stock = 15, IsActive = true });
		}


	}
}
