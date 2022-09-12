namespace FakerTestHarness.English
{
    internal class Lorem
    {
        public static void Test()
        {
            Console.WriteLine(Faker.NET.EN.Lorem.Lorem.GetText(5));
            Console.WriteLine(Faker.NET.EN.Lorem.Lorem.GetText(50));
        }
    }
}
