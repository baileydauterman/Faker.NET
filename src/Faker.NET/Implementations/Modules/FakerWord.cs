using Faker.NET.Common;
using Faker.NET.Extensions;
using Faker.NET.Interfaces.Definitions;
using Faker.NET.Interfaces.Modules;

namespace Faker.NET.Implementations.Modules;

internal class FakerWord<T> : FakerDefinitionHandler<T>, IFakerWord where T : IFakerWordDefinition
{
    public string Adjective()
    {
        return Data.Adjective.GetRandom();
    }

    public string Adverb()
    {
        return Data.Adverb.GetRandom();
    }

    public string Conjunction()
    {
        return Data.Conjunction.GetRandom();
    }

    public string Interjection()
    {
        return Data.Interjection.GetRandom();
    }

    public string Noun()
    {
        return Data.Noun.GetRandom();
    }

    public string Preposition()
    {
        return Data.Preposition.GetRandom();
    }

    public string Sample()
    {
        return Faker.Randomizer.Next(7) switch
        {
            0 => Adjective(),
            1 => Adverb(),
            2 => Conjunction(),
            3 => Interjection(),
            4 => Noun(),
            5 => Preposition(),
            6 => Verb(),
            _ => Noun(),
        };
    }

    public string Verb()
    {
        return Data.Verb.GetRandom();
    }

    public string Words(uint min = 0, uint max = 100)
    {
        return Words((0, 100).AsRange());
    }

    public string Words(NumericRange<int> range)
    {
        var target = Faker.Randomizer.Next(range);
        var words = new string[target];

        while (target-- != 0)
        {
            words[target] = Sample();
        }

        return string.Join(' ', words);
    }
}
