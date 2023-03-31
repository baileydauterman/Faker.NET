namespace Faker.NET.RU.Names
{
    public static class Name
    {
        public static class Native
        {
            public static string FirstName => firstName.Get();

            public static string MiddleName => middleName.Get();

            public static string LastName => lastName.Get();

            public static string FullName => $"{firstName.Get()} {lastName.Get()}";

            public static string JobTitle => title.Get(false);
        }

        public static class Translated
        {
            public static string FirstName => firstName.Get(true);

            public static string MiddleName => middleName.Get(true);

            public static string LastName => lastName.Get(true);

            public static string FullName => $"{firstName.Get(true)} {lastName.Get(true)}";

            public static string JobTitle => title.Get(true);
        }

        private static readonly FirstName firstName = new();
        private static readonly MiddleName middleName = new();
        private static readonly LastName lastName = new();
        private static readonly Title title = new();
    }
}
