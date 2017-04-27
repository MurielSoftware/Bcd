using Client.Core.Controllers;
using Shared.Core.Constants;
using Shared.Core.Dtos;
using Shared.Core.Messages;
using Shared.Dtos.Events;
using Shared.Dtos.Vocabularies;
using Shared.Services.Events;
using Shared.Services.Vocabularies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bujinkan.Areas.Admin.Controllers
{
    public class VocabularyController : DialogCRUDController<VocabularyDto, IVocabularyCRUDService>
    {
        [HttpPost, ValidateInput(false)]
        public override ActionResult Create(VocabularyDto vocabularyDto)
        {
            return base.DoCreate(vocabularyDto, Message.CreateSuccessMessage(MessageKeyConstants.OBJECT_SAVE_SUCCESS_MESSAGE), WebConstants.VIEW_CREATE, WebConstants.CONTROLLER_VOCABULARY);
        }

        public override ActionResult DeleteConfirmed(DialogDto dialogDto)
        {
            return base.DoDeleteConfirmed(dialogDto.Id, Message.CreateSuccessMessage(MessageKeyConstants.OBJECT_INFORMATION_DELETE_MESSAGE), WebConstants.VIEW_INDEX, WebConstants.CONTROLLER_VOCABULARY);
        }

        public ActionResult PagedList(VocabularyFilterDto vocabularyFilterDto)
        {
            ViewBag.FilterDto = vocabularyFilterDto;
            return PartialView(WebConstants.VIEW_PAGED_LIST, GetService().ReadAdministrationPaged(vocabularyFilterDto));
        }
    }
}