namespace Faker.NET.Locales.RU.Names
{
    public static class Name
    {
        public static string FirstName
        {
            get
            {
                return firstName.Get();
            }
        }

        public static string MiddleName
        {
            get
            {
                return middleName.Get();
            }
        }

        public static string LastName
        {
            get
            {
                return lastName.Get();
            }
        }

        public static string FullName
        {
            get
            {
                return $"{firstName.Get()} {lastName.Get()}";
            }
        }

        public static string JobTitle
        {
            get
            {
                return title.Get();
            }
        }

        private static FirstName firstName = new();
        private static MiddleName middleName = new();
        private static LastName lastName = new();
        private static Title title = new();
    }
}
