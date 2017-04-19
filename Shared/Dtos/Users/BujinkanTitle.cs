using Shared.Core.Attributes;
using Shared.Core.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.Users
{
    public enum BujinkanTitle
    {
        [Enum(MessageKeyConstants.LABEL_INSTRUCTOR)]
        INSTRUCTOR,

        [Enum(MessageKeyConstants.LABEL_SHIDOSHI)]
        SHIDOSHI,

        [Enum(MessageKeyConstants.LABEL_SHIHAN)]
        SHIHAN
    }
}
