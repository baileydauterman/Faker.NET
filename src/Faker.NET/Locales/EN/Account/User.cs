using Faker.NET.EN.Names;

namespace Faker.NET.EN.Account
{
    public static class User
    {
        public static Common.Objects.User NewAccount => GetUser();

        public static Common.Objects.User GetUser()
        {
            var user = new Common.Objects.User()
            {
                FirstName = Name.FirstName,
                LastName = Name.LastName,
                JobTitle = Name.JobTitle,
                Prefix = Name.Prefix,
            };

            user.Email = emailGenerator.Get(user.FirstName, user.LastName);

            return user;
        }

        private static Email emailGenerator = new();
    }
}
