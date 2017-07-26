using Client.Core.Controllers;
using Shared.Core.Constants;
using Shared.Core.Dtos;
using Shared.Dtos.Categories;
using Shared.Services.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bujinkan.Areas.Admin.Controllers
{
    public class LinkCategoryController : DialogCRUDController<LinkCategoryDto, ILinkCategoryCRUDService>
    {
        [HttpPost, ValidateInput(false)]
        public override ActionResult Create(LinkCategoryDto linkCategoryDto)
        {
            return DoCreate(linkCategoryDto, null, WebConstants.VIEW_PAGED_LIST, WebConstants.CONTROLLER_LINK_CATEGORY, null, HtmlConstants.PAGED_LIST_LINK_CATEGORY);
        }

        public override ActionResult DeleteConfirmed(DialogDto dialogDto)
        {
            return DoDeleteConfirmed(dialogDto.Id, null, WebConstants.VIEW_PAGED_LIST, WebConstants.CONTROLLER_LINK_CATEGORY, null, HtmlConstants.PAGED_LIST_LINK_CATEGORY);
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