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
               var connectionString = "server=localhost; database=MilesCarRental; user=; password=";
               optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}
