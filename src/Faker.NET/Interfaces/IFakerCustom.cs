namespace Faker.NET.Interfaces
{
    public interface IFakerCustom
    {
        string[] Data { get; set; }

        /// <summary>
        /// Use <see cref="global::Faker.NET.Common.RandomizerExtensions"/> to get random data from values
        /// </summary>
        /// <returns></returns>
        string GetValue();
    }
}
