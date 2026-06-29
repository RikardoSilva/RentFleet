using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentFleet.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVehicleSpecs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EngineCapacity",
                table: "Vehicles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Horsepower",
                table: "Vehicles",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EngineCapacity",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Horsepower",
                table: "Vehicles");
        }
    }
}
