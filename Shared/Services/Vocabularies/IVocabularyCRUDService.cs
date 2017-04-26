using Shared.Core.Services;
using Shared.Dtos.Vocabularies;
using Shared.Services.Links;
using Shared.Services.Vocabularies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Services.Vocabularies
{
    public interface IVocabularyCRUDService : ICRUDService<VocabularyDto>, IPagedListAdministrationReaderService<VocabularyDto, VocabularyFilterDto>
    {
    }
}
