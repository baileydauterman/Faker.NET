namespace Faker.NET.Common.Airline;

public class Airport
{
    public Airport(string name, string code)
    {
        Name = name;
        IataCode = code;
    }

    public string Name { get; }

    public string IataCode { get; }
}
