using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace aspclass4.Models;

public partial class MydbfirstContext : DbContext
{
    public MydbfirstContext()
    {
    }

    public MydbfirstContext(DbContextOptions<MydbfirstContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ElecInventory> ElecInventories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=REV-PG02C4Y5;Initial Catalog=mydbfirst;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;Command Timeout=0");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ElecInventory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ElecInve__3213E83FF227F4B4");

            entity.ToTable("ElecInventory");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Pname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pname");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("price");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Updateddate)
                .HasColumnType("datetime")
                .HasColumnName("updateddate");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
