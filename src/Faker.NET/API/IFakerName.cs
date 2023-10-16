namespace Faker.NET.API
{
    /// <summary>
    /// Interface for generating random name data
    /// </summary>
    public interface IFakerName
    {
        /// <summary>
        /// Generate a random first name
        /// </summary>
        string First { get; }

        /// <summary>
        /// Generate a random last name
        /// </summary>
        string Last { get; }

        /// <summary>
        /// Generate a random full name
        /// </summary>
        string Full { get; }

        /// <summary>
        /// Generate a random suffix
        /// </summary>
        string Suffix { get; }

        /// <summary>
        /// Generate a random prefix
        /// </summary>
        string Prefix { get; }

        /// <summary>
        /// Generate a random job
        /// </summary>
        string Job { get; }

        /// <summary>
        /// Generate a random email
        /// </summary>
        string Email { get; }
    }
}
