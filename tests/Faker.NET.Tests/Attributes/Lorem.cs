using Faker.NET.Attributes;
using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Attributes;

public class Lorem : DeterministicTestClass
{
    [Test]
    public void ClassAttributesCsv()
    {
        var csvFaker = CsvUtils.ToCsvRows<LoremAttributes>();

        Assert.That(csvFaker.Count, Is.EqualTo(6));

        Assert.Multiple(() =>
        {
            for (int i = 0; i < csvFaker.Count; i++)
            {
                var line = csvFaker[i].Replace(",", string.Empty);
                Assert.That(line, Is.Not.WhiteSpace.Or.Null.Or.Empty);
            }
        });
    }
}

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
public class LoremAttributes
{
    [FakerLoremWords(Min = 3, Max = 10)]
    public string LoremWords { get; set; }

    [FakerLoremSentences(Max = 3)]
    public string LoremSentences { get; set; }

    [FakerLoremParagraph(Min = 1, Max = 10)]
    public string LoremParagraphs { get; set; }
}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
