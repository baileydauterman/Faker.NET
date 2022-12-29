using Faker.NET.EN.Location;

namespace Faker.NET.Tests.Locales.EN
{
    internal static class Locations
    {
        public static void Test()
        {
            Console.WriteLine(Location.City);
            Console.WriteLine(Location.State);
            Console.WriteLine(Location.StateAbbreviation);
            Console.WriteLine(Location.BuildingNumber);
            Console.WriteLine(Location.Address);
            Console.WriteLine(Location.ZipCode);
            Console.WriteLine(Location.ZipCodeLongFormat);
        }
    }
}
