namespace Faker.NET.Common.Location;

public class Distance
{
    public static Distance Inches(double length) => new Distance(length, UnitOfMeasurement.Inch);

    public static Distance Feet(double length) => new Distance(length, UnitOfMeasurement.Foot);

    public static Distance Yards(double length) => new Distance(length, UnitOfMeasurement.Yard);

    public static Distance Rods(double length) => new Distance(length, UnitOfMeasurement.Rod);

    public static Distance Chains(double length) => new Distance(length, UnitOfMeasurement.Chain);

    public static Distance Furlongs(double length) => new Distance(length, UnitOfMeasurement.Furlong);

    public static Distance Miles(double length) => new Distance(length, UnitOfMeasurement.Mile);

    public static Distance Millimeters(double length) => new Distance(length, UnitOfMeasurement.Millimeter);

    public static Distance Centimeters(double length) => new Distance(length, UnitOfMeasurement.Centimeter);

    public static Distance Decimeters(double length) => new Distance(length, UnitOfMeasurement.Decimeter);

    public static Distance Meters(double length) => new Distance(length, UnitOfMeasurement.Meter);

    public static Distance Decameters(double length) => new Distance(length, UnitOfMeasurement.Decameter);

    public static Distance Hectometers(double length) => new Distance(length, UnitOfMeasurement.Hectometer);

    public static Distance Kilometers(double length) => new Distance(length, UnitOfMeasurement.Kilometer);

    private Distance(double length, UnitOfMeasurement unit)
    {
        Unit = unit;
        Length = length;
    }

    public UnitOfMeasurement Unit { get; }

    public double Length { get; }

    public Distance Copy()
    {
        return new Distance(Length, Unit);
    }
}
