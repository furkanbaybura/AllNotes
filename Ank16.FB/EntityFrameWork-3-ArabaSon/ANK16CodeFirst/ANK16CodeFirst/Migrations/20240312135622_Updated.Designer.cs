﻿// <auto-generated />
using ANK16CodeFirst.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ANK16CodeFirst.Migrations
{
    [DbContext(typeof(UygulamaDbContext))]
    [Migration("20240312135622_Updated")]
    partial class Updated
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ANK16CodeFirst.Entitites.Araba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LicenseNumber")
                        .HasColumnType("int");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LicenseNumber")
                        .IsUnique();

                    b.HasIndex("PersonNo");

                    b.ToTable("Arabalar");
                });

            modelBuilder.Entity("ANK16CodeFirst.Entitites.Kisi", b =>
                {
                    b.Property<int>("KisiTekilAnahtar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KisiTekilAnahtar"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Surname");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(39)");

                    b.Property<long>("TcKimlikNo")
                        .HasColumnType("bigint");

                    b.HasKey("KisiTekilAnahtar");

                    b.HasIndex("TcKimlikNo")
                        .IsUnique();

                    b.ToTable("People");
                });

            modelBuilder.Entity("ANK16CodeFirst.Entitites.Muhendis", b =>
                {
                    b.Property<int>("MühendisTekilAnahtar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MühendisTekilAnahtar"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MühendisTekilAnahtar");

                    b.ToTable("Engineer", (string)null);
                });

            modelBuilder.Entity("ANK16CodeFirst.Entitites.Plaka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Numarasi")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Numarasi")
                        .IsUnique();

                    b.ToTable("Plakalar");
                });

            modelBuilder.Entity("ArabaMuhendis", b =>
                {
                    b.Property<int>("ArabalarId")
                        .HasColumnType("int");

                    b.Property<int>("MuhendislerMühendisTekilAnahtar")
                        .HasColumnType("int");

                    b.HasKey("ArabalarId", "MuhendislerMühendisTekilAnahtar");

                    b.HasIndex("MuhendislerMühendisTekilAnahtar");

                    b.ToTable("ArabaMuhendis");
                });

            modelBuilder.Entity("ANK16CodeFirst.Entitites.Araba", b =>
                {
                    b.HasOne("ANK16CodeFirst.Entitites.Plaka", "Plaka")
                        .WithOne("Araba")
                        .HasForeignKey("ANK16CodeFirst.Entitites.Araba", "LicenseNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ANK16CodeFirst.Entitites.Kisi", "Kisi")
                        .WithMany("Arabalar")
                        .HasForeignKey("PersonNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kisi");

                    b.Navigation("Plaka");
                });

            modelBuilder.Entity("ArabaMuhendis", b =>
                {
                    b.HasOne("ANK16CodeFirst.Entitites.Araba", null)
                        .WithMany()
                        .HasForeignKey("ArabalarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ANK16CodeFirst.Entitites.Muhendis", null)
                        .WithMany()
                        .HasForeignKey("MuhendislerMühendisTekilAnahtar")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ANK16CodeFirst.Entitites.Kisi", b =>
                {
                    b.Navigation("Arabalar");
                });

            modelBuilder.Entity("ANK16CodeFirst.Entitites.Plaka", b =>
                {
                    b.Navigation("Araba")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}