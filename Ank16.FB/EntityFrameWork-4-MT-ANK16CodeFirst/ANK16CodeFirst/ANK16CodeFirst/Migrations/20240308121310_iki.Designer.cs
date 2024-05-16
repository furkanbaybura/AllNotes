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
    [Migration("20240308121310_iki")]
    partial class iki
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

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlakaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlakaId")
                        .IsUnique();

                    b.ToTable("Arabalar");
                });

            modelBuilder.Entity("ANK16CodeFirst.Entitites.Plaka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Numarasi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Plakalar");
                });

            modelBuilder.Entity("ANK16CodeFirst.Entitites.Araba", b =>
                {
                    b.HasOne("ANK16CodeFirst.Entitites.Plaka", "Plaka")
                        .WithOne("Araba")
                        .HasForeignKey("ANK16CodeFirst.Entitites.Araba", "PlakaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plaka");
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