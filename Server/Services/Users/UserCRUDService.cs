using Server.Model;
using Shared.Dtos.Users;
using Shared.Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using PagedList;
using Server.Daos;

namespace Server.Services.Users
{
    public class UserCRUDService : UserDefinableCRUDService<UserDto, User>, IUserCRUDService
    {
        private UserDao _userDao;

        public UserCRUDService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
            _userDao = new UserDao(unitOfWork);
        }

        public IPagedList<UserDto> ReadAdministrationPaged(UserFilterDto userFilterDto)
        {
            return _userDao.FindPaged(userFilterDto);
        }
    }
}
