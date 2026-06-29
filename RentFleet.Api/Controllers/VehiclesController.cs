using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentFleet.Api.Data;

namespace RentFleet.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VehiclesController : ControllerBase
{
    private readonly RentFleetDbContext _context;

    public VehiclesController(RentFleetDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetVehicles()
    {
        var vehicles = await _context.Vehicles
            .Include(v => v.Brand)
            .Include(v => v.CarModel)
            .Include(v => v.VehicleCategory)
            .Include(v => v.FuelType)
            .Include(v => v.TransmissionType)
            .Select(v => new
            {
                v.Id,
                v.LicensePlate,
                Brand = v.Brand.Name,
                Model = v.CarModel.Name,
                Category = v.VehicleCategory.Name,
                FuelType = v.FuelType.Name,
                Transmission = v.TransmissionType.Name,
                v.Year,
                v.Mileage,
                v.Horsepower,
                v.EngineCapacity,
                v.ImageUrl,
                v.IsActive
            })
            .ToListAsync();

        return Ok(vehicles);
    }
}
