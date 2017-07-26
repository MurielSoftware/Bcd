using Client.Core.Controllers;
using Shared.Core.Constants;
using Shared.Core.Dtos;
using Shared.Core.Messages;
using Shared.Dtos.Events;
using Shared.I18n.Constants;
using Shared.Services.Events;
using System.Web.Mvc;

namespace Bujinkan.Areas.Admin.Controllers
{
    public class SeminarController : CRUDController<SeminarDto, ISeminarCRUDService>
    {
        [HttpPost, ValidateInput(false)]
        public override ActionResult Create(SeminarDto seminarDto)
        {
            return base.DoCreate(seminarDto, Message.CreateSuccessMessage(MessageKeyConstants.OBJECT_SAVE_SUCCESS_MESSAGE), WebConstants.VIEW_CREATE, WebConstants.CONTROLLER_SEMINAR);
        }

        public override ActionResult DeleteConfirmed(DialogDto dialogDto)
        {
            return base.DoDeleteConfirmed(dialogDto.Id, Message.CreateSuccessMessage(MessageKeyConstants.SEMINAR_INFORMATION_DELETE_MESSAGE), WebConstants.VIEW_INDEX, WebConstants.CONTROLLER_SEMINAR);
        }

        public ActionResult PagedList(EventFilterDto eventFilterDto)
        {
            ViewBag.FilterDto = eventFilterDto;
            return PartialView(WebConstants.VIEW_PAGED_LIST, GetService().ReadAdministrationPaged(eventFilterDto));
        }
    }
}