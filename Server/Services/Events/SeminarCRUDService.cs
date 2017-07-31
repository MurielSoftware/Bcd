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
using Shared.Core.Utils;

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

        protected override Seminar CreateEntity(SeminarDto seminarDto)
        {
            Seminar seminar = base.CreateEntity(seminarDto);
            DateTime timeStart = StringUtils.ParseTime(seminarDto.TimeStart);
            DateTime timeEnd = StringUtils.ParseTime(seminarDto.TimeEnd);
            seminar.Start = timeStart;
            seminar.End = timeEnd;
            return seminar;
        }

        protected override SeminarDto CreateDto(Seminar seminar)
        {
            SeminarDto seminarDto = base.CreateDto(seminar);
            seminarDto.TimeStart = StringUtils.ParseTime(seminarDto.Start);
            seminarDto.TimeEnd = StringUtils.ParseTime(seminarDto.End);
            return seminarDto;
        }
    }
}
