using Shared.Core.Attributes;
using Shared.I18n.Constants;
using System;

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
