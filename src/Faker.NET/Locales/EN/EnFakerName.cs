using Faker.NET.Extensions;
using Faker.NET.Interfaces;
using Faker.NET.Locales.EN.Data;

namespace Faker.NET.Locales.EN;

public class EnFakerName : IFakerName
{
    public string First => Names.First.GetRandom();

    public string Last => Names.Last.GetRandom();

    public string Full => $"{First} {Last}";

    public string Suffix => Names.Suffix.GetRandom();

    public string Prefix => Names.Prefix.GetRandom();

    public string Job => $"{Names.TitleLevel.GetRandom()} {Names.TitleDescriptor.GetRandom()} {Names.TitleJob.GetRandom()}";
}
