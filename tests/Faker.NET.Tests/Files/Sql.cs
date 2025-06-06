﻿using Faker.NET.Files.Sql;
using System.Data;

namespace Faker.NET.Tests.Files
{
    internal class Sql
    {
        [Test]
        public void GenerateInsert()
        {
            var tempPath = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());
            using var writeStream = File.OpenWrite(tempPath);

            var faker = new SqlFaker(writeStream)
            {
                DbName = "users"
            };

            faker.SetTable("user_logins")
                 .AddTableColumn("guid", SqlDbType.UniqueIdentifier, GenerateGuid)
                 .AddTableColumn("username", SqlDbType.Text, GetUserName)
                 .AddTableColumn("password", SqlDbType.Text, GetPassword)
                 .AddTableColumn("userAgent", SqlDbType.Text, GetUserAgent)
                 .Iterations(1000)
                 .Write();

            File.Delete(tempPath);
        }

        private string GenerateGuid()
        {
            return Guid.NewGuid().ToString("N");
        }

        private string GetUserName()
        {
            return Faker.Internet.Username();
        }

        private string GetPassword()
        {
            return "no";
        }

        private string GetUserAgent()
        {
            return Faker.Internet.UserAgent();
        }
    }
}
