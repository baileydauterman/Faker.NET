using Faker.NET.Locales.RU.Names;

namespace FakerTestHarness.Russian
{
    internal class Names
    {
        public void TestNames()
        {
            Console.WriteLine($"{Name.FirstName}");
            Console.WriteLine($"{Name.LastName}");
            Console.WriteLine($"{Name.FullName}");
            Console.WriteLine($"{Name.JobTitle}");
        }
    }
}
