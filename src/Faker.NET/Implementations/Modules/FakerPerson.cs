using Faker.NET.Common.Person;
using Faker.NET.Extensions;
using Faker.NET.Implementations.Definitions;
using Faker.NET.Interfaces.Modules;

namespace Faker.NET.Implementations.Modules;

internal class FakerPerson : FakerDefinitionHandler<BaseFakerPersonDefinition>, IFakerPerson
{
    public string Bio()
    {
        return Faker.Mustache.Replace(Data.BioPattern.GetRandom());
    }

    public string BioPart()
    {
        return Data.BioPart.GetRandom();
    }

    public string BioSupporter()
    {
        return Data.BioSupporter.GetRandom();
    }

    public string FirstName(Sex? sex)
    {
        return Data.FirstName.Get(sex);
    }

    public string FullName(string? firstName, string? lastName, Sex? sex)
    {
        sex ??= Sex();
        firstName ??= FirstName(sex);
        var middleName = MiddleName(sex);
        lastName ??= LastName(sex);
        // var pattern = Data.Name.GetValue();

        return $"{firstName} {middleName} {lastName}";
    }

    public string Gender()
    {
        return Data.Gender.GetRandom();
    }

    public string JobArea()
    {
        return Data.JobArea.GetRandom();
    }

    public string JobDescriptor()
    {
        return Data.JobDescriptor.GetRandom();
    }

    public string JobTitle()
    {
        return $"{JobDescriptor()} {JobArea()} {JobType()}";
    }

    public string JobType()
    {
        return Data.JobType.GetRandom();
    }

    public string LastName(Sex? sex)
    {
        sex ??= Sex();
        return Data.LastName.Get(sex);
    }

    public string LastNamePattern()
    {
        var template = Data.LastNamePattern.GetValue();
        return Faker.Mustache.Replace(template);
    }

    public string MiddleName(Sex? sex)
    {
        return Data.MiddleName.Get(sex);
    }

    public string Prefix(Sex? sex)
    {
        return Data.Prefix.Get(sex);
    }

    public Sex Sex()
    {
        return RandomizerExtensions.GetRandom<Sex>();
    }

    public string Suffix()
    {
        return Data.Suffix.GetRandom();
    }

    public string ZodiacSign()
    {
        return Data.ZodiacSign.GetRandom();
    }
}
