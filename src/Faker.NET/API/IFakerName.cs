namespace Faker.NET.API
{
    public interface IFakerName
    {
        string First { get; }

        string Last { get; }

        string Full { get; }

        string Suffix { get; }

        string Prefix { get; }

        string Job { get; }

        string Email { get; }
    }
}
