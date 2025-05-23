using Faker.NET.Common.Airline;

namespace Faker.NET.Modules.Interfaces;

public interface IFakerAirline
{
    public AircraftType AircraftType();

    public Airline Airline();

    public Airplane Airplane();

    public Airport Airport();

    public string FlightNumber(Airline? airline = null, int? length = null, bool addLeadingZeros = false);

    public string RecordLocator(bool allowNumerics = false);

    public string Seat(AircraftType? aircraftType = null);
}
