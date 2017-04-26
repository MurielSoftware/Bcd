using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using Server.Model;
using Shared.Dtos.Links;
using PagedList;

namespace Server.Daos
{
    public class LinkDao : BaseDao
    {
        public LinkDao(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }

        /// <summary>
        /// Finds paged links.
        /// </summary>
        /// <param name="LinkFilterDto">The filtering DTO</param>
        /// <returns>The Link DTO page</returns>
        internal IPagedList<LinkDto> FindPaged(LinkFilterDto linkFilterDto)
        {
            return _modelContext.Set<Link>()
                .OrderBy(x => x.Name)
                .Select(x => new LinkDto() { Id = x.Id, Name = x.Name, Url = x.Url })
                .ToPagedList(linkFilterDto.Page, linkFilterDto.PageSize);
        }
    }
}
