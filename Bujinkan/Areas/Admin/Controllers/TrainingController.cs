using Client.Core.Controllers;
using Shared.Core.Constants;
using Shared.Core.Dtos;
using Shared.Core.Messages;
using Shared.Dtos.Trainings;
using Shared.Services.Trainings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bujinkan.Areas.Admin.Controllers
{
    public class TrainingController : CRUDController<TrainingDto, ITrainingCRUDService>
    {
        [HttpPost, ValidateInput(false)]
        public override ActionResult Create(TrainingDto trainingDto)
        {
            return base.DoCreate(trainingDto, Message.CreateSuccessMessage(MessageKeyConstants.OBJECT_SAVE_SUCCESS_MESSAGE), WebConstants.VIEW_CREATE, WebConstants.CONTROLLER_TRAINING);
        }

        public override ActionResult DeleteConfirmed(DialogDto dialogDto)
        {
            return base.DoDeleteConfirmed(dialogDto.Id, Message.CreateSuccessMessage(MessageKeyConstants.TRAINING_INFORMATION_DELETE_MESSAGE), WebConstants.VIEW_INDEX, WebConstants.CONTROLLER_TRAINING);
        }

        public ActionResult PagedList(TrainingFilterDto trainingFilterDto)
        {
            ViewBag.FilterDto = trainingFilterDto;
            return PartialView(WebConstants.VIEW_PAGED_LIST, GetService().ReadAdministrationPaged(trainingFilterDto));
        }
    }
}