using Shared.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.Categories
{
    public class CategoryDto : UserDefinableDto
    {
        public virtual string Name { get; set; }
        public virtual bool BuiltIn { get; set; }
    }
}
