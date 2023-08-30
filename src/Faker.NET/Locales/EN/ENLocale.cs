using Faker.NET.API;

namespace Faker.NET.Locales.EN
{
    internal class ENLocale : IFakerLocale
    {
        public ENLocale()
        {
            Name = new NET.EN.Names.Name();
            User = new NET.EN.Account.User();
            Lorem = new NET.EN.Lorem();
        }

        public IFakerName Name { get; }

        public IFakerUser User { get; }

        public IFakerLorem Lorem { get; }
    }
}
