using Faker.NET.API;
using Faker.NET.Common;

namespace Faker.NET.Locales.EN
{
    public class User : IFakerUser
    {
        public Common.Objects.User New => GetUser();

        public Common.Objects.User GetUser()
        {
            var user = new Common.Objects.User()
            {
                FirstName = Faker.Name.First,
                LastName = Faker.Name.Last,
                JobTitle = Faker.Name.Job,
                Prefix = Faker.Name.Prefix,
            };

            user.Email = EmailHelper.Generate(user.FirstName, user.LastName);

            return user;
        }
    }
}
