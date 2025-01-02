namespace Faker.NET.Common.Objects
{
    public class User
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Prefix { get; set; } = string.Empty;

        public string JobTitle { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;


        public override string ToString()
        {
            return $"{Prefix} {FirstName} {LastName}, {JobTitle} at {Email}";
        }
    }
}
