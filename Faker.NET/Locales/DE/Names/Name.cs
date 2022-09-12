namespace Faker.NET.DE.Names
{
    public static class Name
    {
        public static string FirstName => firstName.Get();

        public static string LastName => lastName.Get();

        public static string Prefix => prefix.Get();

        private static FirstName firstName = new();
        private static LastName lastName = new();
        private static Prefix prefix = new();
    }
}
