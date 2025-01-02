using System.Text;
using Faker.NET.Extensions;
using Faker.NET.Interfaces.Definitions;
using Faker.NET.Modules.Interfaces;

namespace Faker.NET.Implementations;

internal class FakerLorem<T> : FakerDefinitionHandler<T>, IFakerLorem where T : IFakerLoremDefinition
{
    public string Words(int words) => Data.Words.CreateRandomString(words);

    public string Words(int min, int max) => Data.Words.CreateRandomLengthString(min, max);

    public string Paragraphs(int count)
    {
        var builder = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            var paragraph = Sentences(4, 12);
            builder.Append(paragraph);
        }

        return builder.ToString().Trim();
    }

    public string Paragraphs(int min, int max)
    {
        var exact = Faker.Randomizer.Next(min, max);
        return Paragraphs(exact);
    }

    public string Sentences(int count)
    {
        var builder = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            var sentence = Words(4, 18);
            builder.Append($"{sentence}. ");
        }

        return builder.ToString().Trim();
    }

    public string Sentences(int min, int max)
    {
        var exact = Faker.Randomizer.Next(min, max);
        return Sentences(exact);
    }

    public string Word()
    {
        throw new NotImplementedException();
    }

    public string Paragraph()
    {
        throw new NotImplementedException();
    }

    public string Sentences()
    {
        throw new NotImplementedException();
    }

    public string Slug(int min = 1, int max = 3)
    {
        throw new NotImplementedException();
    }

    public string Text()
    {
        throw new NotImplementedException();
    }
}
