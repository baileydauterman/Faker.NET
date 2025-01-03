using System;
using Faker.NET.Attributes;
using Faker.NET.Common.Phone;
using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Attributes;

public class PhoneNumbers : DeterministicTestClass
{
    [Test]
    public void ClassAttributesCsv()
    {
        string[] expected = {
            "PhoneNumber,CountryCode,WithAreaCode",
            "254-861-8566 x8848,816-777-8546 x6712,886.325.2277 x5346",
            "(757) 485-4847 x3112,274-861-3271,878.244.7782 x1622",
            "1-125-742-8767 x841,(531) 326-6833 x7323,1-212-738-1685 x51134",
            "1-172-371-3857 x182,286-847-6566,617.655.6787 x588",
            "1-263-357-1483,1-327-564-1581 x8538,1-412-268-7721",
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

    [FakerPhoneNumber(Type = PhoneNumberType.International)]
    public int CountryCode { get; set; }

    [FakerPhoneNumber(Type = PhoneNumberType.National)]
    public string WithAreaCode { get; set; }
}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
