using Faker.NET.Common;
using Faker.NET.Common.Person;

namespace Faker.NET.Interfaces.Definitions;

public interface IFakerPersonDefinition
{
    public string[] BioPart { get; }
    public string[] BioPattern { get; }
    public string[] BioSupporter { get; }
    public SexSpecificValues<string> FirstName { get; }
    public string[] Gender { get; }
    public string[] JobArea { get; }
    public string[] JobDescriptor { get; }
    public string[] JobTitlePattern { get; }
    public string[] JobType { get; }
    public SexSpecificValues<string> LastName { get; }
    public WeightedList<string> LastNamePattern { get; }
    public SexSpecificValues<string> MiddleName { get; }
    public WeightedList<Func<string>> Name { get; }
    public SexSpecificValues<string> Prefix { get; }
    public string[] Suffix { get; }
    public string[] ZodiacSign { get; }
}
