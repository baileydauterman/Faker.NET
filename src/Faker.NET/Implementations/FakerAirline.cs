using Faker.NET.Common.Airline;
using Faker.NET.Common;
using Faker.NET.Extensions;
using Faker.NET.Interfaces;
using Faker.NET.Interfaces.Definitions;

namespace Faker.NET.Implementations;

public class FakerAirline<T> : IFakerAirline where T : IFakerAirlineDefinition
{
    public FakerAirline()
    {
        Data = Activator.CreateInstance<T>();
    }

    public AircraftType AircraftType()
    {
        return RandomizerExtensions.GetRandom<AircraftType>();
    }

    public Airline Airline()
    {
        return Data.Airlines.GetRandom();
    }

    public Airplane Airplane()
    {
        return Data.Airplanes.GetRandom();
    }

    public Airport Airport()
    {
        return Data.Airports.GetRandom();
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

    private readonly IFakerAirlineDefinition Data;
}
