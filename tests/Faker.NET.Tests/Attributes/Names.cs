using Faker.NET.Attributes;
using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Attributes;

public class Names : DeterministicTestClass
{
    [Test]
    public void ClassAttributesCsv()
    {
        string[] expected = {
            "First,Last,Full,Email,Prefix,Suffix,Job",
            "Johann,Daugherty,Lily Jacobson,Terence@Pfannerstill,Mr.,PhD,Customer Assurance Orchestrator",
            "Zechariah,Wilderman,Jaquelin Volkman,Kathlyn@Towne,Mr.,MD,Forward Creative Producer",
            "Sonia,Little,Gina Rippin,Maegan@Simonis,Mr.,Sr.,Legacy Interactions Strategist",
            "Mallory,Gulgowski,Brionna Lindgren,Candelario@Cole,Dr.,PhD,Investor Identity Administrator",
            "Neal,McKenzie,Riley Lemke,Percy@Hodkiewicz,Dr.,V,Central Accountability Architect",
        };

        var csvFaker = CsvUtils.ToCsvRows<NamesAttributes>();

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
public class NamesAttributes
{
    [FakerNameFirst]
    public string First { get; set; }

    [FakerNameLast]
    public string Last { get; set; }

    [FakerNameFull]
    public string Full { get; set; }

    [FakerNameEmail]
    public string Email { get; set; }

    [FakerNamePrefix]
    public string Prefix { get; set; }

    [FakerNameSuffix]
    public string Suffix { get; set; }

    [FakerNameJob]
    public string Job { get; set; }
}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.