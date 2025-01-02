using System;
using Faker.NET.Attributes;
using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Attributes;

public class PhoneNumbers : DeterministicTestClass
{
    [Test]
    [Ignore("WIP: Lost formats somewhere")]
    public void ClassAttributesCsv()
    {
        string[] expected = {
            "PhoneNumber,CountryCode,WithAreaCode",
            "904-386-8565,1,+1 564.848.5776",
            "831.657.1688,1,+1 629-411-7533",
            "915.473.5474,1,+1 956-010-7386",
            "351-606-7813,1,+1 239.810.1130",
            "779.418.5784,1,+1 508.303.5582",
        };

        var csvFaker = CsvUtils.ToCsvRows<PhoneNumbersAttributes>();

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
public class PhoneNumbersAttributes
{
    [FakerPhoneNumber]
    public string PhoneNumber { get; set; }

    [FakerPhoneNumberCountryCode]
    public int CountryCode { get; set; }

    [FakerPhoneNumberWithAreaCode]
    public string WithAreaCode { get; set; }
}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
