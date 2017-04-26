using Shared.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.Countries
{
    public class CountryDto : BaseDto
    {
        public virtual string Name { get; set; }
        public virtual string Path { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
