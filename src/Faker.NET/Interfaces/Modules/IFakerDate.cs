namespace Faker.NET.Modules.Interfaces;

public interface IFakerDate
{
    public DateTime Anytime();

    public DateTime Between(DateTime? start = null, DateTime? end = null);

    public IEnumerable<DateTime> Betweens(int? count = 5, DateTime? start = null, DateTime? end = null);

    public DateTime Birthdate();

    public DateTime Future(DateTime? farthestDate = null);

    public string Month(bool abbreviated = false, bool useCurrentFakerCulture = true);

    public DateTime Past(DateTime? earliestDate = null);

    public DateTime Recent(int days = 5);

    public DateTime Soon(int days = 5);

    public TimeZoneInfo TimeZone();

    public string Weekday(bool abbreviated = false, bool useCurrentFakerCulture = true);
}
