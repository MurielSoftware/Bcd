using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using PagedList;
using Shared.Dtos.Questions;
using Server.Model;

namespace Server.Daos
{
    public class QuestionDao : BaseDao
    {
        public QuestionDao(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }

        /// <summary>
        /// Finds paged questions.
        /// </summary>
        /// <param name="questionFilterDto">The filtering DTO</param>
        /// <returns>The Question DTO page</returns>
        internal IPagedList<QuestionDto> FindPaged(QuestionFilterDto questionFilterDto)
        {
            return _modelContext.Set<Question>()
                .OrderBy(x => x.QuestionMark)
                .Select(x => new QuestionDto() { Id = x.Id, QuestionMark = x.QuestionMark, Answer = x.Answer })
                .ToPagedList(questionFilterDto.Page, questionFilterDto.PageSize);
        }
    }
}
