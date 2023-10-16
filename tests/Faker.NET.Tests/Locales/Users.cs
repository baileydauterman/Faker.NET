using Objects = Faker.NET.Common.Objects;

namespace Faker.NET.Tests.Locales
{
    [TestFixture("en")]
    public class Users
    {
        public Users(string locale)
        {
            Faker.SetLocale(locale);
        }

        [Test]
        public void GenerateUsers()
        {
            var users = new List<Objects.User>();

            for (int i = 0; i < 4; i++)
            {
                users.Add(Faker.User.New);
            }

            Assert.That(users, Has.Count.EqualTo(4));
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
