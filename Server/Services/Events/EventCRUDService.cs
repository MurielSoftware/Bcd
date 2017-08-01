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
    public class EventCRUDService : BaseEventCRUDService<EventDto, Event>, IEventCRUDService
    {
        public EventCRUDService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }

        public IPagedList<EventDto> ReadAdministrationPaged(EventFilterDto eventFilterDto)
        {
            return _baseEventDao.FindPaged<EventDto, Event>(eventFilterDto);
        }
    }
}
