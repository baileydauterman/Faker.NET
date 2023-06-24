using System.Text;

namespace Faker.NET.EN
{
    public static class Lorem
    {
        public static string GetText(int words) => lorem.GetText(words);

        public static string GetText(int min, int max) => lorem.GetText(min, max);

        private static LoremIpsum lorem = new();
    }
}
