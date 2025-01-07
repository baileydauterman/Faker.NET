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
            "253-860-8565 x8848,805-776-8436 x5711,885.314.1177 x5336",
            "(747) 485-4746 x2001,273-860-2160,878.234.7781 x0611",
            "1-114-741-8757 x840,(530) 325-5823 x7212,1-202-728-0584 x50023",
            "1-162-360-3846 x181,286-836-6565,607.655.6787 x488",
            "1-262-347-1473,1-317-563-0580 x8428,1-401-268-6610",
        };

        var csvFaker = CsvUtils.ToCsvRows<PhoneNumbersAttributes>();

        Assert.That(csvFaker.Count, Is.EqualTo(expected.Length));

        Assert.Multiple(() =>
        {
            for (int i = 0; i < csvFaker.Count; i++)
            {
                Console.WriteLine(csvFaker[i]);
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
