using Shared.Core.Attributes;
using Shared.Core.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Core.Dtos.MenuItems
{
    public enum MenuItemEntityType
    {
        [Enum(DaoConstants.ENTITY_BLOG)]
        BLOG,

        [Enum(DaoConstants.ENTITY_EVENT)]
        EVENT,

        [Enum(DaoConstants.ENTITY_PRODUCT)]
        PRODUCT,

        [Enum(DaoConstants.ENTITY_SEMINAR)]
        SEMINAR,

        [Enum(DaoConstants.ENTITY_TEACHER)]
        USER
    }
}
