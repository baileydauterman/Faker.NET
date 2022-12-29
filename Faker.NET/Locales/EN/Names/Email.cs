using Faker.NET.Common;

namespace Faker.NET.EN.Names
{
    internal class Email : FakerText
    {
        public Email() : base()
        {
            Data = new()
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
        public string Get(string name)
        {
            var domain = Get(false);
            var nameSplit = name.Split(' ');
            var followingNum = Randomizer.Next(1, 15);

            return $"{nameSplit[0].ToLower()}.{nameSplit[1].ToLower()}{followingNum}@{domain}";
        }

        public string Get(string fname, string lname)
        {
            var domain = Get(false);
            var followingNum = Randomizer.Next(1,9);

            return $"{fname.ToLower()}.{lname.ToLower()}{followingNum}@{domain}";
        }
    }
}
