using System.Text.RegularExpressions;

namespace RentFleet.Api.Helpers;

public class LicensePlateHelper
{
    public static bool IsValidPortuguesePlate(string licensePlate)
    {
        return Regex.IsMatch(
                licensePlate,
                "^[A-Z]{2}-[0-9]{2}-[A-Z]{2}$"
              );
    }

    public static string Normalize(string licensePlate)
    {
        return licensePlate.Trim().ToUpper();
    }
}