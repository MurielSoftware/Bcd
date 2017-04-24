using Client.Core.Controllers;
using Shared.Core.Dtos.Roles;
using Shared.Services.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shared.Core.Dtos;
using Shared.Core.Constants;

namespace Bujinkan.Areas.Admin.Controllers
{
    public class RoleController : DialogCRUDController<RoleDto, IRoleCRUDService>
    {
        public override ActionResult Create(RoleDto dto)
        {
            throw new NotImplementedException();
        }

        public override ActionResult DeleteConfirmed(DialogDto dialogDto)
        {
            throw new NotImplementedException();
        }

        public ActionResult PagedList(BaseFilterDto baseFilterDto)
        {
            ViewBag.FilterDto = baseFilterDto;
            return PartialView(WebConstants.VIEW_PAGED_LIST, GetService().ReadAdministrationPaged(baseFilterDto));
        }

        public ActionResult GetAllRolesReferences(BaseFilterDto baseFilterDto)
        {
            return Json(GetService().GetAllReferences(baseFilterDto).References.ToList());
        }
    }
}