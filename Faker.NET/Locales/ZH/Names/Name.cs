using System.Net.NetworkInformation;

namespace Faker.NET.Locales.ZH.Names
{
    public static class Name
    {
        public static class Native
        {
            public static string FirstName => firstName.Get();

            public static string LastName => lastName.Get();

            public static string FullName => $"{lastName.Get()} {firstName.Get()}";
        }

        public static class Translated
        {
            public static string FirstName => firstName.Get(true);

            public static string LastName => lastName.Get(true);

            public static string FullName => $"{lastName.Get(true)} {firstName.Get(true)}";
        }
        
        private static LastName lastName = new();
        private static FirstName firstName = new();
    }
}
