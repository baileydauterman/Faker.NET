using System;
using Faker.NET.Technology.PasswordGenerator;

namespace Faker.NET.Tests.Technology;

public class PasswordGenerator
{
    [Test]
    public void GeneratePassword()
    {
        var generator = new FakerPasswordGenerator();
        var password = generator.Generate(25);
        Assert.That(password.Length, Is.EqualTo(25));

        password = generator.Generate(25, PasswordGeneratorFlags.None);
        Assert.That(password, Is.EqualTo(""));

        password = generator.Generate(32, PasswordGeneratorFlags.UpperCase | PasswordGeneratorFlags.LowerCase);
        Assert.That(password.Length, Is.EqualTo(32));

        password = generator.Generate(49, PasswordGeneratorFlags.Special | PasswordGeneratorFlags.Numbers);
        Assert.That(password.Length, Is.EqualTo(48));
    }
}
