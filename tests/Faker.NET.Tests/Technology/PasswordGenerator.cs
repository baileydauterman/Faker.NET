namespace Faker.NET.Tests.Technology;

public class PasswordGenerator
{
    [Test]
    public void GeneratePassword()
    {
        var password = Faker.Computer.Password;
        Assert.That(password.Length, Is.InRange(15,28));
    }
}
