namespace Faker.NET.Tests
{
    internal class FakerDecorator
    {
        [Test]
        public void TestDecorator()
        {
            var generator = new Faker.NET.FakerDecorator("en-US");
        }
    }
}
