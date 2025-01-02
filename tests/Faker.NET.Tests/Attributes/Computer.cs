using Faker.NET.Attributes;
using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Attributes;

public class Computer : DeterministicTestClass
{
    [Test]
    [Ignore("PITA to update")]
    public void ClassAttributesCsv()
    {
        string[] expected = {
            "Domain,IPv4Address,IPv6Address,Password,UserAgent",
            "helpless-instance.monster,103.233.174.20,5863:4983:f7c8:8dd5:9439:a307:677d:631d,\"-51s8*nd7,S:9Y/\",\"Mozilla/5.0 (Linux; Android 12; SM-G973U) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Mobile Safari/537.36\"",
            "gleaming-explanation.diamonds,20.3.45.7,b2f7:b804:a66e:db74:31e3:c2a9:d469:c454,\"T8a&kf;D7:4o,jp\",\"Mozilla/5.0 (Linux; Android 13; SM-S908U) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/111.0.0.0 Mobile Safari/537.36\"",
            "wild-success.fitness,209.71.54.69,777f:2c59:3273:cbea:d083:4092:acc3:1e02,A2Tj411e6367/#5,\"Mozilla/5.0 (Linux; Android 13; SM-S901U) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Mobile Safari/537.36\"",
            "magnificent-mode.tax,241.205.130.250,ca4:be12:8329:14a7:314e:f029:3481:2951,7A<x*1Cf>6bHvGl,\"Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/47.0.2526.111 Safari/537.36\"",
            "distinct-loss.ski,65.58.100.123,23be:d5eb:6ba3:3cc7:e3ae:f0da:6e8b:6333,1D69#P4818>37H4,\"Mozilla/5.0 (Linux; Android 13; SM-A536B) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Mobile Safari/537.36\"",
        };

        var csvFaker = CsvUtils.ToCsvRows<ComputerAttributes>();

        Assert.That(csvFaker.Count, Is.EqualTo(expected.Length));

        Assert.Multiple(() =>
        {
            for (int i = 0; i < csvFaker.Count; i++)
            {
                Console.WriteLine(expected[i]);
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
