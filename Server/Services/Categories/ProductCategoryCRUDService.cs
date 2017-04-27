using Server.Model;
using Shared.Dtos.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using Shared.Services.Categories;

namespace Server.Services.Categories
{
    public class ProductCategoryCRUDService : CategoryCRUDService<ProductCategoryDto, ProductCategory>, IProductCategoryCRUDService
    {
        public ProductCategoryCRUDService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }
    }
}
