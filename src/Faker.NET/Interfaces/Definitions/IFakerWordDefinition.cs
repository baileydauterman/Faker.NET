using System;

namespace Faker.NET.Interfaces.Definitions;

public interface IFakerWordDefinition
{
    public string[] Adjective { get; }
    public string[] Adverb { get; }
    public string[] Conjunction { get; }
    public string[] Interjection { get; }
    public string[] Noun { get; }
    public string[] Preposition { get; }
    public string[] Verb { get; }
}
