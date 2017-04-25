using Shared.Core.Services;
using Shared.Dtos.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Services.Events
{
    public interface ISeminarCRUDService : ICRUDService<SeminarDto>, IPagedListAdministrationReaderService<SeminarDto, EventFilterDto>
    {
    }
}
