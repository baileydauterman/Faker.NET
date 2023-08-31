﻿namespace Faker.NET.Tests.RU
{
    internal class Names
    {
        [SetUp]
        public void Setup()
        {
            Faker.SetLocale("ru");
        }

        [Test]
        public void FirstName()
        {
            Assert.That(Faker.Name.First, Is.Not.Null);
        }

        [Test]
        public void LastName()
        {
            Assert.That(Faker.Name.Last, Is.Not.Null);
        }

        [Test]
        public void Jobs()
        {
            Assert.That(Faker.Name.Job, Is.Not.Null);
        }

        [Test]
        [TestCase(10_000)]
        public void StressFirstName(int count)
        {
            var i = 0;

            while (i < count)
            {
                _ = Faker.Name.First;

                i++;
            }
        }

        [Test]
        [TestCase(10_000)]
        public void StressLastName(int count)
        {
            var i = 0;

            while (i < count)
            {
                _ = Faker.Name.Last;

                i++;
            }
        }
    }
}
