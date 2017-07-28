using Client.Core.Controllers;
using Shared.Dtos.Countries;
using Shared.Services.Countries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bujinkan.Areas.Admin.Controllers
{
    public class CountryController : ServiceController<ICountryCRUDService>
    {
        public JsonResult GetByPrefix(string prefix)
        {
            return Json(GetService().GetByPrefix(new CountryFilterDto() { Name = prefix }));
        }
    }
}