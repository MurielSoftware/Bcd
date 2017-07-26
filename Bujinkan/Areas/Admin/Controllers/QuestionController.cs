using Client.Core.Controllers;
using Shared.Core.Constants;
using Shared.Core.Dtos;
using Shared.Core.Messages;
using Shared.Dtos.Questions;
using Shared.I18n.Constants;
using Shared.Services.Questions;
using System.Web.Mvc;

namespace Bujinkan.Areas.Admin.Controllers
{
    public class QuestionController : DialogCRUDController<QuestionDto, IQuestionCRUDService>
    {
        [HttpPost, ValidateInput(false)]
        public override ActionResult Create(QuestionDto questionDto)
        {
            return base.DoCreate(questionDto, Message.CreateSuccessMessage(MessageKeyConstants.OBJECT_SAVE_SUCCESS_MESSAGE), WebConstants.VIEW_CREATE, WebConstants.CONTROLLER_QUESTION);
        }

        public override ActionResult DeleteConfirmed(DialogDto dialogDto)
        {
            return base.DoDeleteConfirmed(dialogDto.Id, Message.CreateSuccessMessage(MessageKeyConstants.OBJECT_INFORMATION_DELETE_MESSAGE), WebConstants.VIEW_INDEX, WebConstants.CONTROLLER_QUESTION);
        }

        public ActionResult PagedList(QuestionFilterDto questionFilterDto)
        {
            ViewBag.FilterDto = questionFilterDto;
            return PartialView(WebConstants.VIEW_PAGED_LIST, GetService().ReadAdministrationPaged(questionFilterDto));
        }
    }
}