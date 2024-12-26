namespace Faker.NET.Tests.Technology;

public class PasswordGenerator
{
    [Test]
    public void GeneratePassword()
    {
        var password = Faker.Internet.Password();
        Assert.That(password.Length, Is.InRange(15, 28));
    }
}
