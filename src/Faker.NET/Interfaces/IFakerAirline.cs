using System;
using Faker.NET.Airline;

namespace Faker.NET.Interfaces;

public interface IFakerAirline
{
    public AircraftType AircraftType();

    public Airline.Airline Airline();

    public Airplane Airplane();

    public Airport Airport();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="length">Must be between 1 and 4</param>
    /// <param name="addLeadingZeros">Whether or not to add leading zeros to the number</param>
    /// <returns></returns>
    public string FlightNumber(Airline.Airline? airline, int? length, bool addLeadingZeros = false);

    public string RecordLocator(bool allowNumerics = false);

    public string Seat(AircraftType? aircraftType);
}
