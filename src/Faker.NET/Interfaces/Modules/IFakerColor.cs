using Faker.NET.Common.Colors;

namespace Faker.NET.Interfaces.Modules
{
    public interface IFakerColor
    {
        public Cmyk Cmyk();
        public string ColorByCSSColorSpace();
        public string CssSupportedFunction();
        public string CssSupportedSpace();
        public string Hsl();
        public string Human();
        public string Hwb();
        public string Lab();
        public string Lch();
        public string Rgb();
        public string Space();
    }
}
