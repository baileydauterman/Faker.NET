namespace Faker.NET.Locales.DE.Names
{
    public static class Name
    {
        public static string FirstName
        {
            get => firstName.Get();
        }

        public static string LastName
        {
            get => lastName.Get();
        }

        public static string Prefix
        {
            get => prefix.Get();
        }

        private static FirstName firstName = new();
        private static LastName lastName = new();
        private static Prefix prefix = new();
    }
}
