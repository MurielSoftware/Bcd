using Shared.Core.Attributes;
using Shared.Core.Constants;
using Shared.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.Events
{
    public class EventFilterDto : BaseFilterDto
    {
        [Filter(DaoConstants.ATTRIBUTE_THEME, CompareOperator.CONTAINS)]
        public virtual string Theme { get; set; }
    }
}
