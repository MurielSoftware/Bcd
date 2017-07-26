using Shared.Core.Attributes;
using Shared.I18n.Constants;
using System;

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
