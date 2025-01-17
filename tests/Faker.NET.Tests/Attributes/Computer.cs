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
"johanj,ripe-boring.toys,.limited,shadowy-precious,zvolkman@uniform-burly.okinawa,🪝,DELETE,504 Gateway Timeout,139.99.188.167,d661:ab44:dc89:ed19:a4b1:77f9:32fd:b90f,,6B9D8C6F97E7,2aatY!E0>8jT8a&,9821,http,https://bustling-dull.lawyer,\"Mozilla/5.0 (Linux; Android 12; SM-G973F) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Mobile Safari/537.36\",jschmeler",
"rbarrows,neat-happy-go-lucky.am,.fish,enchanting-powerless,madelynnh@flimsy-easy.dentist,🔝,GET,300 Multiple Choices,214.73.235.20,d083:4092:acc3:1e02:fd9e:2e1d:c6d3:c119,,F8C1F202EAE6,67/#54;7?1rH9l3,44138,http,https://concerned-true.moe,\"Mozilla/5.0 (Linux; Android 13; SM-G991U) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Mobile Safari/537.36\",halle.tremblay",
"theron.turner,jagged-broken.consulting,.cooking,red-wasteful,blick.obie@forsaken-energetic.stream,👨‍🍳,POST,404 Not Found,243.73.124.209,c924:e90f:23be:d5eb:6ba3:3cc7:e3ae:f0da,,BB85A841CB8C,#P4818>37H42$r2,44880,https,https://lighthearted-first.lighting,\"Mozilla/5.0 (iPhone13,2; U; CPU iPhone OS 14_0 like Mac OS X) AppleWebKit/602.1.50 (KHTML, like Gecko) Version/10.0 Mobile/15E148 Safari/602.1\",letitia.rohan",
"devanted,right-scaly.media,.supplies,excited-vengeful,dach.dimitri@confused-unhealthy.lease,🐅,GET,413 Content Too Large,129.227.72.105,d0b:4fba:a3d3:a40f:7416:3033:a2a9:ef0,,0C6376B7E241,g2)Re4bByyy8\"0i,11298,http,https://intent-bare.la,\"Mozilla/5.0 (Linux; Android 12; 2201116SG) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Mobile Safari/537.36\",drake.cruickshank",
"greggz,colorful-ideal.us.com,.pet,huge-vivacious,aemmerich@excellent-stained.hosting,👨🏿‍🎤,PUT,422 Unprocessable Content (WebDAV),252.190.28.12,4e82:7d:b18:ac83:19f4:c658:ebd4:876d,,F3F105B0FEDD,32#80CLBD8b88fS,27620,https,https://buttery-ajar.reviews,\"Mozilla/5.0 (Linux; Android 13; Pixel 7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Mobile Safari/537.36\",ostanton",
        };

        var csvFaker = CsvUtils.ToCsvRows<ComputerAttributes>();

        Assert.That(csvFaker.Count, Is.EqualTo(expected.Length));

        Assert.Multiple(() =>
        {
            for (int i = 0; i < csvFaker.Count; i++)
            {
                Asserts.IsEqual(csvFaker[i], expected[i]);
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
