using System;

namespace Faker.NET.Geo;

public class GeoFaker
{
    public GeoFaker(int precision = 9)
    {
        _precisionFormat = $"F{precision}";
    }

    public string Latitude => Faker.Randomizer.DoubleInRange(-180, 180).ToString(_precisionFormat);

    public string Longitude => Faker.Randomizer.DoubleInRange(-90, 90).ToString(_precisionFormat);

    private readonly string _precisionFormat;
}
