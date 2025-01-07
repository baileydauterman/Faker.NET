namespace Faker.NET.Tests.Utils
{
    internal class Asserts
    {
        public static void IsEqual<T>(T actual, T expected)
        {
            Console.WriteLine(actual);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
