using Faker.NET.EN.Names;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.NET.API
{
    public interface IFakerName
    {
        string FirstName { get; }

        string LastName { get; }

        string FullName { get; }

        string Suffix { get; }

        string Prefix { get; }

        string JobTitle { get; }

        string Email { get; }
    }
}
