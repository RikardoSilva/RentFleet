using Microsoft.EntityFrameworkCore;
using RentFleet.Api.Models;

namespace RentFleet.Api.Data;

public class RentFleetDbContext : DbContext
{
    public RentFleetDbContext(DbContextOptions<RentFleetDbContext> options)
        : base(options)
    {

    }

    public DbSet<Vehicle> Vehicles { get; set; }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Rental> Rental { get; set; }

    public DbSet<Brand> Brands { get; set; }

    public DbSet<CarModel> CarModels { get; set; }

    public DbSet<VehicleCategory> VehicleCategories { get; set; }

    public DbSet<FuelType> FuelTypes { get; set; }

    public DbSet<TransmissionType> TransmissionTypes { get; set; }
}
