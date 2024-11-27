using System;

namespace Faker.NET.Attributes;

public class FakerComputerPasswordAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Computer.Password;
}

public class FakerComputerIPv4AddressAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Computer.IPv4Address;
}

public class FakerComputerIPv6AddressAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Computer.IPv6Address;
}

public class FakerComputerDomainAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Computer.Domain;
}

public class FakerComputerUserAgentAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Computer.UserAgent;
}
