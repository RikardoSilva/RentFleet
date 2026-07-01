namespace RentFleet.Api.DTOs
{
    public class CreateVehicleDto
    {
        public string? LicensePlate { get; set; }

        public bool GenerateLicensePlate { get; set; } = true;

        public int BrandId { get; set; }

        public int CarModelId { get; set; }

        public int VehicleCategoryId { get; set; }

        public int FuelTypeId { get; set; }

        public int TransmissionId { get; set; }

        public int Year { get; set; }

        public int Mileage { get; set; }

        public int Horsepower { get; set; }

        public int EngineCapacity { get; set; }

        public string? ImageUrl { get; set; }
    }
}
