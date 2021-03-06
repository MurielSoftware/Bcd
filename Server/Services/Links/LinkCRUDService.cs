﻿using Server.Model;
using Shared.Dtos.Links;
using Shared.Services.Links;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using PagedList;
using Server.Daos;

namespace Server.Services.Links
{
    public class LinkCRUDService : BaseLinkCRUDService<LinkDto, Link>, ILinkCRUDService
    {
        public LinkCRUDService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }

        public IPagedList<LinkDto> ReadAdministrationPaged(LinkFilterDto linkFilterDto)
        {
            return _baseLinkDao.FindPaged<LinkDto, Link>(linkFilterDto);
        }
    }
}
