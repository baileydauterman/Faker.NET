using Faker.NET.Common;
using Faker.NET.Common.Location;
using Faker.NET.Extensions;
using Faker.NET.Interfaces.Definitions;
using Faker.NET.Interfaces.Modules;
using Faker.NET.Location;

namespace Faker.NET.Implementations.Modules;

internal class FakerLocation<T> : FakerDefinitionHandler<T>, IFakerLocation where T : IFakerLocationDefinition
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
        double R = 6371; // Radius of the Earth in kilometers

        // Convert latitude and longitude from degrees to radians
        double lat1 = origin.Latitude * Math.PI / 180;
        double lon1 = origin.Longitude * Math.PI / 180;

        // Random distance within the radius
        double d = radius.ToKilometers().Length * Faker.Randomizer.NextDouble();

        // Random bearing in radians
        double theta = 2 * Math.PI * Faker.Randomizer.NextDouble();

        // Calculate new latitude
        double lat2 = Math.Asin(Math.Sin(lat1) * Math.Cos(d / R) + Math.Cos(lat1) * Math.Sin(d / R) * Math.Cos(theta));

        // Calculate new longitude
        double lon2 = lon1 + Math.Atan2(Math.Sin(theta) * Math.Sin(d / R) * Math.Cos(lat1),
                                        Math.Cos(d / R) - Math.Sin(lat1) * Math.Sin(lat2));

        // Convert back to degrees
        lat2 = lat2 * 180 / Math.PI;
        lon2 = lon2 * 180 / Math.PI;

        return new Coordinate
        {
            Latitude = lat2,
            Longitude = lon2,
        };
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
        return Data.StreetName.GetRandom();
    }

    public string StreetAddress(bool useFullAddress = false)
    {
        return useFullAddress ? Data.StreetAddress.Full.Invoke(this) :
                                Data.StreetAddress.Normal.Invoke(this);
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
