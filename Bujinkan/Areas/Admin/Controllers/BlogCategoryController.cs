using Client.Core.Controllers;
using Shared.Dtos.Categories;
using Shared.Services.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shared.Core.Dtos;

namespace Bujinkan.Areas.Admin.Controllers
{
    public class BlogCategoryController : DialogCRUDController<BlogCategoryDto, IBlogCategoryCRUDService>
    {
        public override ActionResult Create(BlogCategoryDto dto)
        {
            throw new NotImplementedException();
        }

        public override ActionResult DeleteConfirmed(DialogDto dialogDto)
        {
            throw new NotImplementedException();
        }
    }
}