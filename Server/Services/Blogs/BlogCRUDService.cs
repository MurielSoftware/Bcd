using Server.Model;
using Shared.Dtos.Blogs;
using Shared.Services.Blogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using PagedList;
using Server.Daos;

namespace Server.Services.Blogs
{
    public class BlogCRUDService : GenericCRUDService<BlogDto, Blog>, IBlogCRUDService
    {
        private BlogDao _blogDao;

        public BlogCRUDService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
            _blogDao = new BlogDao(unitOfWork);
        }

        public IPagedList<BlogDto> ReadAdministrationPaged(BlogFilterDto blogFilterDto)
        {
            return _blogDao.FindPaged(blogFilterDto);
        }
    }
}
