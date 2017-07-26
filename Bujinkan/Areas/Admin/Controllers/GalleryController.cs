using Client.Core.Controllers;
using Shared.Core.Constants;
using Shared.Core.Dtos;
using Shared.Core.Messages;
using Shared.Dtos.Galleries;
using Shared.I18n.Constants;
using Shared.Services.Galleries;
using System.Web.Mvc;

namespace Bujinkan.Areas.Admin.Controllers
{
    public class GalleryController : CRUDController<GalleryDto, IGalleryCRUDService>
    {
        [HttpPost, ValidateInput(false)]
        public override ActionResult Create(GalleryDto galleryDto)
        {
            return base.DoCreate(galleryDto, Message.CreateSuccessMessage(MessageKeyConstants.OBJECT_SAVE_SUCCESS_MESSAGE), WebConstants.VIEW_CREATE, WebConstants.CONTROLLER_GALLERY);
        }

        public override ActionResult DeleteConfirmed(DialogDto dialogDto)
        {
            return base.DoDeleteConfirmed(dialogDto.Id, Message.CreateSuccessMessage(MessageKeyConstants.GALLERY_INFORMATION_DELETE_MESSAGE), WebConstants.VIEW_INDEX, WebConstants.CONTROLLER_GALLERY);
        }

        public ActionResult PagedList(GalleryFilterDto galleryFilterDto)
        {
            ViewBag.FilterDto = galleryFilterDto;
            return PartialView(WebConstants.VIEW_PAGED_LIST, GetService().ReadAdministrationPaged(galleryFilterDto));
        }
    }
}