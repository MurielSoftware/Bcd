using Shared.Core.Services;
using Shared.Dtos.Dojos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Services.Dojos
{
    public interface IDojoCRUDService : ICRUDService<DojoDto>, IPagedListAdministrationReaderService<DojoDto, DojoFilterDto>, IReferenceService<DojoFilterDto>
    {
    }
}
