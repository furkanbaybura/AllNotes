using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DBFirstUygulama1.Models;

public partial class ArabalarContext : DbContext
{
    public ArabalarContext()
    {
    }

    public ArabalarContext(DbContextOptions<ArabalarContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Arabalar> Arabalars { get; set; }

    public virtual DbSet<Kisiler> Kisilers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=ANK3-YZLMORT-14\\MSSQLSERVERANK16; database=Arabalar;trusted_connection=true;trustservercertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Arabalar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Arabalar__3214EC27CFD07367");

            entity.ToTable("Arabalar");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Marka).HasMaxLength(20);

            entity.HasOne(d => d.Kisi).WithMany(p => p.Arabalars)
                .HasForeignKey(d => d.KisiId)
                .HasConstraintName("FK__Arabalar__KisiId__398D8EEE");
        });

        modelBuilder.Entity<Kisiler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Kisiler__3214EC277CD78A23");

            entity.ToTable("Kisiler");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ad).HasMaxLength(30);
            entity.Property(e => e.Soyad).HasMaxLength(30);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
