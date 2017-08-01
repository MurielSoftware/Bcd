using Server.Model;
using Shared.Dtos.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using Server.Daos;
using Shared.Core.Utils;
using PagedList;

namespace Server.Services.Events
{
    public abstract class BaseEventCRUDService<T, U> : GenericCRUDService<T, U> where T : BaseEventDto where U : BaseEvent
    {
        protected BaseEventDao _baseEventDao;

        public BaseEventCRUDService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
            _baseEventDao = new BaseEventDao(unitOfWork);
        }

        protected override U CreateEntity(T baseEventDto)
        {
            U seminar = base.CreateEntity(baseEventDto);
            DateTime timeStart = StringUtils.ParseTime(baseEventDto.TimeStart);
            DateTime timeEnd = StringUtils.ParseTime(baseEventDto.TimeEnd);
            seminar.Start = timeStart;
            seminar.End = timeEnd;
            return seminar;
        }

        protected override T CreateDto(U baseEvent)
        {
            T baseEventDto = base.CreateDto(baseEvent);
            baseEventDto.TimeStart = StringUtils.ParseTime(baseEventDto.Start);
            baseEventDto.TimeEnd = StringUtils.ParseTime(baseEventDto.End);
            return baseEventDto;
        }
    }
}
