using Faker.NET.Interfaces.Definitions;

namespace Faker.NET.Locales.DE.Data
{
    internal class DePhoneNumberData : IFakerPhoneDefinition
    {
        public string[] Human { get; } = {
            "(0###) #########",
            "(0####) #######",
            "+49-###-#######",
            "+49-####-########",
        };

        public string[] National { get; } = {
            "0#### ########", "0#### #######", "0#### ######"
        };

        public string[] International { get; } = {
            "+49############", "+49###########", "+49##########"
        };
    }
}
