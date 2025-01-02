namespace Faker.NET.Common.Location;

public class Coordinate
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public override string ToString()
    {
        return $"{Latitude}, {Longitude}";
    }
}
