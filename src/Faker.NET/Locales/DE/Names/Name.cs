namespace Faker.NET.DE.Names
{
    public static class Name
    {
        public static string FirstName => firstName.Get(false);

        public static string LastName => lastName.Get(false);

        public static string Prefix => prefix.Get(false);

        private static FirstName firstName = new();
        private static LastName lastName = new();
        private static Prefix prefix = new();
    }
}
