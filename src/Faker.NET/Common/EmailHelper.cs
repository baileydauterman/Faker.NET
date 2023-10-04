namespace Faker.NET.Common
{
    internal class EmailHelper
    {
        /// <summary>
        /// Generate an email address based on given full name
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="domain"></param>
        /// <returns></returns>
        public static string Generate(string fname, string lname, string domain = null)
        {
            if (string.IsNullOrWhiteSpace(domain))
            {
                domain = GetDomain();
            }

            var followingNum = Faker.Randomizer.Next(1, 9);

            var prefix = (Faker.Randomizer.Next(1, 10) > 5 ? $"{fname}.{lname}" : $"{lname}.{fname}").ToLower();

            return $"{prefix}{followingNum}@{domain}";
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
