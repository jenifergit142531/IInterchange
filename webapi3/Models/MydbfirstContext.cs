using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace webapi3.Models;

public partial class MydbfirstContext : DbContext
{
    public MydbfirstContext()
    {
    }

    public MydbfirstContext(DbContextOptions<MydbfirstContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CarParking> CarParkings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=REV-PG02C4Y5;Initial Catalog=mydbfirst;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;Command Timeout=0");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CarParking>(entity =>
        {
            entity.HasKey(e => e.Tokenid).HasName("PK__CarParki__AC17DF2F82207735");

            entity.ToTable("CarParking");

            entity.Property(e => e.Tokenid).HasColumnName("tokenid");
            entity.Property(e => e.Carname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carname");
            entity.Property(e => e.Carnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carnumber");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.Parkinglot)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("parkinglot");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
