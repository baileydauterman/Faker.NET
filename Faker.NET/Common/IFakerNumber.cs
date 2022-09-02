using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.NET.Common
{
    public interface IFakerNumber
    {
        public string Get();

        public string Format { get; set; }
    }
}
