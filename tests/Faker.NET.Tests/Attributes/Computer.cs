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
"johanj,ripe-boring.toys,.limited,shadowy-precious,zvolkman@uniform-burly.okinawa,🪝,DELETE,504 Gateway Timeout,139.99.188.167,d661:ab44:dc89:ed19:a4b1:77f9:32fd:b90f,,6B9D8C6F97E7,2aatY!E0>8jT8a&,9821,http,https://bustling-dull.lawyer,Mozilla/5.0 (Linux; Android 12; SM-G973F) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Mobile Safari/537.36",
"jschmeler,super-well-lit.gs,.asia,oddball-neat,ffarrell@quarterly-winding.dance,🪰,POST,226 IM Used (HTTP Delta encoding),70.229.54.14,5932:73cb:ead0:8340:92ac:c31e:2fd:9e2e,,35C05F8C1F20,x<T34Ru46848e*M,52442,http,https://limping-unhealthy.finance,Mozilla/5.0 (Linux; Android 13; SM-S908U) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/111.0.0.0 Mobile Safari/537.36",
"emorissette,incomplete-amazing.managment,.tokyo,aware-vague,corwin.katarina@broken-elderly.cooking,🎨,DELETE,428 Precondition Required,55.19.106.73,cde3:46b6:fd48:c19b:e80d:c924:e90f:23be,,142F65504ABB,,1D69#P4818>37H,65166,https,https://soft-elliptical.qpon,Mozilla/5.0 (iPhone; CPU iPhone OS 12_0 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.0 Mobile/15E148 Safari/604.1",
"cgoodwin,quarrelsome-lighthearted.dental,.lighting,avaricious-plump,dicki.philip@sure-footed-married.coach,📏,DELETE,415 Unsupported Media Type,217.62.236.67,7052:b385:e719:afec:da9b:f51b:faa:640d,,ED12B2BB40E6,Ca3lSWheYNH!s$l,3446,http,https://wise-celebrated.xyz,Mozilla/5.0 (iPhone14,6; U; CPU iPhone OS 15_4 like Mac OS X) AppleWebKit/602.1.50 (KHTML, like Gecko) Version/10.0 Mobile/19E241 Safari/602.1",
"wilmer.labadie,well-groomed-actual.claims,.family,decisive-affectionate,kirlin.hester@short-idolized.click,🥳,GET,502 Bad Gateway,253.216.31.97,2317:e8ea:a6fd:4e70:eca2:aef4:b368:40ae,,FB1080C59FD9,555m21h\"8732#80,22545,http,https://lavish-juicy.diet,Mozilla/5.0 (iPhone12,1; U; CPU iPhone OS 13_0 like Mac OS X) AppleWebKit/602.1.50 (KHTML, like Gecko) Version/10.0 Mobile/15E148 Safari/602.1" 
        };

        var csvFaker = CsvUtils.ToCsvRows<ComputerAttributes>().ToArray();
        Assert.That(csvFaker.ToArray(), Is.EquivalentTo(expected));
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
