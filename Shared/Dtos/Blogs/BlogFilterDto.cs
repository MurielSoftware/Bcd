using Shared.Core.Attributes;
using Shared.Core.Constants;
using Shared.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.Blogs
{
    public class BlogFilterDto : BaseFilterDto
    {
        [Filter(DaoConstants.ATTRIBUTE_NAME, CompareOperator.CONTAINS)]
        public virtual string Name { get; set; }
    }
}
