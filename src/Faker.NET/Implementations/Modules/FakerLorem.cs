using System.Text;
using Faker.NET.Extensions;
using Faker.NET.Implementations.Definitions;
using Faker.NET.Interfaces.Modules;

namespace Faker.NET.Implementations.Modules;

internal class FakerLorem : FakerDefinitionHandler<BaseFakerLoremDefinition>, IFakerLorem
{
    public string Words(int min, int max) => Data.Words.CreateRandomString(min, max);

    public string Paragraphs(int min, int max)
    {
        var count = Faker.Randomizer.Next(min, max);
        var builder = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            builder.Append(Paragraph());
        }

        return builder.ToString().Trim();
    }

    public string Sentences(int min, int max)
    {
        var count = Faker.Randomizer.Next(min, max);
        var builder = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            builder.Append($"{Sentence()} ");
        }

        return builder.ToString().Trim();
    }

    public string Word()
    {
        return Data.Words.GetRandom();
    }

    public string Paragraph()
    {
        return Sentences(4, 12);
    }

    public string Sentence()
    {
        return $"{Words(4, 18)}.";
    }

    public string Slug(int min = 1, int max = 3)
    {
        return Words(min, max).ToSlug();
    }

    public string Text()
    {
        return Words(5, 150);
    }

    public string Lines(int min = 1, int max = 3)
    {
        var builder = new StringBuilder();
        var count = Faker.Randomizer.Next(1, 3);

        while (count-- > 0)
        {
            builder.AppendLine(Sentence());
        }

        return builder.ToString();
    }
}
