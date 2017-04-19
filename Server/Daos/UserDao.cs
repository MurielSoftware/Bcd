using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using Shared.Dtos.Users;
using PagedList;
using Server.Model;

namespace Server.Daos
{
    internal class UserDao : BaseDao
    {
        internal UserDao(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }

        internal IPagedList<UserDto> FindPaged(UserFilterDto userFilterDto)
        {
            return _modelContext.Set<User>()
                .Select(x => new UserDto() { Id = x.Id, BujinkanTitle = x.BujinkanTitle, FirstName = x.FirstName, Surname = x.Surname })
                .ToPagedList(userFilterDto.Page, userFilterDto.PageSize);
        }
    }
}
