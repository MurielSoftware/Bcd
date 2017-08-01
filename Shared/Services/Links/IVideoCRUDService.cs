using Shared.Core.Services;
using Shared.Dtos.Links;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Services.Links
{
    public interface IVideoCRUDService : ICRUDService<VideoDto>, IPagedListAdministrationReaderService<VideoDto, LinkFilterDto>
    {
    }
}
