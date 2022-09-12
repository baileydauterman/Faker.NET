namespace Faker.NET.RU.Names
{
    public static class Name
    {
        public static string FirstName => firstName.Get();

        public static string MiddleName => middleName.Get();

        public static string LastName => lastName.Get();

        public static string FullName => $"{firstName.Get()} {lastName.Get()}";

        public static string JobTitle => title.Get();

        private static FirstName firstName = new();
        private static MiddleName middleName = new();
        private static LastName lastName = new();
        private static Title title = new();
    }
}
