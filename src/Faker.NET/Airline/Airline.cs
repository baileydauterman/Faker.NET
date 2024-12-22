namespace Faker.NET.Airline;

public class Airline
{
    public Airline(string name, string code)
    {
        Name = name;
        IataCode = code;
    }

    public string Name { get; }

    public string IataCode { get; }
}
