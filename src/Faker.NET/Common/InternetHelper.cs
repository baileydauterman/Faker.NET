using Faker.NET.Extensions;

namespace Faker.NET.Common
{
    internal class InternetHelper
    {
        public static string GenerateUsername(string firstName, string lastName)
        {
            var addNumber = Faker.Randomizer.Next(1, 2) > 1;
            return GenerateUsername(firstName, lastName, addNumber);
        }

        public static string GenerateUsername(string firstName, string lastName, bool addNumber = true)
        {
            var userName = Faker.Randomizer.Next(1, 4) switch
            {
                1 => $"{firstName}.{lastName}", // john.doe
                2 => $"{lastName}.{firstName}", // doe.john
                3 => $"{firstName[0]}{lastName}", //jdoe
                4 => $"{firstName}{lastName[0]}", // johnd
                _ => $"{firstName}{lastName}", // johndoe
            };

            if (addNumber)
            {
                userName = $"{userName}{Faker.Randomizer.Next(1, 9)}";
            }

            return userName.ToLower();
        }

        /// <summary>
        /// Generate an email address based on given full name
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="domain"></param>
        /// <returns></returns>
        public static string GenerateEmail(string fname, string lname, string domain = null)
        {
            if (string.IsNullOrWhiteSpace(domain))
            {
                domain = GetDomain();
            }

            var prefix = GenerateUsername(fname, lname);

            return $"{prefix}@{domain}";
        }

        public static string GenerateEmail(string userName, string domain = null)
        {
            if (string.IsNullOrWhiteSpace(domain))
            {
                domain = GetDomain();
            }

            return $"{userName}@{domain}";
        }

        public static string GetDomain() => _domain.GetRandom();

        private static readonly string[] _domain =
        {
            "gmail.com",
            "yahoo.com",
            "hotmail.com",
            "aol.com",
            "comcast.net",
            "rediffmail.com",
            "ymail.com",
            "outlook.com",
        };
    }
}
