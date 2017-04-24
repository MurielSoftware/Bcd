using Server.Model;
using Shared.Core.Dtos.Roles;
using Shared.Services.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using Shared.Core.Dtos;
using Server.Daos;
using PagedList;

namespace Server.Services.Roles
{
    public class RoleCRUDService : GenericCRUDService<RoleDto, Role>, IRoleCRUDService
    {
        private RoleDao _roleDao;

        public RoleCRUDService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
            _roleDao = new RoleDao(unitOfWork);
        }

        public ListReferenceDto GetAllReferences(BaseFilterDto baseFilterDto)
        {
            return _roleDao.FindAllReferences(baseFilterDto);
        }

        public IPagedList<RoleDto> ReadAdministrationPaged(BaseFilterDto baseFilterDto)
        {
            return _roleDao.FindPaged(baseFilterDto);
        }
    }
}
