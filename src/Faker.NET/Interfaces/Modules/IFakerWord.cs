using Faker.NET.Common;

namespace Faker.NET.Interfaces.Modules;

public interface IFakerWord
{
    public string Adjective();
    public string Adverb();
    public string Conjunction();
    public string Interjection();
    public string Noun();
    public string Preposition();
    public string Sample();
    public string Verb();
    public string Words(uint min = 0, uint max = 100);
    public string Words(NumericRange<int> range);
}
