﻿using Server.Model;
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
    public class SeminarCRUDService : BaseEventCRUDService<SeminarDto, Seminar>, ISeminarCRUDService
    {
        public SeminarCRUDService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }

        public IPagedList<SeminarDto> ReadAdministrationPaged(EventFilterDto eventFilterDto)
        {
            return _baseEventDao.FindPaged<SeminarDto, Seminar>(eventFilterDto);
        }
    }
}
