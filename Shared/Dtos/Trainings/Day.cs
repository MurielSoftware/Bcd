using Shared.Core.Attributes;
using Shared.I18n.Constants;
using System;

namespace Shared.Dtos.Trainings
{
    public enum Day
    {
        [Enum(MessageKeyConstants.LABEL_MONDAY)]
        MONDAY,

        [Enum(MessageKeyConstants.LABEL_TUESDAY)]
        TUESDAY,

        [Enum(MessageKeyConstants.LABEL_WEDNESDAY)]
        WEDNESDAY,

        [Enum(MessageKeyConstants.LABEL_THURSDAY)]
        THURSDAY,

        [Enum(MessageKeyConstants.LABEL_FRIDAY)]
        FRIDAY,

        [Enum(MessageKeyConstants.LABEL_SATURDAY)]
        SATURDAY,

        [Enum(MessageKeyConstants.LABEL_SUNDAY)]
        SUNDAY,

        [Enum(MessageKeyConstants.LABEL_AGREEMENT)]
        AGREEMENT
    }
}
