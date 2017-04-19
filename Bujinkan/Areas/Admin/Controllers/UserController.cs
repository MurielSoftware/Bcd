using Client.Core.Controllers;
using Shared.Core.Constants;
using Shared.Core.Dtos;
using Shared.Dtos.Users;
using Shared.Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bujinkan.Areas.Admin.Controllers
{
    public class UserController : CRUDController<UserDto, IUserCRUDService>
    {
        [HttpPost, ValidateInput(false)]
        public override ActionResult Create(UserDto userDto)
        {
            return base.DoCreate(userDto, null, WebConstants.VIEW_CREATE, WebConstants.CONTROLLER_USER);
        }

        public override ActionResult DeleteConfirmed(DialogDto dialogDto)
        {
            return base.DoDeleteConfirmed(dialogDto.Id, null, WebConstants.VIEW_INDEX, WebConstants.CONTROLLER_USER);
        }

        public ActionResult PagedList(UserFilterDto userFilterDto)
        {
            ViewBag.FilterDto = userFilterDto;
            return PartialView(WebConstants.VIEW_PAGED_LIST, GetService().ReadAdministrationPaged(userFilterDto));
        }
    }
}