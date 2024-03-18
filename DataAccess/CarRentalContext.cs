using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class CarRentalContext : DbContext
    {
        public DbSet<VehicleEntity> Vehicles { get; set; }
        public DbSet<LocationEntity> Locations { get; set; }
        public DbSet<LogEntity> Logs { get; set; }

        //Defines the connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               var connectionString = "server=localhost; database=MilesCarRental; user=root; password=dannia.20";
               optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VehicleEntity>().HasData(
                new VehicleEntity
                {
                    VehicleId = "2a4f2245-f6ab-4626-bf5f-c16216dd6822", 
                    VehicleName = "Hyundai Accent", 
                    IsAvailable = true, 
                    VehicleCapacity = 5,
                    QuantitySmallSuitcases = 1,
                    QuantityLargeSuitcases = 2,
                    Transmission = "Automática",
                    LocationId = "4308fddc-f3dd-4aa8-87ec-c21b89305b3b"
                },
                new VehicleEntity
                {
                    VehicleId = "0a2d473b-fe62-4f66-9537-96848c6d5c4b",
                    VehicleName = "Kia Picanto",
                    IsAvailable = true,
                    VehicleCapacity = 5,
                    QuantitySmallSuitcases = 1,
                    QuantityLargeSuitcases = 1,
                    Transmission = "Manual",
                    LocationId = "4308fddc-f3dd-4aa8-87ec-c21b89305b3b"
                },
                new VehicleEntity
                {
                    VehicleId = "b1820ce5-f0a1-4923-b362-b10ebddc7ad4",
                    VehicleName = "Suzuki Swift",
                    IsAvailable = true,
                    VehicleCapacity = 5,
                    QuantitySmallSuitcases = 1,
                    QuantityLargeSuitcases = 1,
                    Transmission = "Manual",
                    LocationId = "4308fddc-f3dd-4aa8-87ec-c21b89305b3b"
                },
                new VehicleEntity
                {
                    VehicleId = "74180e03-50cb-4bf3-b645-ef538f769493",
                    VehicleName = "Renault Duster",
                    IsAvailable = true,
                    VehicleCapacity = 5,
                    QuantityLargeSuitcases = 3,
                    Transmission = "Manual",
                    LocationId = "4308fddc-f3dd-4aa8-87ec-c21b89305b3b"
                },
                new VehicleEntity
                {
                    VehicleId = "7cb616c3-d5d1-4d34-8dd5-d83e51ea3fa8",
                    VehicleName = "Changan E-Sta",
                    IsAvailable = true,
                    VehicleCapacity = 5,
                    QuantitySmallSuitcases = 1,
                    QuantityLargeSuitcases = 1,
                    Transmission = "Automática",
                    LocationId = "4308fddc-f3dd-4aa8-87ec-c21b89305b3b"
                },
                new VehicleEntity
                {
                    VehicleId = "d70f3c46-0055-4b30-946a-98486ec75993",
                    VehicleName = "Renault Koleos",
                    IsAvailable = true,
                    VehicleCapacity = 5,
                    QuantityLargeSuitcases = 3,
                    Transmission = "Automática",
                    LocationId = "4308fddc-f3dd-4aa8-87ec-c21b89305b3b"
                },
                new VehicleEntity
                {
                    VehicleId = "0c4c3455-4330-4e35-b0a7-9ec7e42c6490",
                    VehicleName = "Hyundai Creta",
                    IsAvailable = true,
                    VehicleCapacity = 5,
                    QuantitySmallSuitcases = 1,
                    QuantityLargeSuitcases = 1,
                    Transmission = "Automática",
                    LocationId = "4308fddc-f3dd-4aa8-87ec-c21b89305b3b"
                }
                );

            modelBuilder.Entity<LocationEntity>().HasData(
                new LocationEntity
                {
                    LocationId = "4308fddc-f3dd-4aa8-87ec-c21b89305b3b",
                    LocationName = "location"
                }
                );
        }
    }
}
