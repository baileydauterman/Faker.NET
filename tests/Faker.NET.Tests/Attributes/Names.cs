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
            "Johann,Daugherty,Lily Jacobson,terenceb@nippy-range.navy,Dr.,DVM,Central Interactions Designer",
            "Sidney,Boyer,Macy Sauer,rtremblay@illiterate-reconsideration.online,Dr.,Sr.,Corporate Mobility Agent",
            "Wayne,O'Reilly,Elenor Collins,kamrync@turbulent-obesity.fishing,Ms.,DDS,Customer Creative Designer",
            "Percy,Hodkiewicz,Violette McLaughlin,jaylink@flustered-bid.ai,Mr.,Jr.,Future Data Administrator",
            "Yasmine,Raynor,Alan Green,caltenwerth@white-solution.trade,Mrs.,III,Central Data Consultant",
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

    [FakerInternetEmail]
    public string Email { get; set; }

    [FakerNamePrefix]
    public string Prefix { get; set; }

    [FakerNameSuffix]
    public string Suffix { get; set; }

    [FakerNameJob]
    public string Job { get; set; }
}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.