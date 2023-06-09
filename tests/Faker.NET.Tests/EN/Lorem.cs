using System.Text;

namespace Faker.NET.Tests.EN
{
    internal class Lorem
    {
        [Test]
        public static void Test()
        {
            var str = new StringBuilder();

            str.Append(Faker.NET.EN.Lorem.GetText(5));
            str.Append($" {Faker.NET.EN.Lorem.GetText(50)}");

            Assert.That(str.ToString().Split(" ", StringSplitOptions.RemoveEmptyEntries).Count, Is.EqualTo(55));
        }
    }
}
