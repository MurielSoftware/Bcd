using Shared.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.Countries
{
    public class CountryFilterDto : BaseFilterDto
    {
        public virtual string Name { get; set; }
    }
}
