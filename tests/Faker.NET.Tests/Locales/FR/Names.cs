using System;
using Faker.NET.FR.Names;

namespace Faker.NET.Tests.FR
{
	public class Names
	{
        [Test]
        public static void TestNames()
        {
            Assert.That(Name.FirstName, Is.Not.Null);
            Assert.That(Name.LastName, Is.Not.Null);
            Assert.That(Name.FullName, Is.Not.Null);
        }
    }
}

