using Faker.NET.Attributes;
using Faker.NET.Tests.Utils;
using NUnit.Framework.Internal;
namespace Faker.NET.Tests.Attributes;
public class Computer : DeterministicTestClass
{
    [Test]
    public void ClassAttributesCsv()
    {
        string[] expected = {
            "DisplayName,DomainName,DomainSuffix,DomainWord,Email,Emoji,HttpMethod,HttpStatusCode,IPv4,IPv6,JWT,Mac,Password,Port,Protocol,Url,UserAgent,Username",
            "jvon,boring-testimonial.limited,.quebec,precious-yeast,velda.towne@qualified-scale.ski,🪟,PUT,400 Bad Request,188.167.211.28,ab44:dc89:ed19:a4b1:77f9:32fd:b90f:42fb,,9D8C6F97E7C4,aatY!E0>8jT8a&k,6298,http,https://natural-stitcher.hn,\"Mozilla/5.0 (iPhone; CPU iPhone OS 12_0 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) CriOS/69.0.3497.105 Mobile/15E148 Safari/605.1\",wilderman.vella",
            "auer.alessia,enchanting-order.one,.wedding,extroverted-gerbil,reilly.turcotte@back-designation.srl,👩🏿‍❤️‍💋‍👩🏿,GET,417 Expectation Failed,235.139.152.2,c31e:2fd:9e2e:1dc6:d3c1:19d5:95e:24b8,,202EAE6CB9BA,Ru46848e*M1WQD5,46972,http,https://amazing-morning.tokyo,\"Mozilla/5.0 (iPhone13,2; U; CPU iPhone OS 14_0 like Mac OS X) AppleWebKit/602.1.50 (KHTML, like Gecko) Version/10.0 Mobile/15E148 Safari/602.1\",corwin.theron",
            "aubreew,sneaky-cycle.blackfriday,.gives,forsaken-deer,rosaleek@formal-jump.ski,🤞🏼,POST,408 Request Timeout,101.4.20.69,6ba3:3cc7:e3ae:f0da:6e8b:6333:43e9:85b2,,CB8CB159A9DF,18>37H42$r25G\"9,45834,https,https://different-distinction.software,\"Mozilla/5.0 (Linux; Android 13; Pixel 6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Mobile Safari/537.36\",clairm",
            "dedric.schroeder,glorious-challenge.tienda,.lease,key-cassava,graham.angela@illustrious-t-shirt.solar,😝,DELETE,203 Non-Authoritative Information,187.183.68.8,33a2:a90e:f02a:15c8:4569:6286:9fd0:b340,,134F4845B02C,\"$lc0044xdEknG,d\",26213,http,https://trim-yeast.style,\"Mozilla/5.0 (iPhone; CPU iPhone OS 12_0 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.0 Mobile/15E148 Safari/604.1\",gerald.watsica",
            "elsef,lively-farmer.education,.lighting,regal-word,nehaa@hefty-mountain.video,#️⃣,PATCH,421 Misdirected Request,192.166.236.145,876d:c7fe:4996:3c84:cfcc:8ae5:402d:7e2,,E3B1DEE05177,BD8b88fSRa447%>,58661,https,https://quick-witted-meal.at,\"Mozilla/5.0 (Linux; Android 13; SM-S908B) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Mobile Safari/537.36\",katelinm"
        };

        var csvFaker = CsvUtils.ToCsvRows<ComputerAttributes>();

        Assert.That(csvFaker.Count, Is.EqualTo(expected.Length));

        Assert.Multiple(() =>
        {
            for (int i = 0; i < csvFaker.Count; i++)
            {
                Console.WriteLine(csvFaker[i]);
                Assert.That(csvFaker[i], Is.EqualTo(expected[i]));
            }
        });
    }
}

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
public class ComputerAttributes
{
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
