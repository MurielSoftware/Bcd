using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using Shared.Dtos.Galleries;
using Server.Model;
using PagedList;

namespace Server.Daos
{
    public class GalleryDao : BaseDao
    {
        public GalleryDao(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }

        /// <summary>
        /// Finds paged galleries.
        /// </summary>
        /// <param name="galleryFilterDto">The filtering DTO</param>
        /// <returns>The Gallery DTO page</returns>
        internal IPagedList<GalleryDto> FindPaged(GalleryFilterDto galleryFilterDto)
        {
            return _modelContext.Set<Gallery>()
                .OrderBy(x => x.Name)
                .Select(x => new GalleryDto() { Id = x.Id, Name = x.Name })
                .ToPagedList(galleryFilterDto.Page, galleryFilterDto.PageSize);
        }
    }
}
