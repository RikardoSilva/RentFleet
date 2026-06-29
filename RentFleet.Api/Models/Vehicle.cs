using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace RentFleet.Api.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string LicensePlate { get; set; } = string.Empty;

        public int BrandId { get; set; }
        public Brand Brand { get; set; } = null!;

        public int CarModelId { get; set; }
        public CarModel CarModel { get; set; } = null!;

        public int VehicleCategoryId { get; set; }
        public VehicleCategory VehicleCategory { get; set; } = null!;

        public int FuelTypeId { get; set; }
        public FuelType FuelType { get; set; } = null!;

        public int TransmissionTypeId {  get; set; }
        public TransmissionType TransmissionType { get; set; } = null!;

        public int Year { get; set; }

        public int Mileage { get; set; }

        public int Horsepower { get; set; }

        public int EngineCapacity { get; set; }

        public string? ImageUrl { get; set; }

        public bool IsActive { get; set; } = true;

    }
}
