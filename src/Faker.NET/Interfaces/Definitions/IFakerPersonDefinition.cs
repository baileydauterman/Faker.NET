using Faker.NET.Common;
using Faker.NET.Common.Person;

namespace Faker.NET.Interfaces.Definitions;

public interface IFakerPersonDefinition
{
    public IReadOnlyCollection<string> BioPart { get; }
    public IReadOnlyCollection<string> BioPattern { get; }
    public IReadOnlyCollection<string> BioSupporter { get; }
    public SexSpecificValues<string> FirstName { get; }
    public IReadOnlyCollection<string> Gender { get; }
    public IReadOnlyCollection<string> JobArea { get; }
    public IReadOnlyCollection<string> JobDescriptor { get; }
    public IReadOnlyCollection<string> JobTitlePattern { get; }
    public IReadOnlyCollection<string> JobType { get; }
    public SexSpecificValues<string> LastName { get; }
    public WeightedList<string> LastNamePattern { get; }
    public SexSpecificValues<string> MiddleName { get; }
    public WeightedList<string> Name { get; }
    public SexSpecificValues<string> Prefix { get; }
    public IReadOnlyCollection<string> Suffix { get; }
    public IReadOnlyCollection<string> ZodiacSign { get; }
}
