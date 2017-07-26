using Shared.Core.Attributes;
using Shared.I18n.Constants;
using System;

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
