namespace RentFleet.Api.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set;} = string.Empty;

        public string DrivingLicenseNumber {  get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}
