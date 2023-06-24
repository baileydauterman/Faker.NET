using Faker.NET.EN.Account;

namespace Faker.NET.Tests.EN
{
    public class Users
    {
        [Test]
        public void GenerateUsers()
        {
            var users = new List<Faker.NET.Common.Objects.User>();

            for (int i = 0; i < 4; i++)
            {
                users.Add(User.NewAccount);
            }

            Assert.That(users.Count, Is.EqualTo(4));
        }

        [Test]
        [TestCase(10_000)]
        [TestCase(100_000)]
        [TestCase(1_000_000)]
        public void GenerateUser(int count)
        {
            for (int i  = 0; i <= count; i++)
            {
                _ = User.NewAccount;
            }
        }
    }
}
