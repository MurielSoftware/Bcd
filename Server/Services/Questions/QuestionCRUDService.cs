using Server.Model;
using Shared.Dtos.Questions;
using Shared.Services.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using PagedList;
using Server.Daos;

namespace Server.Services.Questions
{
    public class QuestionCRUDService : GenericCRUDService<QuestionDto, Question>, IQuestionCRUDService
    {
        private QuestionDao _questionDao;

        public QuestionCRUDService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
            _questionDao = new QuestionDao(unitOfWork);
        }

        public IPagedList<QuestionDto> ReadAdministrationPaged(QuestionFilterDto questionFilterDto)
        {
            return _questionDao.FindPaged(questionFilterDto);
        }
    }
}
