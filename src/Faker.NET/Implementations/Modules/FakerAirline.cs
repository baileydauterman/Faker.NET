using Faker.NET.Common;
using Faker.NET.Common.Airline;
using Faker.NET.Extensions;
using Faker.NET.Implementations.Definitions;
using Faker.NET.Modules.Interfaces;

namespace Faker.NET.Implementations.Modules;

internal class FakerAirline : FakerDefinitionHandler<BaseFakerAirlineDefinition>, IFakerAirline
{
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

    public string FlightNumber(Airline? airline = null, int? length = null, bool addLeadingZeros = false)
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

    public string Seat(AircraftType? aircraftType = null)
    {
        aircraftType ??= RandomizerExtensions.GetRandom<AircraftType>();
        var number = Faker.Randomizer.Next(1, 52);
        var seatLetters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'H', 'G', 'I', 'J', 'K' };

        return $"{number}{seatLetters.GetRandom()}";
    }
}
