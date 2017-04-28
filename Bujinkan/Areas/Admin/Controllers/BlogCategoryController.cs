using Client.Core.Controllers;
using Shared.Dtos.Categories;
using Shared.Services.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shared.Core.Dtos;
using Shared.Core.Constants;

namespace Bujinkan.Areas.Admin.Controllers
{
    public class BlogCategoryController : DialogCRUDController<BlogCategoryDto, IBlogCategoryCRUDService>
    {
        [HttpPost, ValidateInput(false)]
        public override ActionResult Create(BlogCategoryDto blogCategoryDto)
        {
            return DoCreate(blogCategoryDto, null, WebConstants.VIEW_PAGED_LIST, WebConstants.CONTROLLER_BLOG_CATEGORY, null, HtmlConstants.PAGED_LIST_BLOG_CATEGORY);
        }

        public override ActionResult DeleteConfirmed(DialogDto dialogDto)
        {
            return DoDeleteConfirmed(dialogDto.Id, null, WebConstants.VIEW_PAGED_LIST, WebConstants.CONTROLLER_BLOG_CATEGORY, null, HtmlConstants.PAGED_LIST_BLOG_CATEGORY);
        }

        public ActionResult PagedList(CategoryFilterDto categoryFilterDto)
        {
            ViewBag.FilterDto = categoryFilterDto;
            return PartialView(WebConstants.VIEW_PAGED_LIST, GetService().ReadAdministrationPaged(categoryFilterDto));
        }

        public ActionResult GetAllCategoryReferences(CategoryFilterDto categoryFilterDto)
        {
            return Json(GetService().GetAllReferences(categoryFilterDto).References.ToList());
        }
    }
}