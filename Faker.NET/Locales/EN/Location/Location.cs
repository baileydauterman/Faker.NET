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
            get => statesabbv.Get();
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

        private static City city = new();
        private static States states = new();
        private static StateAbbreviation statesabbv = new();
        private static BuildingNumber buildingNumber = new();
        private static ZipCode zipCode = new();
    }
}
