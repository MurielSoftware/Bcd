using Server.Model;
using Shared.Dtos.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using Server.Daos;
using Shared.Core.Dtos;

namespace Server.Services.Categories
{
    public abstract class CategoryCRUDService<T, U> : GenericCRUDService<T, U>
        where T : CategoryDto
        where U : Category
    {
        protected CategoryDao _categoryDao;

        public CategoryCRUDService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
            _categoryDao = new CategoryDao(unitOfWork);
        }

        public ListReferenceDto GetAllReferences(CategoryFilterDto categoryFilterDto)
        {
            return _categoryDao.FindAllReferences<BlogCategory>(categoryFilterDto);
        }
    }
}
