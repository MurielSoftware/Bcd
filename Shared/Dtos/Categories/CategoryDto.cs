using Shared.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.Categories
{
    public abstract class CategoryDto : BaseDto
    {
        public virtual string Name { get; set; }
        public virtual bool BuiltIn { get; set; }
    }
}
