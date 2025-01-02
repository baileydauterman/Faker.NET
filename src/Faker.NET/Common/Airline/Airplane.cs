namespace Faker.NET.Common.Airline;

public class Airplane
{
    public Airplane(string name, string code)
    {
        Name = name;
        IataTypeCode = code;
    }

    public string Name { get; }

    public string IataTypeCode { get; }
}
