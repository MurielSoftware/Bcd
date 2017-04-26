using Shared.Core.Services;
using Shared.Dtos.Countries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Services.Countries
{
    public interface ICountryCRUDService : ICRUDService<CountryDto>, IReferenceService<CountryFilterDto>
    {
    }
}
