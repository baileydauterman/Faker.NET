﻿using Faker.NET.Common.Internet;
using Faker.NET.Implementations;
using Faker.NET.Locales.EN.Data;

namespace Faker.NET.Locales.EN;

internal class ENLocale : FakerLocaleInstance
{
    public ENLocale()
    {
        Person = new FakerPerson<EnFakerPersonData>();
        Airline = new FakerAirline<EnAirlineData>();
        Commerce = new FakerCommerce<EnCommerce>();
        Location = new FakerLocation<EnLocationData>();
        Word = new FakerWord<EnWordData>();
        Date = new FakerDate();
        Internet = new FakerInternet<EnFakerInternetData>();
        PhoneNumber = new FakerPhone<EnFakerPhoneData>();
        Lorem = new FakerLorem<EnLoremData>();

        Name = new EnFakerName();
    }
}
