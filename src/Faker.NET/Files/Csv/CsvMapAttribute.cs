using System.Reflection.Metadata;

namespace Faker.NET.Files.Csv
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CsvMapAttribute : Attribute
    {
        /// <summary>
        /// The value that will be displayed in the csv when it is created.
        /// Can be used as the value to get property if the name is the same
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// The class that you want to get the value from.
        /// </summary>
        public Type ClassType { get; set; }

        /// <summary>
        /// The name of the property where the class is coming from. 
        /// </summary>
        public string ClassProperty { get; set; }

        public object GetPropertyValue()
        {
            if (string.IsNullOrWhiteSpace(DisplayName) && string.IsNullOrWhiteSpace(ClassProperty))
            {
                throw new InvalidDataException($"{nameof(DisplayName)} or {nameof(ClassProperty)} must have a value to identify property name");
            }

            var prop = ClassType.GetProperty(ClassProperty ?? DisplayName);

            if (prop == null)
            {
                throw new Exception($"Unable to find property ({ClassProperty} or {DisplayName}) on give type: {ClassType}");
            }

            return prop.GetValue(null);
        }
    }
}
