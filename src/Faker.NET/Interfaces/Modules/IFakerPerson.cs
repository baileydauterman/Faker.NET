using Faker.NET.Common.Person;

namespace Faker.NET.Modules.Interfaces;

public interface IFakerPerson
{
    public string Bio();
    public string FirstName(Sex? sex);
    public string FullName(string? firstName, string? lastName, Sex? sex);
    public string Gender();
    public string JobArea();
    public string JobDescriptor();
    public string JobTitle();
    public string JobType();
    public string LastName(Sex? sex);
    public string MiddleName(Sex? sex);
    public string Prefix(Sex? sex);
    public Sex Sex();
    public string Suffix();
    public string ZodiacSign();
}
