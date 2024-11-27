namespace Faker.NET.Interfaces
{
    public interface IFakerCustom
    {
        string[] Data { get; set; }

        /// <summary>
        /// Use <see cref="Faker.NET.Extensions.RandomizerExtensions"/> to get random data from values
        /// </summary>
        /// <returns></returns>
        string GetValue();
    }
}
