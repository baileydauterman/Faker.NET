namespace Faker.NET.Common.Objects
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Prefix { get; set; }

        public string JobTitle { get; set; }


        public override string ToString()
        {
            return $"{Prefix} {FirstName} {LastName}, {JobTitle} at {Email}";
        }
    }
}
