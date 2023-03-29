using Faker.NET.EN.Account;

namespace Faker.NET.Tests.EN
{
    public static class Users
    {
        [Test]
        public static void GenerateUsers()
        {
            var users = new List<Faker.NET.Common.Objects.User>();

            for (int i = 0; i < 4; i++)
            {
                users.Add(User.NewAccount);
            }

            Assert.That(users.Count, Is.EqualTo(4));
        }
    }
}
