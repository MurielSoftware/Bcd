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
    public class ProductCategoryController : DialogCRUDController<ProductCategoryDto, IProductCategoryCRUDService>
    {
        [HttpPost, ValidateInput(false)]
        public override ActionResult Create(ProductCategoryDto productCategoryDto)
        {
            return DoCreate(productCategoryDto, null, WebConstants.VIEW_PAGED_LIST, WebConstants.CONTROLLER_PRODUCT_CATEGORY, null, HtmlConstants.PAGED_LIST_PRODUCT_CATEGORY);
        }

        public override ActionResult DeleteConfirmed(DialogDto dialogDto)
        {
            return DoDeleteConfirmed(dialogDto.Id, null, WebConstants.VIEW_PAGED_LIST, WebConstants.CONTROLLER_PRODUCT_CATEGORY, null, HtmlConstants.PAGED_LIST_PRODUCT_CATEGORY);
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