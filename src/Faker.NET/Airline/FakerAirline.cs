using Faker.NET.Common;
using Faker.NET.Extensions;
using Faker.NET.Interfaces;

namespace Faker.NET.Airline;

public class FakerAirline : IFakerAirline
{
    public AircraftType AircraftType()
    {
        return RandomizerExtensions.GetRandom<AircraftType>();
    }

    public Airline Airline()
    {
        return Data.Airlines.MainlineAirlines.GetRandom();
    }

    public Airplane Airplane()
    {
        return Data.Airplanes.Frames.GetRandom();
    }

    public Airport Airport()
    {
        return Data.Airports.UnitedStatesAirports.GetRandom();
    }

    public string FlightNumber(Airline? airline, int? length, bool addLeadingZeros = false)
    {
        airline ??= Airline();
        length ??= Faker.Randomizer.Next(1, 5);

        var number = Faker.Randomizer.String(length.Value, StringCharacterTypes.Numbers);
        if (addLeadingZeros)
        {
            number = number.PadLeft(4, '0');
        }

        return $"{airline.IataCode}{number}";
    }

    public string RecordLocator(bool allowNumerics = false)
    {
        var settings = StringCharacterTypes.UpperCase;
        var length = Faker.Randomizer.Next(7, 9);

        if (allowNumerics)
        {
            settings |= StringCharacterTypes.Numbers;
        }

        return Faker.Randomizer.String(length, settings);
    }

    public string Seat(AircraftType? aircraftType)
    {
        throw new NotImplementedException();
    }
}
