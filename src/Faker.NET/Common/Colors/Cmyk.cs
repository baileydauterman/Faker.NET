namespace Faker.NET.Common.Colors
{
    public class Cmyk
    {
        public double Cyan { get; set; }
        public double Magenta { get; set; }
        public double Yellow { get; set; }
        public double Key { get; set; }

        public string ForCss()
        {
            return $"cmyk({Cyan.ToPercentage()}%, {Magenta.ToPercentage()}%, {Yellow.ToPercentage()}%, {Key.ToPercentage()}%)";
        }
    }
}
