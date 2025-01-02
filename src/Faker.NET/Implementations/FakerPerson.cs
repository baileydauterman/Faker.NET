using Faker.NET.Common.Person;
using Faker.NET.Extensions;
using Faker.NET.Interfaces;
using Faker.NET.Interfaces.Definitions;

namespace Faker.NET.Implementations;

public class FakerPerson<T> : IFakerPerson where T : IFakerPersonDefinition
{
    public FakerPerson()
    {
        Data = Activator.CreateInstance<T>();
    }

    public string Bio()
    {
        throw new NotImplementedException();
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
        var weight = Faker.Randomizer.Next(100);
        if (weight < 95)
        {
            return Data.LastName.Get(sex);
        }
        else
        {
            return $"{Data.LastName.Unisex.GetRandom()}-{Data.LastName.Unisex.GetRandom()}";
        }
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

    private readonly IFakerPersonDefinition Data;
}
