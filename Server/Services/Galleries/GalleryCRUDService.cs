using Server.Model;
using Shared.Dtos.Galleries;
using Shared.Services.Galleries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using PagedList;
using Server.Daos;

namespace Server.Services.Galleries
{
    public class GalleryCRUDService : GenericCRUDService<GalleryDto, Gallery>, IGalleryCRUDService
    {
        private GalleryDao _galleryDao;

        public GalleryCRUDService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
            _galleryDao = new GalleryDao(unitOfWork);
        }

        public IPagedList<GalleryDto> ReadAdministrationPaged(GalleryFilterDto galleryFilterDto)
        {
            return _galleryDao.FindPaged(galleryFilterDto);
        }
    }
}
