﻿// <auto-generated />
using System;
using EfCore.CodeFirst.ConsoleApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCore.CodeFirst.ConsoleApp.Migrations
{
    [DbContext(typeof(OrnekDbContext))]
    [Migration("20240308072051_OgretmenlerTablosuEklendi")]
    partial class OgretmenlerTablosuEklendi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EfCore.CodeFirst.ConsoleApp.Data.Entities.Category", b =>
                {
                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EfCore.CodeFirst.ConsoleApp.Data.Entities.Ogrenci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eposta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ogrenciler");
                });

            modelBuilder.Entity("EfCore.CodeFirst.ConsoleApp.Data.Entities.Teacher", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint")
                        .HasColumnName("No")
                        .HasColumnOrder(1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("ntext")
                        .HasColumnName("Adres");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date")
                        .HasColumnName("Doğum Tarihi")
                        .HasColumnOrder(5);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("EPosta")
                        .HasColumnOrder(2);

                    b.Property<string>("Lessons")
                        .IsRequired()
                        .HasColumnType("ntext")
                        .HasColumnName("Dersler")
                        .HasColumnOrder(6);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("Adı")
                        .HasColumnOrder(3);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("Soyadı")
                        .HasColumnOrder(4);

                    b.HasKey("Id");

                    b.ToTable("Öğretmenler");
                });
#pragma warning restore 612, 618
        }
    }
}