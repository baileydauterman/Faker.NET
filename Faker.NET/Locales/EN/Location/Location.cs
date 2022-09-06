namespace Faker.NET.Locales.EN.Location
{
    public static class Location
    {
        public static string City
        {
            get => city.Get();
        }

        public static string State
        {
            get => states.Get();
        }

        public static string StateAbbreviation
        {
            get => states.Get(true);
        }

        public static string BuildingNumber
        {
            get => buildingNumber.Get();
        }

        public static string Address
        {
            get => $"{BuildingNumber} {City}, {StateAbbreviation} {ZipCode}";
        }

        public static string ZipCode
        {
            get => zipCode.Get();
        }

        public static string ZipCodeLongFormat
        {
            get => zipCode.Get(true);
        }

        private static City city = new();
        private static States states = new();
        private static ZipCode zipCode = new();
        private static BuildingNumber buildingNumber = new();
    }
}
