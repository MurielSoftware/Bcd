using Server.Model;
using Shared.Dtos.Users;
using Shared.Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;

namespace Server.Services.Users
{
    public class UserCRUDService : UserDefinableCRUDService<UserDto, User>, IUserCRUDService
    {
        public UserCRUDService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }
    }
}
