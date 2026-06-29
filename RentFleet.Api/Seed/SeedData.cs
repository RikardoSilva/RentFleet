using RentFleet.Api.Data;
using RentFleet.Api.Models;
using RentFleet.Api.Services;

namespace RentFleet.Api.Seed;

public static class SeedData
{
    public static void SeedBrands(RentFleetDbContext context)
    {
        //Se já existir dados, faz return
        if (context.Brands.Any())
            return;

        var brands = new List<Brand>
            {
                new() { Name = "Renault" },
                new() { Name = "Peugeot" },
                new() { Name = "BMW" },
                new() { Name = "Mercedes" },
                new() { Name = "Volkswagen" },
                new() { Name = "Audi" },
                new() { Name = "Toyota" },
                new() { Name = "Ford" },
                new() { Name = "Skoda" },
                new() { Name = "Hyundai" },
                new() { Name = "Citroen" },
                new() { Name = "Opel" }
            };

        //Inserir vários de uma vez
        context.Brands.AddRange(brands);
        context.SaveChanges();
    }

    public static void SeedCarModels(RentFleetDbContext context)
    {
        if (context.CarModels.Any())
            return;

        var renault = context.Brands.First(b => b.Name == "Renault");
        var bmw = context.Brands.First(b => b.Name == "BMW");
        var volkswagen = context.Brands.First(b => b.Name == "Volkswagen");
        var peugeot = context.Brands.First(b => b.Name == "Peugeot");

        var models = new List<CarModel>
        {
            new() { Name = "Clio", BrandId = renault.Id },
            new() { Name = "Mégane", BrandId = renault.Id },
            new() { Name = "Captur", BrandId = renault.Id },

            new() { Name = "Série 1", BrandId = bmw.Id },
            new() { Name = "Série 3", BrandId = bmw.Id },
            new() { Name = "X1", BrandId = bmw.Id },

            new() { Name = "Golf", BrandId = volkswagen.Id },
            new() { Name = "Polo", BrandId = volkswagen.Id },
            new() { Name = "Tiguan", BrandId = volkswagen.Id },

            new() { Name = "208", BrandId = peugeot.Id },
            new() { Name = "408", BrandId = peugeot.Id },
            new() { Name = "3008", BrandId = peugeot.Id }
        };

        context.CarModels.AddRange(models);
        context.SaveChanges();
    }

    public static void SeedVehicleCategories(RentFleetDbContext context)
    {
        if (context.VehicleCategories.Any())
            return;

        var categories = new List<VehicleCategory>
        {
            new() { Name = "Pequeno" },
            new() { Name = "Médio" },
            new() { Name = "Grande" },
            new() { Name = "SUV" },
            new() { Name = "Premium" },
            new() { Name = "Carrinha" }
        };

        context.VehicleCategories.AddRange(categories);
        context.SaveChanges();
    }

    public static void SeedFuelTypes(RentFleetDbContext context)
    {
        if (context.FuelTypes.Any())
            return;

        var types = new List<FuelType>
        {
            new() { Name = "Gasolina" },
            new() { Name = "Gasóleo" },
            new() { Name = "Hibrido" },
            new() { Name = "Elétrico" },
            new() { Name = "GPL" }
        };

        context.FuelTypes.AddRange(types);
        context.SaveChanges();
    }

    public static void SeedTransmissionTypes(RentFleetDbContext context)
    {
        if (context.TransmissionTypes.Any())
            return;

        var transmissionTypes = new List<TransmissionType>
        {
            new() { Name = "Manual" },
            new() { Name = "Automática" }
        };

        context.TransmissionTypes.AddRange(transmissionTypes);
        context.SaveChanges();
    }

    public static void SeedVehicles(RentFleetDbContext context)
    {
        if (context.Vehicles.Any())
            return;

        var plateGenerator = new PlateGeneratorService();

        var renault = context.Brands.First(b => b.Name == "Renault");
        var bmw = context.Brands.First(b => b.Name == "BMW");
        var volkswagen = context.Brands.First(b => b.Name == "Volkswagen");
        var peugeot = context.Brands.First(b => b.Name == "Peugeot");

        var clio = context.CarModels.First(m => m.Name == "Clio");
        var megane = context.CarModels.First(m => m.Name == "Mégane");
        var serie1 = context.CarModels.First(m => m.Name == "Série 1");
        var golf = context.CarModels.First(m => m.Name == "Golf");
        var peugeot208 = context.CarModels.First(m => m.Name == "208");

        var pequeno = context.VehicleCategories.First(c => c.Name == "Pequeno");
        var medio = context.VehicleCategories.First(c => c.Name == "Médio");
        var premium = context.VehicleCategories.First(c => c.Name == "Premium");

        var gasoleo = context.FuelTypes.First(f => f.Name == "Gasóleo");
        var gasolina = context.FuelTypes.First(f => f.Name == "Gasolina");

        var manual = context.TransmissionTypes.First(t => t.Name == "Manual");
        var automatica = context.TransmissionTypes.First(t => t.Name == "Automática");

        var vehicles = new List<Vehicle>
        {
            new()
            {
                LicensePlate = plateGenerator.GenerateUniquePortuguesePlate(context),
                BrandId = renault.Id,
                CarModelId = clio.Id,
                VehicleCategoryId = pequeno.Id,
                FuelTypeId = gasolina.Id,
                TransmissionTypeId = manual.Id,
                Year = 2024,
                Mileage = 4500,
                Horsepower = 100,
                EngineCapacity = 999
            },
            new()
            {
                LicensePlate = plateGenerator.GenerateUniquePortuguesePlate(context),
                BrandId = peugeot.Id,
                CarModelId = peugeot208.Id,
                VehicleCategoryId = pequeno.Id,
                FuelTypeId = gasolina.Id,
                TransmissionTypeId = automatica.Id,
                Year = 2024,
                Mileage = 3200,
                Horsepower = 100,
                EngineCapacity = 1199
            },
            new()
            {
                LicensePlate = plateGenerator.GenerateUniquePortuguesePlate(context),
                BrandId = renault.Id,
                CarModelId = megane.Id,
                VehicleCategoryId = medio.Id,
                FuelTypeId = gasoleo.Id,
                TransmissionTypeId = manual.Id,
                Year = 2024,
                Mileage = 7600,
                Horsepower = 150,
                EngineCapacity = 1968
            },
            new()
            {
                LicensePlate = plateGenerator.GenerateUniquePortuguesePlate(context),
                BrandId = bmw.Id,
                CarModelId = serie1.Id,
                VehicleCategoryId = premium.Id,
                FuelTypeId = gasoleo.Id,
                TransmissionTypeId = automatica.Id,
                Year = 2025,
                Mileage = 4000,
                Horsepower = 150,
                EngineCapacity = 1995
            }
        };

        context.Vehicles.AddRange(vehicles);
        context.SaveChanges();
    }
}