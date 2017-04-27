using Client.Core.Controllers;
using Shared.Core.Constants;
using Shared.Core.Dtos;
using Shared.Core.Messages;
using Shared.Dtos.Events;
using Shared.Dtos.Links;
using Shared.Dtos.Vocabularies;
using Shared.Services.Events;
using Shared.Services.Links;
using Shared.Services.Vocabularies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bujinkan.Areas.Admin.Controllers
{
    public class LinkController : CRUDController<LinkDto, ILinkCRUDService>
    {
        [HttpPost, ValidateInput(false)]
        public override ActionResult Create(LinkDto linkDto)
        {
            return base.DoCreate(linkDto, Message.CreateSuccessMessage(MessageKeyConstants.OBJECT_SAVE_SUCCESS_MESSAGE), WebConstants.VIEW_CREATE, WebConstants.CONTROLLER_LINK);
        }

        public override ActionResult DeleteConfirmed(DialogDto dialogDto)
        {
            return base.DoDeleteConfirmed(dialogDto.Id, Message.CreateSuccessMessage(MessageKeyConstants.OBJECT_INFORMATION_DELETE_MESSAGE), WebConstants.VIEW_INDEX, WebConstants.CONTROLLER_LINK);
        }

        public ActionResult PagedList(LinkFilterDto linkFilterDto)
        {
            ViewBag.FilterDto = linkFilterDto;
            return PartialView(WebConstants.VIEW_PAGED_LIST, GetService().ReadAdministrationPaged(linkFilterDto));
        }
    }
}