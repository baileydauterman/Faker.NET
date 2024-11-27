using Faker.NET.Attributes;
using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Attributes;

public class Computer : DeterministicTestClass
{
    [Test]
    public void ClassAttributesCsv()
    {
        string[] expected = {
            "Domain,IPv4Address,IPv6Address,Password,UserAgent",
            ".net,46.159.103.234,1389:5863:4983:f7c8:8dd5:9439:a307:677d,4S:d=5D%u5K3435VSBeg36ht,\"Mozilla/5.0 (iPhone14,6; U; CPU iPhone OS 15_4 like Mac OS X) AppleWebKit/602.1.50 (KHTML, like Gecko) Version/10.0 Mobile/19E241 Safari/602.1\"",
            ".net,246.212.232.53,54db:8374:27a9:33cb:5fd2:33a2:f1a3:ada2,\"7:4o,jp?J2g1g20=\",\"Mozilla/5.0 (Linux; Android 13; Pixel 7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Mobile Safari/537.36\"",
            ".net,3.8.72.98,fd9e:2e1d:c6d3:c119:d509:5e24:b882:9317,<T34Ru46848e*M1WQD5-o04Wkfq,\"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_2) AppleWebKit/601.3.9 (KHTML, like Gecko) Version/9.0.2 Safari/601.3.9\"",
            ".edu,195.56.20.107,e1cd:e346:b6fd:48c1:9be8:dc9:24e9:f23,\"gyJAQ7,1D69#P48\",\"Mozilla/5.0 (Linux; Android 13; SM-A515U) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Mobile Safari/537.36\"",
            ".com,139.192.175.241,17d6:a405:98:c522:d936:37b5:cadf:9e37,/Np61UE6322uiw.b02J7e$7,\"Mozilla/5.0 (iPhone9,4; U; CPU iPhone OS 10_0_1 like Mac OS X) AppleWebKit/602.1.50 (KHTML, like Gecko) Version/10.0 Mobile/14A403 Safari/602.1\"",
        };

        var csvFaker = CsvUtils.ToCsvRows<ComputerAttributes>();

        Assert.That(csvFaker.Count, Is.EqualTo(expected.Length));

        Assert.Multiple(() =>
        {
            for (int i = 0; i < csvFaker.Count; i++)
            {
                Assert.That(csvFaker[i], Is.EqualTo(expected[i]));
            }
        });
    }
}

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
public class ComputerAttributes
{
    [FakerComputerDomain]
    public string Domain { get; set; }

    [FakerComputerIPv4Address]
    public string IPv4Address { get; set; }

    [FakerComputerIPv6Address]
    public string IPv6Address { get; set; }

    [FakerComputerPassword]
    public string Password { get; set; }

    [FakerComputerUserAgent]
    public string UserAgent { get; set; }
}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
