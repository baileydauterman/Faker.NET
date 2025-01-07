namespace Faker.NET.Common.Colors
{
    public class Lch
    {
        public static Lch Random()
        {
            return new Lch
            {
                Lightness = Faker.Randomizer.Next(0, 101),
                Chroma = Faker.Randomizer.Next(0, 129),
                Hue = Faker.Randomizer.Next(0, 361),
            };
        }

        public int Lightness { get; set; }

        public int Chroma { get; set; }

        public int Hue { get; set; }
    }
}
