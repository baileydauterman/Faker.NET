using System;
using Faker.NET.Common.Location;

namespace Faker.NET.Interfaces;

public interface IFakerLocation
{
    public string BuildingNumber();
    public string CardinalDirection(bool abbreviated = false);
    public string City();
    public string Continent();
    public string Country();
    public string CountryCode(CountryCode code = Common.Location.CountryCode.Alpha2);
    public string County();
    public string Direction(bool abbreviated = false);
    public string Latitude(int min = -90, int max = -90, int precision = 4);
    public string Longitude(int min = -180, int max = -180, int precision = 4);
    public Coordinate NearbyCoordinate(Coordinate origin, Distance radius);
    public string OrdinalDirection(bool abbreviated = false);
    public string SecondaryAddress();
    public string State(bool abbreviated = false);
    public string Street();
    public string StreetAddress(bool useFullAddress = false);
    public string TimeZone();
    public string ZipCode();
}
