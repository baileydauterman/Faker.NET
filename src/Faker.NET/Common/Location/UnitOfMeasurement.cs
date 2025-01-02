using System;

namespace Faker.NET.Common.Location;

public enum UnitOfMeasurement
{
    None,

    /// <summary>
    /// Imperial Inch
    /// </summary>
    Inch,

    /// <summary>
    /// Imperial Foot (12 inches)
    /// </summary>
    Foot,

    /// <summary>
    /// Imperial Yard (3 feet)
    /// </summary>
    Yard,

    /// <summary>
    /// Imperial Rod (5.5 yards or 16.5 feet)
    /// </summary>
    Rod,

    /// <summary>
    /// Imperial Chain (4 rods, 66 feet, or 100 links)
    /// </summary>
    Chain,

    /// <summary>
    /// Imperial Furlong (10 chains, 40 rods, or 660 feet)
    /// </summary>
    Furlong,

    /// <summary>
    /// Imperial Mile (8 furlongs, 320 rods, 1760 yards, 5280 feet)
    /// </summary>
    Mile,

    /// <summary>
    /// Metric Millimeter
    /// </summary>
    Millimeter,

    /// <summary>
    /// Metric Centimeter
    /// </summary>
    Centimeter,

    /// <summary>
    /// Metric Decimeter
    /// </summary>
    Decimeter,

    /// <summary>
    /// Metric Meter (1000 millimeters, 100 centimeters, 10 decimeters)
    /// </summary>
    Meter,

    /// <summary>
    /// Metric Decameter (10 meters)
    /// </summary>
    Decameter,

    /// <summary>
    /// Metric Hectometer (100 meters)
    /// </summary>
    Hectometer,

    /// <summary>
    /// Metric Kilometer (1000 meters)
    /// </summary>
    Kilometer
}
