namespace Faker.NET.Tests.Utils;

/// <summary>
/// Sets seed and resets seed on SetUp and TearDown, respectively.
/// </summary>
public class DeterministicTestClass
{
    [SetUp]
    public void SetUp()
    {
        Faker.SetRandomizerSeed(123456789);
    }

    [TearDown]
    public void TearDown()
    {
        Faker.ResetRandomizer();
    }
}
