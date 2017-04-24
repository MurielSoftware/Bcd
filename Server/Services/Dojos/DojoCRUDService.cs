using Server.Model;
using Shared.Core.Dtos;
using Shared.Dtos.Dojos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using Shared.Services.Dojos;
using PagedList;

namespace Server.Services.Dojos
{
    public class DojoCRUDService : GenericCRUDService<DojoDto, Dojo>, IDojoCRUDService
    {
        public DojoCRUDService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }

        public List<ReferenceDto> GetByPrefix(DojoFilterDto baseFilterDto)
        {
            return _genericDao.FindByPrefix<Dojo>(new DojoFilterDto() { Name = baseFilterDto.Name }, x => new ReferenceDto() { Id = x.Id, Label = x.Name });
        }

        public IPagedList<DojoDto> ReadAdministrationPaged(DojoFilterDto baseFilterDto)
        {
            throw new NotImplementedException();
        }
    }
}
