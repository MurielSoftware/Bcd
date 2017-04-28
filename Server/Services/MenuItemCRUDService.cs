using Server.Model;
using Shared.Core.Dtos.MenuItems;
using Shared.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using Shared.Core.Dtos;
using Server.Daos;

namespace Server.Services
{
    public class MenuItemCRUDService : GenericCRUDService<MenuItemDto, MenuItem>, IMenuItemCRUDService
    {
        private MenuItemDao _menuItemDao;
        private OrderDao _orderDao;

        public MenuItemCRUDService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
            _menuItemDao = new MenuItemDao(unitOfWork);
            _orderDao = new OrderDao(unitOfWork);
        }

        public List<ReferenceDto> GetByPrefix(MenuItemEntityType entityType, string prefix)
        {
            throw new NotImplementedException();
        }

        public List<MenuItemDto> GetMenuItems(Guid? parentMenuItemId)
        {
            List<MenuItemDto> menuItemDtos = _menuItemDao.GetMenuItems(parentMenuItemId);
            foreach (MenuItemDto menuItemDto in menuItemDtos)
            {
                if (MenuItemAssociationType.SECTION_MENU.Equals(menuItemDto.AssociationType))
                {
                    menuItemDto.SectionSubmenu = _menuItemDao.GetMenuItems(menuItemDto.Id);
                }
            }
            return menuItemDtos;
        }

        public Guid? GetParentId(Guid id)
        {
            return _menuItemDao.FindParentId(id);
        }

        public void TreeNodeChangePosition(Guid sourceId, Guid targetId)
        {
            _orderDao.ChangeOrder<MenuItem>(sourceId, targetId);
        }
    }
}
