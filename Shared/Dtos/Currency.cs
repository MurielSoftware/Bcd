using Shared.Core.Attributes;
using Shared.Core.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos
{
    public enum Currency
    {
        [Enum(MessageKeyConstants.LABEL_CZK)]
        CZK,

        [Enum(MessageKeyConstants.LABEL_EURO)]
        EURO,

        [Enum(MessageKeyConstants.LABEL_USD)]
        USD,

        [Enum(MessageKeyConstants.LABEL_JPY)]
        JPY
    }
}
