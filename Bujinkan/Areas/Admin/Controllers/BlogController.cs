using Client.Core.Controllers;
using Shared.Core.Constants;
using Shared.Core.Dtos;
using Shared.Core.Messages;
using Shared.Dtos.Blogs;
using Shared.I18n.Constants;
using Shared.Services.Blogs;
using System.Web.Mvc;

namespace Bujinkan.Areas.Admin.Controllers
{
    public class BlogController : CRUDController<BlogDto, IBlogCRUDService>
    {
        [HttpPost, ValidateInput(false)]
        public override ActionResult Create(BlogDto blogDto)
        {
            return base.DoCreate(blogDto, Message.CreateSuccessMessage(MessageKeyConstants.OBJECT_SAVE_SUCCESS_MESSAGE), WebConstants.VIEW_CREATE, WebConstants.CONTROLLER_BLOG);
        }

        public override ActionResult DeleteConfirmed(DialogDto dialogDto)
        {
            return base.DoDeleteConfirmed(dialogDto.Id, Message.CreateSuccessMessage(MessageKeyConstants.OBJECT_INFORMATION_DELETE_MESSAGE), WebConstants.VIEW_INDEX, WebConstants.CONTROLLER_BLOG);
        }

        public ActionResult PagedList(BlogFilterDto blogFilterDto)
        {
            ViewBag.FilterDto = blogFilterDto;
            return PartialView(WebConstants.VIEW_PAGED_LIST, GetService().ReadAdministrationPaged(blogFilterDto));
        }
    }
}