﻿namespace Faker.NET.Interfaces
{
    public interface IFakerComputer
    {
        string IPv4Address { get; }

        string IPv6Address { get; }

        string UserAgent { get; }

        string Password { get; }

        string Domain { get; }
    }
}
