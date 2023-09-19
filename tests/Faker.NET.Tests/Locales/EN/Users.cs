﻿using Objects = Faker.NET.Common.Objects;

namespace Faker.NET.Tests.EN
{
    public class Users
    {
        [Test]
        public void GenerateUsers()
        {
            var users = new List<Objects.User>();

            for (int i = 0; i < 4; i++)
            {
                users.Add(Faker.User.New);
            }

            Assert.That(users.Count, Is.EqualTo(4));
        }

        [Test]
        [TestCase(10_000)]
        [TestCase(100_000)]
        public void GenerateUser(int count)
        {
            for (int i = 0; i <= count; i++)
            {
                _ = Faker.User.New;
            }
        }
    }
}
