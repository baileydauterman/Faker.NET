using Faker.NET.Common.Location;

namespace Faker.NET.Extensions;

public static class DistanceExtensions
{
    public static Distance ToInches(this Distance distance)
    {
        var inches = distance.Unit switch
        {
            UnitOfMeasurement.Inch => distance.Length,
            UnitOfMeasurement.Foot => distance.Length * 12,
            UnitOfMeasurement.Yard => distance.Length * (12 * 3),
            UnitOfMeasurement.Rod => distance.Length * (12 * 16.5),
            UnitOfMeasurement.Chain => distance.Length * (12 * 66),
            UnitOfMeasurement.Furlong => distance.Length * (12 * 660),
            UnitOfMeasurement.Mile => distance.Length * (12 * 5280),
            UnitOfMeasurement.Millimeter => distance.Length / 25.4,
            UnitOfMeasurement.Centimeter => distance.Length / 2.54,
            UnitOfMeasurement.Decimeter => distance.Length * 3.93701,
            UnitOfMeasurement.Meter => distance.Length * 39.3701,
            UnitOfMeasurement.Decameter => distance.Length * 393.701,
            UnitOfMeasurement.Hectometer => distance.Length * 3_937.01,
            UnitOfMeasurement.Kilometer => distance.Length * 39_370.1,
            _ => throw new Exception($"Unhandled unit of measurement: {distance.Unit}"),
        };

        return Distance.Inches(inches);
    }

    public static Distance ToFeet(this Distance distance)
    {
        var inches = distance.Unit switch
        {
            UnitOfMeasurement.Inch => distance.Length / 12,
            UnitOfMeasurement.Foot => distance.Length,
            UnitOfMeasurement.Yard => distance.Length * 3,
            UnitOfMeasurement.Rod => distance.Length * 16.5,
            UnitOfMeasurement.Chain => distance.Length * 66,
            UnitOfMeasurement.Furlong => distance.Length * 660,
            UnitOfMeasurement.Mile => distance.Length * 5280,
            UnitOfMeasurement.Millimeter => distance.Length / 304.8,
            UnitOfMeasurement.Centimeter => distance.Length / 30.48,
            UnitOfMeasurement.Decimeter => distance.Length / 3.048,
            UnitOfMeasurement.Meter => distance.Length * 3.281,
            UnitOfMeasurement.Decameter => distance.Length * 32.81,
            UnitOfMeasurement.Hectometer => distance.Length * 328.1,
            UnitOfMeasurement.Kilometer => distance.Length * 3281,
            _ => throw new Exception($"Unhandled unit of measurement: {distance.Unit}"),
        };

        return Distance.Feet(inches);
    }

    public static Distance ToYards(this Distance distance)
    {
        throw new NotImplementedException();
    }

    public static Distance ToRods(this Distance distance)
    {
        throw new NotImplementedException();
    }

    public static Distance ToChains(this Distance distance)
    {
        throw new NotImplementedException();
    }

    public static Distance ToFurlongs(this Distance distance)
    {
        throw new NotImplementedException();
    }

    public static Distance ToMiles(this Distance distance)
    {
        throw new NotImplementedException();
    }

    public static Distance ToMillimeters(this Distance distance)
    {
        throw new NotImplementedException();
    }

    public static Distance ToCentimeters(this Distance distance)
    {
        throw new NotImplementedException();
    }

    public static Distance ToDecimeters(this Distance distance)
    {
        throw new NotImplementedException();
    }

    public static Distance ToMeters(this Distance distance)
    {
        var meters = distance.Unit switch
        {
            UnitOfMeasurement.Inch => distance.Length * 0.0254,
            UnitOfMeasurement.Foot => distance.Length * 0.3048,
            UnitOfMeasurement.Yard => distance.Length * 0.9144,
            UnitOfMeasurement.Rod => distance.Length * 5.0292,
            UnitOfMeasurement.Chain => distance.Length * 20.1168,
            UnitOfMeasurement.Furlong => distance.Length * 201.168,
            UnitOfMeasurement.Mile => distance.Length * 1609.34,
            UnitOfMeasurement.Millimeter => distance.Length * 0.001,
            UnitOfMeasurement.Centimeter => distance.Length * 0.01,
            UnitOfMeasurement.Decimeter => distance.Length * 0.1,
            UnitOfMeasurement.Meter => distance.Length,
            UnitOfMeasurement.Decameter => distance.Length * 10,
            UnitOfMeasurement.Hectometer => distance.Length * 100,
            UnitOfMeasurement.Kilometer => distance.Length * 1000,
            _ => throw new Exception($"Unhandled unit of measurement: {distance.Unit}"),
        };

        return Distance.Meters(meters);
    }

    public static Distance ToDecameters(this Distance distance)
    {
        throw new NotImplementedException();
    }

    public static Distance ToHectometers(this Distance distance)
    {
        throw new NotImplementedException();
    }

    public static Distance ToKilometers(this Distance distance)
    {
        var kilometers = distance.Unit switch
        {
            UnitOfMeasurement.Inch => distance.Length * 0.0000254,
            UnitOfMeasurement.Foot => distance.Length * 0.0003048,
            UnitOfMeasurement.Yard => distance.Length * 0.0009144,
            UnitOfMeasurement.Rod => distance.Length * 0.0050292,
            UnitOfMeasurement.Chain => distance.Length * 0.0201168,
            UnitOfMeasurement.Furlong => distance.Length * 0.201168,
            UnitOfMeasurement.Mile => distance.Length * 1.60934,
            UnitOfMeasurement.Millimeter => distance.Length * 0.000001,
            UnitOfMeasurement.Centimeter => distance.Length * 0.00001,
            UnitOfMeasurement.Decimeter => distance.Length * 0.0001,
            UnitOfMeasurement.Meter => distance.Length * 0.001,
            UnitOfMeasurement.Decameter => distance.Length * 0.01,
            UnitOfMeasurement.Hectometer => distance.Length * 0.1,
            UnitOfMeasurement.Kilometer => distance.Length,
            _ => throw new Exception($"Unhandled unit of measurement: {distance.Unit}"),
        };

        return Distance.Kilometers(kilometers);
    }
}
