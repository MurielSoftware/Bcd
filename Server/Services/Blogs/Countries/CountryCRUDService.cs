using Server.Model;
using Shared.Dtos.Countries;
using Shared.Services.Countries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using Shared.Core.Dtos;

namespace Server.Services.Countries
{
    public class CountryCRUDService : GenericCRUDService<CountryDto, Country>, ICountryCRUDService
    {
        public CountryCRUDService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }

        public List<ReferenceDto> GetByPrefix(CountryFilterDto countryFilterDto)
        {
            return _genericDao.FindByPrefix<Country>(countryFilterDto, x => new ReferenceDto() { Id = x.Id, Label = x.Name });
        }
    }
}
