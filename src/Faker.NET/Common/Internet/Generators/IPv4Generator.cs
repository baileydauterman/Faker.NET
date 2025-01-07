using System.Net;
using Faker.NET.Common.Internet;

namespace Faker.NET.Internet.Generators;

internal class IPv4Generator
{
    public string Generate()
    {
        var addressBytes = NewAddress();
        return new IPAddress(addressBytes).ToString();
    }

    public string Generate(string cidrBlock, NetworkTypes network)
    {
        return GenerateRandomIPFromCIDR(cidrBlock);
    }

    private byte[] NewAddress()
    {
        return new byte[4] {
            GetOctet(low: 1),
            GetOctet(),
            GetOctet(),
            GetOctet(),
        };
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
    private static byte GetOctet(byte? low = null, byte? high = null)
    {
        low ??= byte.MinValue;
        high ??= byte.MaxValue;

        if (high == 0)
        {
            high = byte.MaxValue;
        }

        return (byte)Faker.Randomizer.Next(low.Value, high.Value);
    }

    public static string GenerateRandomIPFromCIDR(string cidr)
    {
        var (ipAddress, subnetMask) = ParseCidr(cidr);

        // Convert the IP Address to a uint (integer)
        uint ipUint = IpToUint(ipAddress);

        // Get the prefix length
        int prefixLength = int.Parse(cidr.Split('/')[1]);

        // Calculate the range of usable IPs based on the subnet mask
        uint subnetSize = (uint)(Math.Pow(2, 32 - prefixLength)); // Number of IPs in the subnet
        uint firstUsableIP = ipUint + 1; // Network address + 1
        uint lastUsableIP = ipUint + subnetSize - 2; // Broadcast address - 1

        // Generate a random IP in the range of usable IPs
        uint randomIp = (uint)Faker.Randomizer.Next((int)firstUsableIP, (int)lastUsableIP + 1);

        // Convert the random IP back to the dotted-decimal format
        return UintToIp(randomIp).ToString();
    }

    private static (byte[] address, byte[] subnetMash) ParseCidr(string cidr)
    {
        // Split the CIDR into IP Address and Prefix Length
        var parts = cidr.Split('/');
        if (parts.Length != 2)
        {
            throw new ArgumentException("Invalid CIDR format");
        }

        var ipAddress = StringToByteArray(parts[0]);
        var prefixLength = byte.Parse(parts[1]);

        // Validate prefix length (should be between 0 and 32 for IPv4)
        if (prefixLength < 0 || prefixLength > 32)
        {
            throw new ArgumentOutOfRangeException("Prefix length must be between 0 and 32");
        }

        // Generate the Subnet Mask based on prefix length
        var subnetMask = GetSubnetMaskFromPrefixLength(prefixLength);

        return (ipAddress, subnetMask);
    }

    private static byte[] StringToByteArray(string str)
    {
        var split = str.Split('.');

        if (split.Length != 4)
        {
            throw new Exception("ip string must have all 4 parts");
        }

        return new byte[4]
        {
            byte.Parse(split[0]),
            byte.Parse(split[1]),
            byte.Parse(split[2]),
            byte.Parse(split[3]),
        };
    }

    private static byte[] GetSubnetMaskFromPrefixLength(byte prefixLength)
    {
        uint mask = uint.MaxValue << (32 - prefixLength);
        return new byte[]
            {
                (byte)((mask >> 24) & 0xFF),
                (byte)((mask >> 16) & 0xFF),
                (byte)((mask >> 8) & 0xFF),
                (byte)(mask & 0xFF)
            };
    }

    // Convert IP Address to a uint (32-bit integer)
    private static uint IpToUint(byte[] ipParts)
    {
        uint result = 0;
        for (int i = 0; i < 4; i++)
        {
            result |= (uint)(ipParts[i] << (24 - (8 * i)));
        }
        return result;
    }

    // Convert a uint back to an IP Address in dotted-decimal format
    private static IPAddress UintToIp(uint ipUint)
    {
        return new IPAddress(new byte[]
        {
            (byte)((ipUint >> 24) & 0xFF),
            (byte)((ipUint >> 16) & 0xFF),
            (byte)((ipUint >> 8) & 0xFF),
            (byte)(ipUint & 0xFF)
        });
    }
}
