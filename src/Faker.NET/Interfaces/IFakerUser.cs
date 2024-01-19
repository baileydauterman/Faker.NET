namespace Faker.NET.Interfaces
{
    public interface IFakerUser
    {
        Common.Objects.User New { get; }

        Common.Objects.User GetUser();
    }
}
