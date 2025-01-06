namespace Faker.NET.Tests.Utils;

public class DeterministicLocaleTestClass
{
    public DeterministicLocaleTestClass(FakerLocale locale)
    {
        Faker.SetLocale(locale);
    }

    [SetUp]
    public void Setup()
    {
        Faker.SetRandomizerSeed(123456789);
    }

    [TearDown]
    public void TearDown()
    {
        Faker.ResetRandomizer();
    }
}
