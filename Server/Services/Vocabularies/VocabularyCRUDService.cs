using Server.Model;
using Shared.Dtos.Vocabularies;
using Shared.Services.Vocabularies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using PagedList;
using Server.Daos;

namespace Server.Services.Vocabularies
{
    public class VocabularyCRUDService : GenericCRUDService<VocabularyDto, Vocabulary>, IVocabularyCRUDService
    {
        private VocabularyDao _vocabularyDao;

        public VocabularyCRUDService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
            _vocabularyDao = new VocabularyDao(unitOfWork);
        }

        public IPagedList<VocabularyDto> ReadAdministrationPaged(VocabularyFilterDto vocabularyFilterDto)
        {
            return _vocabularyDao.FindPaged(vocabularyFilterDto);
        }
    }
}
