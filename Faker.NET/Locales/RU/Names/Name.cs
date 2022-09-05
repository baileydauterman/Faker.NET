namespace Faker.NET.Locales.RU.Names
{
    public static class Name
    {
        public static string FirstName
        {
            get => firstName.Get();
        }

        public static string MiddleName
        {
            get => middleName.Get();
        }

        public static string LastName
        {
            get => lastName.Get();
        }

        public static string FullName
        {
            get => $"{firstName.Get()} {lastName.Get()}";
        }

        public static string JobTitle
        {
            get => title.Get();
        }

        private static FirstName firstName = new();
        private static MiddleName middleName = new();
        private static LastName lastName = new();
        private static Title title = new();
    }
}
