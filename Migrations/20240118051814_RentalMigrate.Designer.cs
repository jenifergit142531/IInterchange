﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapi2.Context;

#nullable disable

namespace webapi2.Migrations
{
    [DbContext(typeof(RentalContext))]
    [Migration("20240118051814_RentalMigrate")]
    partial class RentalMigrate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("webapi2.Models.PropRent", b =>
                {
                    b.Property<int>("PropId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AgentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MonthlyRental")
                        .HasColumnType("int");

                    b.Property<int>("Tenure")
                        .HasColumnType("int");

                    b.HasKey("PropId");

                    b.ToTable("propRents");
                });
#pragma warning restore 612, 618
        }
    }
}