using System;
using System.Net;
using Faker.NET.Common.Exceptions;

namespace Faker.NET.Internet.Generators;

internal class IPv4Generator
{
    public string Generate()
    {
        return new IPAddress(Faker.Randomizer.NextBytes(4).ToArray()).ToString();
    }

    public string Generate(string? cidrBlock, NetworkTypes network)
    {
        throw new NotImplementedException();
    }

    private int GetOctet()
    {
        return Faker.Randomizer.Next(1, 256);
    }

    /// <summary>
    /// Get an octet for an IPv4 address within a certain range.
    /// </summary>
    /// <param name="low"></param>
    /// <param name="high"></param>
    /// <returns></returns>
    /// <remarks>
    /// Adds one to the random number because we want to return something between 1 and 256
    /// </remarks>
    private int GetOctet(byte? low = null, byte? high = null)
    {
        low ??= byte.MinValue;
        high ??= byte.MaxValue;

        return Faker.Randomizer.Next(low.Value, high.Value) + 1;
    }

    private (byte[], byte) ParseCidrBlock(string? cidrBlock)
    {
        if (string.IsNullOrWhiteSpace(cidrBlock))
        {
            throw new ArgumentNullException(nameof(cidrBlock));
        }

        var index = cidrBlock.IndexOf('/');
        var ip = cidrBlock.Substring(0, index);
        var cidrSubstr = cidrBlock.Substring(index + 1);
        if (!byte.TryParse(cidrSubstr, out var cidr))
        {
            throw new Exception($"Unable to process cidr: {cidrSubstr}");
        }

        var ipParts = new byte[4];
        var parts = ip.Split('.');
        for (int i = 0; i < parts.Length; i++)
        {
            if (byte.TryParse(parts[i], out var temp))
            {
                ipParts[i] = temp;
                continue;
            }

            throw new Exception($"Unable to parse ip portion of cidr block: {parts[i]}");
        }

        return (ipParts, cidr);
    }
}
