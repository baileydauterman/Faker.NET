using Faker.NET.Common;
using Faker.NET.Common.Person;
using Faker.NET.Interfaces.Definitions;

namespace Faker.NET.Implementations.Definitions;

internal class BaseFakerPersonDefinition : IFakerPersonDefinition
{
    public IReadOnlyCollection<string> BioPart => lazyBioPart.Value;

    public IReadOnlyCollection<string> BioPattern => lazyBioPattern.Value;

    public IReadOnlyCollection<string> BioSupporter => lazyBioSupporter.Value;

    public SexSpecificValues<string> FirstName => lazyFirstName.Value;

    public IReadOnlyCollection<string> Gender => lazyGender.Value;

    public IReadOnlyCollection<string> JobArea => lazyJobArea.Value;

    public IReadOnlyCollection<string> JobDescriptor => lazyJobDescriptor.Value;

    public IReadOnlyCollection<string> JobTitlePattern => lazyJobTitlePattern.Value;

    public IReadOnlyCollection<string> JobType => lazyJobType.Value;

    public SexSpecificValues<string> LastName => lazyLastName.Value;

    public WeightedList<string> LastNamePattern => lazyLastNamePattern.Value;

    public SexSpecificValues<string> MiddleName => lazyMiddleName.Value;

    public WeightedList<string> Name => lazyNames.Value;

    public SexSpecificValues<string> Prefix => lazyPrefixes.Value;

    public IReadOnlyCollection<string> Suffix => lazySuffixes.Value;

    public IReadOnlyCollection<string> ZodiacSign => lazyZodiacSign.Value;

    internal Lazy<IReadOnlyCollection<string>> lazyBioPart = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Person", "bio_parts"));
    internal Lazy<IReadOnlyCollection<string>> lazyBioPattern = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Person", "bio_patterns"));
    internal Lazy<IReadOnlyCollection<string>> lazyBioSupporter = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Person", "bio_supporters"));
    internal Lazy<SexSpecificValues<string>> lazyFirstName = new(() => Faker.ResourceRetriever.Get<SexSpecificValues<string>>(Faker.Culture.TwoLetterISOLanguageName, "Person", "first_names"));
    internal Lazy<IReadOnlyCollection<string>> lazyGender = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Person", "genders"));
    internal Lazy<IReadOnlyCollection<string>> lazyJobArea = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Person", "job_areas"));
    internal Lazy<IReadOnlyCollection<string>> lazyJobDescriptor = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Person", "job_descriptors"));
    internal Lazy<IReadOnlyCollection<string>> lazyJobTitlePattern = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Person", "job_title_patterns"));
    internal Lazy<IReadOnlyCollection<string>> lazyJobType = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Person", "job_types"));
    internal Lazy<SexSpecificValues<string>> lazyLastName = new(() => Faker.ResourceRetriever.Get<SexSpecificValues<string>>(Faker.Culture.TwoLetterISOLanguageName, "Person", "last_names"));
    internal Lazy<WeightedList<string>> lazyLastNamePattern = new(() => new WeightedList<string>(Faker.ResourceRetriever.Get<string, int>(Faker.Culture.TwoLetterISOLanguageName, "Person", "last_name_patterns")));
    internal Lazy<SexSpecificValues<string>> lazyMiddleName = new(() => Faker.ResourceRetriever.Get<SexSpecificValues<string>>(Faker.Culture.TwoLetterISOLanguageName, "Person", "middle_names"));
    internal Lazy<WeightedList<string>> lazyNames = new(() => new WeightedList<string>(Faker.ResourceRetriever.Get<string, int>(Faker.Culture.TwoLetterISOLanguageName, "Person", "name_patterns")));
    internal Lazy<SexSpecificValues<string>> lazyPrefixes = new(() => Faker.ResourceRetriever.Get<SexSpecificValues<string>>(Faker.Culture.TwoLetterISOLanguageName, "Person", "prefixes"));
    internal Lazy<IReadOnlyCollection<string>> lazySuffixes = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Person", "suffixes"));
    internal Lazy<IReadOnlyCollection<string>> lazyZodiacSign = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Person", "zodiac_signs"));
}
