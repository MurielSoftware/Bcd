using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using Shared.Dtos.Vocabularies;
using PagedList;
using Server.Model;

namespace Server.Daos
{
    public class VocabularyDao : BaseDao
    {
        public VocabularyDao(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }

        /// <summary>
        /// Finds paged vocabularies.
        /// </summary>
        /// <param name="vocabularyFilterDto">The filtering DTO</param>
        /// <returns>The Vocabulary DTO page</returns>
        internal IPagedList<VocabularyDto> FindPaged(VocabularyFilterDto vocabularyFilterDto)
        {
            return _modelContext.Set<Vocabulary>()
                .OrderBy(x => x.Word)
                .Select(x => new VocabularyDto() { Id = x.Id, Word = x.Word, Translate = x.Translate })
                .ToPagedList(vocabularyFilterDto.Page, vocabularyFilterDto.PageSize);
        }
    }
}
