using Faker.NET.Common;
using Faker.NET.Common.Objects;
using Faker.NET.Interfaces;

namespace Faker.NET.Locales.EN;

internal class EnFakerUser : IFakerUser
{
    public User New => GetUser();

    public User GetUser()
    {
        var user = new User()
        {
            FirstName = Faker.Name.First,
            LastName = Faker.Name.Last,
            JobTitle = Faker.Name.Job,
            Prefix = Faker.Name.Prefix,
        };

        return user;
    }
}
