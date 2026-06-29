using RentFleet.Api.Data;

namespace RentFleet.Api.Services;

public class PlateGeneratorService
{
    private static readonly Random Random = new();

    //Lógica para gerar matrículas
    public string GenerateUniquePortuguesePlate()
    {
        const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        return
            $"{letters[Random.Next(letters.Length)]}" +
            $"{letters[Random.Next(letters.Length)]}-" +
            $"{Random.Next(10)}{Random.Next(10)}-" +
            $"{letters[Random.Next(letters.Length)]}" +
            $"{letters[Random.Next(letters.Length)]}";
    }

    public string GenerateUniquePortuguesePlate(RentFleetDbContext context)
    {
        string plate;

        //Gerar matrícula diferente
        do
        {
            plate = GenerateUniquePortuguesePlate();
        }
        while (context.Vehicles.Any(v => v.LicensePlate == plate));

        return plate;
    }
}
