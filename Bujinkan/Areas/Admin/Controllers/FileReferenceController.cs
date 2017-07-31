using Client.Core.Controllers;
using Client.Core.HtmlHelpers;
using Shared.Core.Constants;
using Shared.Core.Dtos;
using Shared.Core.Exceptions;
using Shared.Core.Json;
using Shared.Core.Services;
using Shared.Dtos.Resources;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bujinkan.Areas.Admin.Controllers
{
    public class FileReferenceController : ServiceController<IUploadFileService>
    {
        public ActionResult FileReferenceDialog(Guid id)
        {
            return PartialView("FileReferenceDialog", new DialogDto() { Id = id });
        }

        /// <summary>
        /// The action responsible for uploading the file.
        /// </summary>
        /// <param name="dialogDto">The DTO of the dialog</param>
        /// <param name="file">The uploaded file</param>
        /// <returns>The appropriate view</returns>
        [HttpPost]
        public virtual ActionResult FileReferenceConfirmed(DialogDto dialogDto, HttpPostedFileBase file)
        {
            // TODO change the implementation
            string fileName = null;
            Stream stream = null;
            if (file != null)
            {
                fileName = file.FileName;
                stream = file.InputStream;
            }
            try
            {
                GetUnitOfWork().StartTransaction();
                PhotoResourceDto photoResourceDto = null;// (PhotoResourceDto)GetService().UploadFile(dialogDto.Id, typeof(T), fileName, stream);
                GetUnitOfWork().EndTransaction();
                return Json(new JsonFileSelectDialogResult(true, photoResourceDto.GetRelativeThumbnailFile(), photoResourceDto.GetRelativeFilePath(), JsonRefreshMode.IMAGE_TO_RICHTEXTBOX));
            }
            catch (ValidationException ex)
            {
                return Json(new JsonDialogResult(false, HtmlConstants.DIALOG_VALIDATION_SUMMARY, ValidationSummaryExtensions.CustomValidationSummary(ex.Message).ToString()));
            }
        }
    }
}