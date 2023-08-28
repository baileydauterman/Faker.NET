using Faker.NET.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.NET.Locales.EN
{
    internal class ENLocale : IFakerLocale
    {
        public ENLocale()
        {
            Name = new Faker.NET.EN.Names.Name();
        }

        public IFakerName Name { get; }
    }
}
