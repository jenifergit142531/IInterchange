using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DBFirstApproach.Models;

public partial class PropcareContext : DbContext
{
    public PropcareContext()
    {
    }

    public PropcareContext(DbContextOptions<PropcareContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LuxePropCare> LuxePropCares { get; set; }

    public virtual DbSet<LuxePropMgmt> LuxePropMgmts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=REV-PG02C4Y5;Initial Catalog=propcare;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;Command Timeout=0");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LuxePropCare>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LuxePropCare");

            entity.Property(e => e.Address)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.Pname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pname");
            entity.Property(e => e.Propid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("propid");
            entity.Property(e => e.Requesteddate)
                .HasColumnType("datetime")
                .HasColumnName("requesteddate");
            entity.Property(e => e.Service)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("service");
        });

        modelBuilder.Entity<LuxePropMgmt>(entity =>
        {
            entity.HasKey(e => e.Propid).HasName("PK__LuxeProp__DEA0306C3C281B62");

            entity.ToTable("LuxePropMgmt");

            entity.Property(e => e.Propid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("propid");
            entity.Property(e => e.Address)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.Partnername)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("partnername");
            entity.Property(e => e.Pname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pname");
            entity.Property(e => e.Requesteddate)
                .HasColumnType("datetime")
                .HasColumnName("requesteddate");
            entity.Property(e => e.Service)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("service");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
