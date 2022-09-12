using System.Text;

namespace Faker.NET.EN.Lorem
{
    public static class Lorem
    {
        public static string GetText(int words)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < words; i++)
            {
                sb.Append($"{lorem.Get()} ");
            }

            return sb.ToString().Trim();
        }

        private static LoremIpsum lorem = new();
    }
}
