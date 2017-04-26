using Server.Model;
using Shared.Dtos.Products;
using Shared.Services.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using PagedList;
using Server.Daos;

namespace Server.Services.Products
{
    public class ProductCRUDService : GenericCRUDService<ProductDto, Product>, IProductCRUDService
    {
        private ProductDao _productDao;

        public ProductCRUDService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
            _productDao = new ProductDao(unitOfWork);
        }

        public IPagedList<ProductDto> ReadAdministrationPaged(ProductFilterDto productFilterDto)
        {
            return _productDao.FindPaged(productFilterDto);
        }
    }
}
