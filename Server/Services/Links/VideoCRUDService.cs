using Server.Model;
using Shared.Dtos.Links;
using Shared.Services.Links;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using PagedList;

namespace Server.Services.Links
{
    public class VideoCRUDService : BaseLinkCRUDService<VideoDto, Video>, IVideoCRUDService
    {
        public VideoCRUDService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }

        public IPagedList<VideoDto> ReadAdministrationPaged(LinkFilterDto linkFilterDto)
        {
            return _baseLinkDao.FindPaged<VideoDto, Video>(linkFilterDto);
        }
    }
}
