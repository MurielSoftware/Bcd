using Client.Core.Controllers;
using Shared.Core.Dtos.MenuItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shared.Core.Dtos;
using Shared.Core.Constants;
using Shared.Core.Services;

namespace Bujinkan.Areas.Admin.Controllers
{
    public class MenuItemController : DialogTreeCRUDController<MenuItemDto, IMenuItemCRUDService>
    {
        [HttpPost, ValidateInput(false)]
        public override ActionResult Create(MenuItemDto menuItemDto)
        {
            return DoCreate(menuItemDto, null, WebConstants.VIEW_LIST, WebConstants.CONTROLLER_MENU_ITEM, null, HtmlConstants.TREE_MENU_ITEM);
        }

        public override ActionResult DeleteConfirmed(DialogDto dialogDto)
        {
            return DoDeleteConfirmed(dialogDto.Id, null, WebConstants.VIEW_LIST, WebConstants.CONTROLLER_MENU_ITEM, null, HtmlConstants.TREE_MENU_ITEM);
        }

        public ActionResult List(BaseFilterDto baseFilterDto)
        {
            return PartialView(GetService().GetMenuItems(null));
        }

        public ActionResult ExpandTreeItem(Guid parentId)
        {
            return PartialView(WebConstants.VIEW_LIST, GetService().GetMenuItems(parentId));
        }
    }
}