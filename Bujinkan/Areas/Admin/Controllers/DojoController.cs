using Client.Core.Controllers;
using Shared.Dtos.Dojos;
using Shared.Services.Dojos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shared.Core.Dtos;
using Shared.Core.Messages;
using Shared.Core.Constants;

namespace Bujinkan.Areas.Admin.Controllers
{
    public class DojoController : CRUDController<DojoDto, IDojoCRUDService>
    {
        [HttpPost, ValidateInput(false)]
        public override ActionResult Create(DojoDto dojoDto)
        {
            return base.DoCreate(dojoDto, Message.CreateSuccessMessage(MessageKeyConstants.OBJECT_SAVE_SUCCESS_MESSAGE), WebConstants.VIEW_CREATE, WebConstants.CONTROLLER_DOJO);
        }

        public override ActionResult DeleteConfirmed(DialogDto dialogDto)
        {
            return base.DoDeleteConfirmed(dialogDto.Id, Message.CreateSuccessMessage(MessageKeyConstants.DOJO_INFORMATION_DELETE_MESSAGE), WebConstants.VIEW_INDEX, WebConstants.CONTROLLER_DOJO);
        }

        public JsonResult GetByPrefix(string prefix)
        {
            return Json(GetService().GetByPrefix(new DojoFilterDto() { Name = prefix }));
        }
    }
}