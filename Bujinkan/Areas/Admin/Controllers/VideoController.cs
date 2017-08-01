using Client.Core.Controllers;
using Shared.Core.Constants;
using Shared.Core.Dtos;
using Shared.Core.Messages;
using Shared.Dtos.Links;
using Shared.I18n.Constants;
using Shared.Services.Links;
using System.Web.Mvc;

namespace Bujinkan.Areas.Admin.Controllers
{
    public class VideoController : DialogCRUDController<VideoDto, IVideoCRUDService>
    {
        [HttpPost, ValidateInput(false)]
        public override ActionResult Create(VideoDto videoDto)
        {
            return base.DoCreate(videoDto, Message.CreateSuccessMessage(MessageKeyConstants.OBJECT_SAVE_SUCCESS_MESSAGE), WebConstants.VIEW_CREATE, WebConstants.CONTROLLER_VIDEO);
        }

        public override ActionResult DeleteConfirmed(DialogDto dialogDto)
        {
            return base.DoDeleteConfirmed(dialogDto.Id, Message.CreateSuccessMessage(MessageKeyConstants.OBJECT_INFORMATION_DELETE_MESSAGE), WebConstants.VIEW_INDEX, WebConstants.CONTROLLER_VIDEO);
        }

        public ActionResult PagedList(LinkFilterDto linkFilterDto)
        {
            ViewBag.FilterDto = linkFilterDto;
            return PartialView(WebConstants.VIEW_PAGED_LIST, GetService().ReadAdministrationPaged(linkFilterDto));
        }
    }
}