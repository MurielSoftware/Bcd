using Server.Model;
using Shared.Dtos.Categories;
using Shared.Services.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using PagedList;

namespace Server.Services.Categories
{
    public class LinkCategoryCRUDService : CategoryCRUDService<LinkCategoryDto, LinkCategory>, ILinkCategoryCRUDService
    {
        public LinkCategoryCRUDService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }

        public IPagedList<LinkCategoryDto> ReadAdministrationPaged(CategoryFilterDto categoryFilterDto)
        {
            return _categoryDao.FindPaged<LinkCategoryDto, LinkCategory>(categoryFilterDto);
        }
    }
}
