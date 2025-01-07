namespace Faker.NET.Common.Colors;
public class Hwb
{
    public static Hwb Random()
    {
        return new Hwb
        {
            Hue = Faker.Randomizer.Next(0, 360),
            Whiteness = Faker.Randomizer.NextDouble(),
            Blackness = Faker.Randomizer.NextDouble(),
        };
    }

    public int Hue { get; set; }

    public double Whiteness { get; set; }

    public double Blackness { get; set; }
}
