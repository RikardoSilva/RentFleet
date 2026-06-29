using Microsoft.EntityFrameworkCore;
using RentFleet.Api.Data;
using RentFleet.Api.Seed;

var builder = WebApplication.CreateBuilder(args);

//Necessário para usar com Reac App
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp",
        policy =>
        {
            policy.WithOrigins("http://localhost:5173")
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});

// Add services to the container.
builder.Services.AddDbContext<RentFleetDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<RentFleetDbContext>();

    SeedData.SeedBrands(context);
    SeedData.SeedCarModels(context);
    SeedData.SeedVehicleCategories(context);
    SeedData.SeedFuelTypes(context);
    SeedData.SeedTransmissionTypes(context);
    SeedData.SeedVehicles(context);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowReactApp");

app.UseAuthorization();

app.MapControllers();

app.Run();
