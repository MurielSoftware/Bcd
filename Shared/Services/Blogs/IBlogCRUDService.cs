using Shared.Core.Services;
using Shared.Dtos.Blogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Services.Blogs
{
    public interface IBlogCRUDService : ICRUDService<BlogDto>, IPagedListAdministrationReaderService<BlogDto, BlogFilterDto>
    {
    }
}
