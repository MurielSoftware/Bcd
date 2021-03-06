﻿using Server.Model;
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
using Shared.Dtos.Blogs;
using Shared.Dtos.Events;
using Shared.Dtos.Products;
using Shared.Core.Constants;
using Shared.Core.Exceptions;
using Shared.I18n.Constants;

namespace Server.Services
{
    public class MenuItemCRUDService : GenericCRUDService<MenuItemDto, MenuItem>, IMenuItemCRUDService
    {
        private MenuItemDao _menuItemDao;
        private OrderDao _orderDao;
        private UserDao _userDao;

        public MenuItemCRUDService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
            _menuItemDao = new MenuItemDao(unitOfWork);
            _orderDao = new OrderDao(unitOfWork);
            _userDao = new UserDao(unitOfWork);
        }

        public List<ReferenceDto> GetByPrefix(MenuItemEntityType entityType, string prefix)
        {
            switch (entityType)
            {
                case MenuItemEntityType.USER:
                    return _userDao.FindByPrefix(prefix, x => new ReferenceDto() { Id = x.Id, Label = x.FirstName + " " + x.Surname });
                case MenuItemEntityType.BLOG:
                    return _genericDao.FindByPrefix<Blog>(new BlogFilterDto() { Name = prefix }, x => new ReferenceDto() { Id = x.Id, Label = x.Name });
                case MenuItemEntityType.EVENT:
                    return _genericDao.FindByPrefix<Event>(new EventFilterDto() { Theme = prefix }, x => new ReferenceDto() { Id = x.Id, Label = x.Theme });
                case MenuItemEntityType.SEMINAR:
                    return _genericDao.FindByPrefix<Seminar>(new EventFilterDto() { Theme = prefix }, x => new ReferenceDto() { Id = x.Id, Label = x.Theme });
                case MenuItemEntityType.PRODUCT:
                    return _genericDao.FindByPrefix<Product>(new ProductFilterDto() { Name = prefix }, x => new ReferenceDto() { Id = x.Id, Label = x.Name });
            }
            return null;
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

        protected override void ValidationBeforePersist(MenuItemDto menuItemDto)
        {
            if (menuItemDto.ParentMenuItemId.HasValue)
            {
                MenuItem parentMenuItem = _genericDao.FindTracking<MenuItem>(menuItemDto.ParentMenuItemId.Value);
                if (MenuItemAssociationType.SECTION_MENU.Equals(menuItemDto.AssociationType) && parentMenuItem.Level != 0)
                {
                    throw new ValidationException(MessageKeyConstants.VALIDATION_SECTION_CAN_BE_PLACED_ONLY_UNDER_THE_MAIN_MENU_MESSAGE);
                }
                if (!MenuItemAssociationType.SECTION_MENU.Equals(menuItemDto.AssociationType) && parentMenuItem.Level == 0)
                {
                    throw new ValidationException(MessageKeyConstants.VALIDATION_UNDER_THE_MAIN_MENU_THE_SECTION_MUST_BE_PLACED_MESSAGE);
                }
            }
            else
            {
                if (MenuItemAssociationType.SECTION_MENU.Equals(menuItemDto.AssociationType))
                {
                    throw new ValidationException(MessageKeyConstants.VALIDATION_SECTION_CAN_BE_PLACED_ONLY_UNDER_THE_MAIN_MENU_MESSAGE);
                }
            }
            List<MenuItemDto> sectionMenuItemsDto = _menuItemDao.GetMenuItems(MenuItemAssociationType.SECTION_MENU, menuItemDto.ParentMenuItemId);
            if (sectionMenuItemsDto.Count == 4)
            {
                throw new ValidationException(MessageKeyConstants.VALIDATION_ONLY_FOUR_SECTIONS_CAN_BE_UNDER_MAIN_MENU_MESSAGE);
            }

            base.ValidationBeforePersist(menuItemDto);
        }

        protected override void DoDelete(MenuItem menuItem)
        {
            List<MenuItem> menuItemsToRemoved = DeleteAllIncludeChildren(menuItem);
            menuItemsToRemoved.ForEach(x => base.DoDelete(x));
        }

        private List<MenuItem> DeleteAllIncludeChildren(MenuItem parentMenuItem)
        {
            List<MenuItem> menuItemsToRemoved = new List<MenuItem>();
            if (parentMenuItem.SubMenuItems != null)
            {
                foreach (MenuItem menuItem in parentMenuItem.SubMenuItems)
                {
                    menuItemsToRemoved.AddRange(DeleteAllIncludeChildren(menuItem));
                }
            }
            menuItemsToRemoved.Add(parentMenuItem);
            return menuItemsToRemoved;
        }

        protected override MenuItem CreateEntity(MenuItemDto menuItemDto)
        {
            if (!EntityExists(menuItemDto))
            {
                menuItemDto.Order = _menuItemDao.FindMaxOrderValue(menuItemDto.ParentMenuItemId) + 1;
                if (menuItemDto.ParentMenuItemId.HasValue)
                {
                    menuItemDto.Level = _genericDao.FindTracking<MenuItem>(menuItemDto.ParentMenuItemId.Value).Level + 1;
                }
                else
                {
                    menuItemDto.Level = 0;
                }
            }
            menuItemDto.Url = GetLink(menuItemDto);
            menuItemDto.EntityType = GetEntityType(menuItemDto);
            menuItemDto.UserDefinableReference = GetUserDefinableReference(menuItemDto);
            menuItemDto.BlogCategoryId = GetBlogCategoryId(menuItemDto);
            return base.CreateEntity(menuItemDto);
        }

        private string GetLink(MenuItemDto menuItemDto)
        {
            switch (menuItemDto.AssociationType)
            {
                case MenuItemAssociationType.EMPTY_LINK:
                    return null;
                case MenuItemAssociationType.HOME:
                    return "/home";
                case MenuItemAssociationType.LINK:
                    return menuItemDto.Url;
                case MenuItemAssociationType.LINK_TO_LIST:
                    return GenerateLinkToList(menuItemDto.AssociationType, menuItemDto.EntityType, menuItemDto.BlogCategoryId);
                case MenuItemAssociationType.LINK_TO_SPECIFIC:
                    return GenerateLinkToSpecificLink(menuItemDto.EntityType, menuItemDto.UserDefinableReference);
            }
            return null;
        }

        private MenuItemEntityType GetEntityType(MenuItemDto menuItemDto)
        {
            switch (menuItemDto.AssociationType)
            {
                case MenuItemAssociationType.LINK_TO_LIST:
                case MenuItemAssociationType.LINK_TO_SPECIFIC:
                    return menuItemDto.EntityType;
            }
            return 0;
        }

        private string GenerateLinkToList(MenuItemAssociationType associationType, MenuItemEntityType menuEntityType, Guid? blogCategoryId)
        {
            if (MenuItemAssociationType.LINK_TO_LIST.Equals(associationType) && MenuItemEntityType.BLOG.Equals(menuEntityType))
            {
                return string.Format("/{0}/{1}?BlogCategoryId={2}", menuEntityType.ToString().ToLower(), WebConstants.VIEW_INDEX, blogCategoryId);
            }
            return string.Format("/{0}/{1}", menuEntityType.ToString().ToLower(), WebConstants.VIEW_INDEX);
        }

        private string GenerateLinkToSpecificLink(MenuItemEntityType menuEntityType, ReferenceString userDefinableReference)
        {
            return string.Format("/{0}/{1}/{2}", menuEntityType.ToString().ToLower(), WebConstants.VIEW_DETAILS, userDefinableReference.GetId());
        }

        private ReferenceString GetUserDefinableReference(MenuItemDto menuItemDto)
        {
            switch (menuItemDto.AssociationType)
            {
                case MenuItemAssociationType.LINK_TO_SPECIFIC:
                    return menuItemDto.UserDefinableReference;
            }
            menuItemDto.UserDefinableId = null;
            return null;
        }

        private Guid? GetBlogCategoryId(MenuItemDto menuItemDto)
        {
            if (MenuItemAssociationType.LINK_TO_LIST.Equals(menuItemDto.AssociationType) && MenuItemEntityType.BLOG.Equals(menuItemDto.EntityType))
            {
                return menuItemDto.BlogCategoryId;
            }
            return null;
        }
    }
}
