using Shared.Core.Services;
using Shared.Dtos.Questions;
using Shared.Services.Links;
using Shared.Services.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Services.Questions
{
    public interface IQuestionCRUDService : ICRUDService<QuestionDto>, IPagedListAdministrationReaderService<QuestionDto, QuestionFilterDto>
    {
    }
}
