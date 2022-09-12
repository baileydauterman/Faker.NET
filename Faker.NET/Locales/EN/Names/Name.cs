namespace Faker.NET.Locales.EN.Names
{
    public static class Name
    {
        public static string FirstName => firstName.Get();

        public static string LastName => lastName.Get();

        public static string FullName => $"{firstName.Get()} {lastName.Get()}";

        public static string Suffix => suffix.Get();

        public static string Prefix => prefix.Get();

        public static string JobTitle => title.Get();

        public static string Email => email.Get(FullName);

        private static FirstName firstName = new();
        private static LastName lastName = new();
        private static Suffix suffix = new();
        private static Prefix prefix = new();
        private static Title title = new();
        private static Email email = new();
    }
}
