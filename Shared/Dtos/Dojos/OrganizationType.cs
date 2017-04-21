using Shared.Core.Attributes;
using Shared.Core.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.Dojos
{
    public enum OrganizationType
    {
        [Enum(MessageKeyConstants.LABEL_EMPTY)]
        NONE,

        [Enum(MessageKeyConstants.LABEL_ASSOCIATION)]
        ASSOCIATION
    }
}
