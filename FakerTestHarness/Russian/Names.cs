using Faker.NET.Locales.RU.Names;

namespace FakerTestHarness.Russian
{
    internal static class Names
    {
        public static void TestNames()
        {
            Console.WriteLine($"{Name.FirstName}");
            Console.WriteLine($"{Name.LastName}");
            Console.WriteLine($"{Name.FullName}");
            Console.WriteLine($"{Name.JobTitle}");
        }
    }
}
