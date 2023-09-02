using Faker.NET.API;
using Faker.NET.Common;

namespace Faker.NET.EN.Account
{
    public class User : IFakerUser
    {
        public Common.Objects.User New => GetUser();

        public Common.Objects.User GetUser()
        {
            var name = new EN.Names.Name();

            var user = new Common.Objects.User()
            {
                FirstName = name.First,
                LastName = name.Last,
                JobTitle = name.Job,
                Prefix = name.Prefix,
            };

            user.Email = EmailHelper.Generate(user.FirstName, user.LastName);

            return user;
        }
    }
}
