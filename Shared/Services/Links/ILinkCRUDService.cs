using Shared.Core.Services;
using Shared.Dtos.Links;
using Shared.Services.Links;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Services.Links
{
    public interface ILinkCRUDService : ICRUDService<LinkDto>, IPagedListAdministrationReaderService<LinkDto, LinkFilterDto>
    {
    }
}
