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
    public class EventController : CRUDController<EventDto, IEventCRUDService>
    {
        [HttpPost, ValidateInput(false)]
        public override ActionResult Create(EventDto eventDto)
        {
            return base.DoCreate(eventDto, Message.CreateSuccessMessage(MessageKeyConstants.OBJECT_SAVE_SUCCESS_MESSAGE), WebConstants.VIEW_CREATE, WebConstants.CONTROLLER_EVENT);
        }

        public override ActionResult DeleteConfirmed(DialogDto dialogDto)
        {
            return base.DoDeleteConfirmed(dialogDto.Id, Message.CreateSuccessMessage(MessageKeyConstants.SEMINAR_INFORMATION_DELETE_MESSAGE), WebConstants.VIEW_INDEX, WebConstants.CONTROLLER_EVENT);
        }

        public ActionResult PagedList(EventFilterDto eventFilterDto)
        {
            ViewBag.FilterDto = eventFilterDto;
            return PartialView(WebConstants.VIEW_PAGED_LIST, GetService().ReadAdministrationPaged(eventFilterDto));
        }
    }
}