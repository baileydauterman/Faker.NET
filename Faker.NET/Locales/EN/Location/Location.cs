namespace Faker.NET.Locales.EN.Location
{
    public static class Location
    {
        public static string City => city.Get();

        public static string State => states.Get();

        public static string StateAbbreviation => states.Get(true);

        public static string BuildingNumber => buildingNumber.Get().ToString();

        public static string Address => $"{BuildingNumber} {City}, {StateAbbreviation} {ZipCode}";

        public static string ZipCode => zipCode.Get();

        public static string ZipCodeLongFormat => zipCode.Get(true);

        private static City city = new();
        private static States states = new();
        private static ZipCode zipCode = new();
        private static BuildingNumber buildingNumber = new();
    }
}
