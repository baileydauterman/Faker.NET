using System;
using Faker.NET.Extensions;
using Faker.NET.Interfaces;

namespace Faker.NET.Airline;

public class FakerAirline : IFakerAirline
{
    public AircraftType AircraftType()
    {
        throw new NotImplementedException();
    }

    public Airline Airline()
    {
        return Data.Airlines.MainlineAirlines.GetRandom();
    }

    public Airplane Airplane()
    {
        throw new NotImplementedException();
    }

    public Airport Airport()
    {
        return Data.Airports.UnitedStatesAirports.GetRandom();
    }

    public string FlightNumber(int? length, bool addLeadingZeros = false)
    {
        throw new NotImplementedException();
    }

    public string RecordLocator(bool allowNumerics = false)
    {
        throw new NotImplementedException();
    }

    public string Seat(AircraftType? aircraftType)
    {
        throw new NotImplementedException();
    }
}
