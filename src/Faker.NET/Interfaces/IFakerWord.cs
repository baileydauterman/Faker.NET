using System;

namespace Faker.NET.Interfaces;

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
    public string Words(int min = 1, int max = 3);
}
