using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using Shared.Dtos.Blogs;
using Server.Model;
using PagedList;

namespace Server.Daos
{
    public class BlogDao : BaseDao
    {
        public BlogDao(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }

        /// <summary>
        /// Finds paged blogs.
        /// </summary>
        /// <param name="blogFilterDto">The filtering DTO</param>
        /// <returns>The Blog DTO page</returns>
        internal IPagedList<BlogDto> FindPaged(BlogFilterDto blogFilterDto)
        {
            return _modelContext.Set<Blog>()
                .OrderBy(x => x.Name)
                .Select(x => new BlogDto() { Id = x.Id, CreatedDate = x.CreatedDate, Name = x.Name })
                .ToPagedList(blogFilterDto.Page, blogFilterDto.PageSize);
        }
    }
}
