namespace Faker.NET.Common.Colors
{
    public class Rgb
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }

        public override string ToString()
        {
            return $"({Red}, {Green}, {Blue})";
        }
    }
}
