using System;
using Faker.NET.Common.Airline;
using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Airline;

public class AirlineTests : DeterministicTestClass
{
    [Test]
    public void Airplane()
    {
        var airplane = Faker.Airline.Airplane();
        Assert.That(airplane.Name, Is.EqualTo("Cessna Citation I"));
        Assert.That(airplane.IataTypeCode, Is.EqualTo("CNJ"));
    }

    [Test]
    public void AircraftType()
    {
        Assert.That(Faker.Airline.AircraftType(), Is.InstanceOf<AircraftType>());
    }

    [Test]
    public void Airline()
    {
        var airline = Faker.Airline.Airline();
        Assert.That(airline.Name, Is.EqualTo("Frontier Airlines"));
        Assert.That(airline.IataCode, Is.EqualTo("F9"));
    }

    [Test]
    public void Airport()
    {
        var airport = Faker.Airline.Airport();
        Assert.That(airport.Name, Is.EqualTo("St. Louis Lambert International Airport"));
        Assert.That(airport.IataCode, Is.EqualTo("STL"));
    }

    [Test]
    public void FlightNumber()
    {
        Assert.That(Faker.Airline.FlightNumber(), Is.EqualTo("F95"));
    }

    [Test]
    public void RecordLocator()
    {
        Assert.That(Faker.Airline.RecordLocator(), Is.EqualTo("EPKWRCWN"));
    }

    [Test]
    public void Seat()
    {
        Assert.That(Faker.Airline.Seat(), Is.EqualTo("10H"));
    }
}
