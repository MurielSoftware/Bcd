using Shared.Core.Attributes;
using Shared.Core.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
