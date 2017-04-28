using Server.Model;
using Shared.Dtos.Categories;
using Shared.Core.Context;
using Shared.Services.Categories;
using Shared.Core.Dtos;
using System;
using PagedList;

namespace Server.Services.Categories
{
    public class BlogCategoryCRUDService : CategoryCRUDService<BlogCategoryDto, BlogCategory>, IBlogCategoryCRUDService
    {
        public BlogCategoryCRUDService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }

        public IPagedList<BlogCategoryDto> ReadAdministrationPaged(CategoryFilterDto categoryFilterDto)
        {
            return _categoryDao.FindPaged<BlogCategoryDto, BlogCategory>(categoryFilterDto);
        }
    }
}
