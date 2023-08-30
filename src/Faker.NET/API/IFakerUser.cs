namespace Faker.NET.API
{
    public interface IFakerUser
    {
        Common.Objects.User New { get; }

        Common.Objects.User GetUser();
    }
}
