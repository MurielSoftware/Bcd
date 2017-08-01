using Server.Daos;
using Server.Model;
using Shared.Dtos.Links;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;

namespace Server.Services.Links
{
    public class BaseLinkCRUDService<T, U> : GenericCRUDService<T, U> where T : BaseLinkDto where U : BaseLink
    {
        protected BaseLinkDao _baseLinkDao;

        public BaseLinkCRUDService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
            _baseLinkDao = new BaseLinkDao(unitOfWork);
        }
    }
}
