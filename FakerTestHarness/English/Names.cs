using Faker.NET.Locales.EN.Names;

namespace FakerTestHarness.English
{
    internal class Names
    {
        public void TestNames()
        {
            Console.WriteLine($"{Name.FirstName}");
            Console.WriteLine($"{Name.LastName}");
            Console.WriteLine($"{Name.FullName}");
            Console.WriteLine($"{Name.JobTitle}");
            Console.WriteLine($"{Name.Suffix}");
            Console.WriteLine($"{Name.Prefix}");
            Console.WriteLine($"{Name.Email}");
        }
    }
}
