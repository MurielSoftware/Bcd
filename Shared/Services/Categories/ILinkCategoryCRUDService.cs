﻿using Shared.Core.Services;
using Shared.Dtos.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Services.Categories
{
    public interface ILinkCategoryCRUDService : ICRUDService<LinkCategoryDto>, IListReferenceService<CategoryFilterDto>, IPagedListAdministrationReaderService<LinkCategoryDto, CategoryFilterDto>
    {
    }
}
