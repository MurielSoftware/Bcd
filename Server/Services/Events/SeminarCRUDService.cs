using Server.Model;
using Shared.Dtos.Events;
using Shared.Services.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using PagedList;
using Server.Daos;

namespace Server.Services.Events
{
    public class SeminarCRUDService : GenericCRUDService<SeminarDto, Seminar>, ISeminarCRUDService
    {
        private SeminarDao _seminarDao;

        public SeminarCRUDService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
            _seminarDao = new SeminarDao(unitOfWork);
        }

        public IPagedList<SeminarDto> ReadAdministrationPaged(EventFilterDto eventFilterDto)
        {
            return _seminarDao.FindPaged(eventFilterDto);
        }
    }
}
