namespace Faker.NET.Common
{
    internal class InternetHelper
    {
        public static string GenerateUsername(string firstName, string lastName)
        {
            var followingNum = Faker.Randomizer.Next(1, 9);
            var prefixSuffix = Faker.Randomizer.Next(1, 2) > 1 ? $"{followingNum}" : string.Empty;
            string prefix;

            if (Faker.Randomizer.FlipCoin() == Coin.Heads)
            {
                prefix = Faker.Randomizer.FlipCoin() == Coin.Heads ?
                    $"{firstName}.{lastName}" :
                    $"{lastName}.{firstName}";
            }
            else
            {
                prefix = Faker.Randomizer.FlipCoin() == Coin.Tails ?
                    $"{firstName[0]}{lastName}" :
                    $"{firstName}{lastName[0]}";
            }


            return $"{prefix}{prefixSuffix}".ToLower();
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
