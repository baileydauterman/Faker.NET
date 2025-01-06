using Faker.NET.Attributes;
using Faker.NET.Tests.Utils;

namespace Faker.NET.Tests.Attributes;

public class Computer : DeterministicTestClass
{
    [Test]
    public void ClassAttributesCsv()
    {
        string[] expected = {
            "Rgb,DisplayName,DomainName,DomainSuffix,DomainWord,Email,Emoji,HttpMethod,HttpStatusCode,IPv4,IPv6,JWT,Mac,Password,Port,Protocol,Url,UserAgent,Username",
            "\"(129, 45, 158)\",gullrich,shadowy-other.yoga,.vodka,linear-toaster,kathlyns@skeletal-teammate.legal,🐛,DELETE,500 Internal Server Error,29.35.188.232,89ed:19a4:b177:f932:fdb9:f42:fbc5:3c49,,C6F97E7C4102,g36hts71L71sdCn,56025,http,https://content-validity.sexy,\"Mozilla/5.0 (Linux; Android 13; SM-S901U) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Mobile Safari/537.36\",rmante",
            "\"(90, 4, 93)\",dannyf,flimsy-cutlet.dentist,.town,earnest-babushka,dblock@utter-management.me.uk,😆,POST,400 Bad Request,110.4.196.58,c6d3:c119:d509:5e24:b882:9317:5d2a:99cc,,CB9BA7B1DA99,;7?1rH9l3+v7A<x,35889,http,https://unsung-cinema.gratis,\"Mozilla/5.0 (iPhone12,1; U; CPU iPhone OS 13_0 like Mac OS X) AppleWebKit/602.1.50 (KHTML, like Gecko) Version/10.0 Mobile/15E148 Safari/602.1\",daijar",
            "\"(55, 19, 106)\",edyth.franecki,late-vanadyl.direct,.industries,sudden-disadvantage,dante.armstrong@firm-character.win,🐿️,POST,101 Switching Protocols,65.168.175.186,6333:43e9:85b2:7fad:818:d55f:1d51:64b6,,DFD38CAFF7ED,H42$r25G\"98g4u6,39366,https,https://excited-travel.degree,\"Mozilla/5.0 (iPhone; CPU iPhone OS 11_0 like Mac OS X) AppleWebKit/604.1.38 (KHTML, like Gecko) Version/11.0 Mobile/15A5370a Safari/604.1\",rtowne",
            "\"(114, 31, 15)\",jerde.keeley,unhappy-solvency.blog,.clothing,shadowy-castanet,volkman.muriel@late-cap.black,🙉,POST,300 Multiple Choices,118.97.185.121,d0b3:401a:1bb8:a7f6:59ae:13c5:5f53:d6d9,,11701F1F0F8C,\"0iaB.SEjv7j6Xh,3606,http,https://shrill-desk.se.net,\"Mozilla/5.0 (Linux; Android 12; DE2118) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Mobile Safari/537.36\",ezboncak",
            "\"(28, 12, 138)\",abdulw,plain-trench.org,.report,qualified-translation,keven.fisher-windler@accomplished-farmer.press,💨,PATCH,501 Not Implemented,212.215.96.223,58a8:37d7:a116:6bdf:8d50:ca56:f8db:5608,,B31BCCF034B6,$t9=6o85\"13p6l\",40287,https,https://cute-mouser.org,\"Mozilla/5.0 (iPhone14,6; U; CPU iPhone OS 15_4 like Mac OS X) AppleWebKit/602.1.50 (KHTML, like Gecko) Version/10.0 Mobile/19E241 Safari/602.1\",hunter.wunsch",
        };

        var csvFaker = CsvUtils.ToCsvRows<ComputerAttributes>();

        Assert.That(csvFaker.Count, Is.EqualTo(expected.Length));

        Assert.Multiple(() =>
        {
            for (int i = 0; i < csvFaker.Count; i++)
            {
                Console.WriteLine(expected[i]);
                Assert.That(csvFaker[i], Is.EqualTo(expected[i]));
            }
        });
    }
}

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
public class ComputerAttributes
{
    [FakerInternetRgb]
    public string Rgb { get; set; }
    [FakerInternetDisplayName]
    public string DisplayName { get; set; }
    [FakerInternetDomainName]
    public string DomainName { get; set; }
    [FakerInternetDomainSuffix]
    public string DomainSuffix { get; set; }
    [FakerInternetDomainWord]
    public string DomainWord { get; set; }
    [FakerInternetEmail]
    public string Email { get; set; }
    [FakerInternetEmoji]
    public string Emoji { get; set; }
    [FakerInternetHttpMethod]
    public string HttpMethod { get; set; }
    [FakerInternetHttpStatusCode]
    public string HttpStatusCode { get; set; }
    [FakerInternetIPv4]
    public string IPv4 { get; set; }
    [FakerInternetIPv6]
    public string IPv6 { get; set; }
    [FakerInternetJWT]
    public string JWT { get; set; }
    [FakerInternetMac]
    public string Mac { get; set; }
    [FakerInternetPassword]
    public string Password { get; set; }
    [FakerInternetPort]
    public string Port { get; set; }
    [FakerInternetProtocol]
    public string Protocol { get; set; }
    [FakerInternetUrl]
    public string Url { get; set; }
    [FakerInternetUserAgent]
    public string UserAgent { get; set; }
    [FakerInternetUsername]
    public string Username { get; set; }
}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
