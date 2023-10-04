using System;
using System.Runtime.InteropServices;
using Faker.NET.Locales.EN.Data;

namespace Faker.NET.Tests.Locales.EN
{
    public class BinaryTest
	{
		[Test]
		public void temp()
		{
			// Considering binary serialization of data sets. Seeing how efficient this may be compared
			// to keeping it in memory.
			var tempFile = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());

			using (var stream = File.OpenWrite(tempFile))
			using (var binWriter = new BinaryWriter(stream))
			{
				foreach (var name in NameData.FirstNames)
				{
					binWriter.Write(name);
				}
			}

			var stringS = new List<string>();
			using (var stream = File.OpenRead(tempFile))
			using (var binReader = new BinaryReader(stream))
			{
				while (binReader.BaseStream.Position < binReader.BaseStream.Length)
				{
					stringS.Add(binReader.ReadString());
				}
			}

			File.Delete(tempFile);
		}
	}
}

