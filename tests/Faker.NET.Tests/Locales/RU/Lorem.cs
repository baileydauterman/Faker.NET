namespace Faker.NET.Tests.RU
{
    internal class Lorem
    {
        public void Test()
        {
            Console.WriteLine(Faker.Lorem.GetText(5));
            Console.WriteLine(Faker.Lorem.GetText(50));
        }
    }
}
