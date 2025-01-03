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
            "\"(129, 45, 158)\",gudrun.pfannerstill,untidy-massage.quebec,.navy,youthful-validity,jaquelinl@burly-pecan.sarl,🅿️,PATCH,412 Precondition Failed,99.188.167.211,61ab:44dc:89ed:19a4:b177:f932:fdb9:f42,,B9D8C6F97E7C,Beg36hts71L71sd,28187,http,https://dull-maestro.supply,\"Mozilla/5.0 (Linux; Android 12; DE2118) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Mobile Safari/537.36\",bschmeler",
            "\"(209, 243, 113)\",little.aletha,agile-fund.cooking,.mx,quarterly-vista,schuster.demario@easy-drug.town,🖐🏻,POST,501 Not Implemented,73.235.20.162,8340:92ac:c31e:2fd:9e2e:1dc6:d3c1:19d5,,8C1F202EAE6C,34Ru46848e*M1WQ,21581,http,https://true-obligation.productions,\"Mozilla/5.0 (Linux; Android 13; M2101K6G) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Mobile Safari/537.36\",alena.tremblay",
            "\"(235, 139, 80)\",summer.kerluke,elderly-deed.party,.vet,snoopy-rosemary,johnston.curt@energetic-stall.fail,✌🏼,PUT,508 Loop Detected (WebDAV),74.124.209.64,24e9:f23:bed5:eb6b:a33c:c7e3:aef0:da6e,,B85A841CB8CB,j5:7n68V4Y8se=R,42799,http,https://first-markup.bargains,\"Mozilla/5.0 (Linux; Android 13; SM-S901U) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Mobile Safari/537.36\",philip.rohan",
            "\"(66, 210, 127)\",cpaucek,peppery-stir-fry.cruises,.us.com,favorite-dependency,randi.hand@unhealthy-majority.guitars,🙃,PUT,409 Conflict,227.72.105.99,b4f:baa3:d3a4:f74:1630:33a2:a90e:f02a,,C6376B7E2413,YNH!s$lc0044xdE,808,http,https://bare-louse.guitars,\"Mozilla/5.0 (iPhone9,4; U; CPU iPhone OS 10_0_1 like Mac OS X) AppleWebKit/602.1.50 (KHTML, like Gecko) Version/10.0 Mobile/14A403 Safari/602.1\",myrl.cruickshank",
            "\"(101, 13, 221)\",cassin.zella,vengeful-place.flights,.vc,authorized-expense,amya.robel@stained-intervention.engineering,💇🏼,DELETE,511 Network Authentication Required,190.28.12.138,8200:7d0b:18ac:8319:f4c6:58eb:d487:6dc7,,3F105B0FEDDD,Vsv8ilHmn(r70h.,44671,http,https://ajar-roundabout.limited,\"Mozilla/5.0 (Linux; Android 13; SM-A536U) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Mobile Safari/537.36\",jstanton",
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
