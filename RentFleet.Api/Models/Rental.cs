namespace RentFleet.Api.Models
{
    public class Rental
    {
        public int Id { get; set; }

        public int VehicleId { get; set; }

        public int CustomerId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
