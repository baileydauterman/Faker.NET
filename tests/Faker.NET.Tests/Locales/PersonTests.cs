using Faker.NET.Common.Person;
using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Locales;

[TestFixture(FakerLocale.English)]
public class PersonTests : DeterministicLocaleTestClass
{
    public PersonTests(FakerLocale locale)
        : base(locale)
    {
    }

    [Test]
    public void All()
    {
        Assert.Multiple(() =>
        {
            Assert.That(Faker.Person.Bio(), Is.Not.Null);
            Assert.That(Faker.Person.FirstName(), Is.Not.Null);
            Assert.That(Faker.Person.FirstName(Sex.Female), Is.Not.Null);
            Assert.That(Faker.Person.FullName(), Is.Not.Null);
            Assert.That(Faker.Person.Gender(), Is.Not.Null);
            Assert.That(Faker.Person.JobArea(), Is.Not.Null);
            Assert.That(Faker.Person.JobDescriptor(), Is.Not.Null);
            Assert.That(Faker.Person.JobTitle(), Is.Not.Null);
            Assert.That(Faker.Person.JobType(), Is.Not.Null);
            Assert.That(Faker.Person.LastName(), Is.Not.Null);
            Assert.That(Faker.Person.MiddleName(), Is.Not.Null);
            Assert.That(Faker.Person.Prefix(), Is.Not.Null);
            Assert.That(Faker.Person.Sex(), Is.Not.Null);
            Assert.That(Faker.Person.Suffix(), Is.Not.Null);
            Assert.That(Faker.Person.ZodiacSign(), Is.Not.Null);
        });
    }
}
