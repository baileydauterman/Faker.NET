using System;
using Faker.NET.Locales.FR.Names;

namespace Faker.NET.FR.Names
{
	public class Name
	{
		public static string FirstName => _firstName.Get();
		public static string LastName => _lastName.Get();
		public static string FullName => $"{FirstName} {LastName}";

		private static FirstName _firstName = new();
		private static LastName _lastName = new();
	}
}

