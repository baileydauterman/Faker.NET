using Faker.NET.Common;
using Faker.NET.Common.Location;
using Faker.NET.Extensions;
using Faker.NET.Interfaces;
using Faker.NET.Interfaces.Definitions;
using Faker.NET.Location;

namespace Faker.NET.Implementations;

public class FakerLocation<T> : FakerDefinitionHandler<T>, IFakerLocation where T : IFakerLocationDefinition
{
    public string BuildingNumber()
    {
        return Data.BuildingNumber.GetRandom().ToRandomString();
    }

    public string CardinalDirection(bool abbreviated = false)
    {
        return (abbreviated ? Data.Direction.CardinalAbbr : Data.Direction.Cardinal).GetRandom();
    }

    public string City()
    {
        return Data.CityName.GetRandom();
    }

    public string Continent()
    {
        return Data.Continent.GetRandom();
    }

    public string Country()
    {
        return Data.Country.GetRandom();
    }

    public string CountryCode(CountryCode code = Common.Location.CountryCode.Alpha2)
    {
        var language = Data.Language.GetRandom();

        switch (code)
        {
            case Common.Location.CountryCode.Alpha3:
                return language.Alpha3;

            case Common.Location.CountryCode.Alpha2:
            default:
                return language.Alpha2;
        }
    }

    public string County()
    {
        return Data.County.GetRandom();
    }

    public string Direction(bool abbreviated = false)
    {
        return Faker.Randomizer.FlipCoin() switch
        {
            Coin.Heads => CardinalDirection(abbreviated),
            _ => OrdinalDirection(abbreviated),
        };
    }

    public string Latitude(int min = -90, int max = -90, int precision = 4)
    {
        return Faker.Randomizer.NextDouble(min, max).ToString($"F{precision}");
    }

    public string Longitude(int min = -180, int max = -180, int precision = 4)
    {
        return Faker.Randomizer.NextDouble(min, max).ToString($"F{precision}");
    }

    /// <summary>
    /// Calculates a given coordinate 
    /// </summary>
    /// <param name="origin"></param>
    /// <param name="radius"></param>
    /// <returns></returns>
    public Coordinate NearbyCoordinate(Coordinate origin, Distance radius)
    {
        const int kmPerDegree = 40_000 / 360;

        // doing all conversions by kilometers to have a standard unit of measurement
        var angleRadians = Faker.Randomizer.Radian(); // random radian to look at
        var radiusInKm = radius.ToKilometers(); // normalize to km
        var errorCorrection = 0.995; // avoid float issues
        var distanceInKm = Faker.Randomizer.NextDouble(0, radiusInKm.Length) * errorCorrection;
        var distanceInDegree = distanceInKm / kmPerDegree; // in °

        var coordinate = new Coordinate
        {
            Latitude = origin.Latitude + Math.Sin(angleRadians) * distanceInDegree,
            Longitude = origin.Longitude + Math.Cos(angleRadians) * distanceInDegree,
        };

        // Box latitude [-90°, 90°]
        coordinate.Latitude = coordinate.Latitude % 180;
        if (coordinate.Latitude < -90 || coordinate.Latitude > 90)
        {
            coordinate.Latitude = Math.Sign(coordinate.Latitude) * 180 - coordinate.Latitude;
            coordinate.Longitude += 180;
        }

        // Box longitude [-180°, 180°]
        coordinate.Longitude = (((coordinate.Longitude % 360) + 540) % 360) - 180;

        return coordinate;
    }

    public string OrdinalDirection(bool abbreviated = false)
    {
        return (abbreviated ? Data.Direction.OrdinalAbbr : Data.Direction.Ordinal).GetRandom();
    }

    public string SecondaryAddress()
    {
        var format = Data.SecondaryAddress.GetRandom();
        return format.ToRandomString();
    }

    public string State(bool abbreviated = false)
    {
        _state = Data.State.GetRandom();
        return abbreviated ? _state.Abbreviation : _state.Name;
    }

    public string Street()
    {
        throw new NotImplementedException();
    }

    public string StreetAddress(bool useFullAddress = false)
    {
        throw new NotImplementedException();
    }

    public string TimeZone()
    {
        throw new NotImplementedException();
    }

    public string ZipCode()
    {
        if (_state is not null)
        {
            return _state.ZipCodes.GetRandom().ToString();
        }

        return Data.Postcode.GetRandom().ToRandomString();
    }

    private LocationState? _state = null;
}
