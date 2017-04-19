using Shared.Core.Services;
using Shared.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Services.Users
{
    public interface IUserCRUDService : ICRUDService<UserDto>, IPagedListAdministrationReaderService<UserDto, UserFilterDto>
    {
    }
}
