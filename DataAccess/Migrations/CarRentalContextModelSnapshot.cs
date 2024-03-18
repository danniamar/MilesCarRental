﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(CarRentalContext))]
    partial class CarRentalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Entities.LocationEntity", b =>
                {
                    b.Property<string>("LocationId")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("IsDestination")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsOrigin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.Property<DateTime>("Registration")
                        .HasColumnType("datetime(6)");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Entities.LogEntity", b =>
                {
                    b.Property<string>("LogId")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("LocationDestination")
                        .HasMaxLength(50)
                        .HasColumnType("tinyint(50)");

                    b.Property<bool>("LocationOrigin")
                        .HasMaxLength(50)
                        .HasColumnType("tinyint(50)");

                    b.Property<DateTime>("Registration")
                        .HasColumnType("datetime(6)");

                    b.HasKey("LogId");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("Entities.VehicleEntity", b =>
                {
                    b.Property<string>("VehicleId")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LocationId")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("QuantityLargeSuitcases")
                        .HasColumnType("int");

                    b.Property<int>("QuantitySmallSuitcases")
                        .HasColumnType("int");

                    b.Property<string>("Transmission")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("VehicleCapacity")
                        .HasColumnType("int");

                    b.Property<string>("VehicleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("VehicleId");

                    b.HasIndex("LocationId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Entities.VehicleEntity", b =>
                {
                    b.HasOne("Entities.LocationEntity", "Location")
                        .WithMany("Vehicles")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Entities.LocationEntity", b =>
                {
                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
