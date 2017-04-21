using Client.Core.Controllers;
using Shared.Core.Constants;
using Shared.Core.Dtos;
using Shared.Core.Messages;
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
            return base.DoCreate(userDto, Message.CreateSuccessMessage(MessageKeyConstants.OBJECT_SAVE_SUCCESS_MESSAGE), WebConstants.VIEW_CREATE, WebConstants.CONTROLLER_USER);
        }

        public override ActionResult DeleteConfirmed(DialogDto dialogDto)
        {
            return base.DoDeleteConfirmed(dialogDto.Id, Message.CreateSuccessMessage(MessageKeyConstants.USER_INFORMATION_DELETE_MESSAGE), WebConstants.VIEW_INDEX, WebConstants.CONTROLLER_USER);
        }

        public ActionResult PagedList(UserFilterDto userFilterDto)
        {
            ViewBag.FilterDto = userFilterDto;
            return PartialView(WebConstants.VIEW_PAGED_LIST, GetService().ReadAdministrationPaged(userFilterDto));
        }

        public JsonResult GetByPrefix(string prefix)
        {
            return Json(GetService().GetByPrefix(new UserFilterDto() { Surname = prefix }));
        }
    }
}