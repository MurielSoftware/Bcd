using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using Shared.Dtos.Products;
using Server.Model;
using PagedList;

namespace Server.Daos
{
    public class ProductDao : BaseDao
    {
        public ProductDao(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }

        /// <summary>
        /// Finds paged products.
        /// </summary>
        /// <param name="productFilterDto">The filtering DTO</param>
        /// <returns>The Product DTO page</returns>
        internal IPagedList<ProductDto> FindPaged(ProductFilterDto productFilterDto)
        {
            return _modelContext.Set<Product>()
                .OrderBy(x => x.Name)
                .Select(x => new ProductDto() { Id = x.Id, Name = x.Name, Prize = x.Prize })
                .ToPagedList(productFilterDto.Page, productFilterDto.PageSize);
        }
    }
}
