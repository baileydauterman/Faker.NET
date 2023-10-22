using System;
namespace Faker.NET.API
{
	public interface IFileFaker<TOutput>
	{
		TOutput Generate<T>();
	}
}

