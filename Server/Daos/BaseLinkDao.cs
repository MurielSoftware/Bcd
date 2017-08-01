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
    public class BaseLinkDao : BaseDao
    {
        public BaseLinkDao(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }

        /// <summary>
        /// Finds paged links.
        /// </summary>
        /// <param name="LinkFilterDto">The filtering DTO</param>
        /// <returns>The Link DTO page</returns>
        internal IPagedList<T> FindPaged<T, U>(LinkFilterDto linkFilterDto) where T : BaseLinkDto, new() where U : BaseLink
        {
            return _modelContext.Set<U>()
                .OrderBy(x => x.Name)
                .Select(x => new T() { Id = x.Id, Name = x.Name, Url = x.Url })
                .ToPagedList(linkFilterDto.Page, linkFilterDto.PageSize);
        }
    }
}
