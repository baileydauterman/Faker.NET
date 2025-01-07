namespace Faker.NET.Common.Colors
{
    public class Hsl
    {
        public static Hsl Random()
        {
            return new Hsl
            {
                Hue = Faker.Randomizer.Next(0, 360),
                Saturation = Faker.Randomizer.NextDouble(),
                Lightness = Faker.Randomizer.NextDouble(),
            };
        }

        public int Hue { get; set; }

        public double Saturation { get; set; }

        public double Lightness { get; set; }
    }
}
