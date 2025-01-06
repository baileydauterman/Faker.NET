using System;

namespace Faker.NET.Common.Location;

public class Direction
{
    public Direction(string[] cardinal, string[] cardinalAbbr, string[] ordinal, string[] ordinalAbbr)
    {
        Cardinal = cardinal;
        CardinalAbbr = cardinalAbbr;
        Ordinal = ordinal;
        OrdinalAbbr = ordinalAbbr;
    }

    public string[] Cardinal { get; }
    public string[] CardinalAbbr { get; }
    public string[] Ordinal { get; }
    public string[] OrdinalAbbr { get; }
}
