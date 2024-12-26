using System;

namespace Faker.NET.Attributes;

public class FakerComputerPasswordAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Internet.Password();
}

public class FakerComputerIPv4AddressAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Internet.IPv4();
}

public class FakerComputerIPv6AddressAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Internet.IPv6();
}

public class FakerComputerDomainAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Internet.DomainName();
}

public class FakerComputerUserAgentAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Internet.UserAgent();
}
