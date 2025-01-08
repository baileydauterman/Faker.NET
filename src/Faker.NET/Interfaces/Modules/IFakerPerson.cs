using Faker.NET.Common.Person;

namespace Faker.NET.Interfaces.Modules;

public interface IFakerPerson
{
    public string Bio();
    public string BioPart();
    public string BioSupporter();
    public string FirstName(Sex? sex = null);
    public string FullName(string? firstName = null, string? lastName = null, Sex? sex = null);
    public string Gender();
    public string JobArea();
    public string JobDescriptor();
    public string JobTitle();
    public string JobType();
    public string LastName(Sex? sex = null);
    public string MiddleName(Sex? sex = null);
    public string Prefix(Sex? sex = null);
    public Sex Sex();
    public string Suffix();
    public string ZodiacSign();
}
