using Faker.NET.Common.Colors;
using Faker.NET.Interfaces.Modules;

namespace Faker.NET.Implementations
{
    internal class FakerColor : IFakerColor
    {
        public Cmyk Cmyk()
        {
            return new Cmyk
            {
                Cyan = Faker.Randomizer.NextPreciseDouble(2),
                Magenta = Faker.Randomizer.NextPreciseDouble(2),
                Yellow = Faker.Randomizer.NextPreciseDouble(2),
                Key = Faker.Randomizer.NextPreciseDouble(2),
            };
        }

        public string ColorByCSSColorSpace()
        {
            throw new NotImplementedException();
        }

        public string CssSupportedFunction()
        {
            throw new NotImplementedException();
        }

        public string CssSupportedSpace()
        {
            throw new NotImplementedException();
        }

        public Hsl Hsl()
        {
            return Common.Colors.Hsl.Random();
        }

        public string Human()
        {
            throw new NotImplementedException();
        }

        public Hwb Hwb()
        {
            return Common.Colors.Hwb.Random();
        }

        public string Lab()
        {
            throw new NotImplementedException();
        }

        public Lch Lch()
        {
            return Common.Colors.Lch.Random();
        }

        public Rgb Rgb(byte? redBase = null, byte? greenBase = null, byte? blueBase = null)
        {
            return new Rgb
            {
                Red = redBase ?? (byte)Faker.Randomizer.Next(0, 255),
                Green = greenBase ?? (byte)Faker.Randomizer.Next(0, 255),
                Blue = blueBase ?? (byte)Faker.Randomizer.Next(0, 255),
            };
        }

        public string Space()
        {
            throw new NotImplementedException();
        }
    }
}
