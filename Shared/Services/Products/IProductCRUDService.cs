using Shared.Core.Services;
using Shared.Dtos.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Services.Products
{
    public interface IProductCRUDService : ICRUDService<ProductDto>, IPagedListAdministrationReaderService<ProductDto, ProductFilterDto>
    {
    }
}
