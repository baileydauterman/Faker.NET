using Faker.NET.Common.Colors;

namespace Faker.NET.Interfaces.Modules;

public interface IFakerColor
{
    public Cmyk Cmyk();
    public string ColorByCSSColorSpace();
    public string CssSupportedFunction();
    public string CssSupportedSpace();
    public Hsl Hsl();
    public string Human();
    public Hwb Hwb();
    public string Lab();
    public Lch Lch();
    public Rgb Rgb(byte? redBase = null, byte? greenBase = null, byte? blueBase = null);
    public string Space();
}
