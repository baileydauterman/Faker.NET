using System.Text;

namespace Faker.NET.EN
{
    public static class Lorem
    {
        public static string GetText(int words) => lorem.GetText(words);

        private static LoremIpsum lorem = new();
    }
}
