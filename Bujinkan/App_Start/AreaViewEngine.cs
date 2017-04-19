using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bujinkan.App_Start
{
    public class AreaViewEngine : RazorViewEngine
    {
        public AreaViewEngine()
        {
            string[] viewLocations = new string[] {
                "~/Areas/Admin/Views/{1}/{0}.aspx",
                "~/Areas/Admin/Views/{1}/{0}.ascx",
                "~/Areas/Admin/Views/{1}/{0}.cshtml",
                "~/Areas/Admin/Views/Shared/{0}.aspx",
                "~/Areas/Admin/Views/Shared/{0}.ascx",
                "~/Areas/Admin/Views/Shared/{0}.cshtml"
            };

            this.PartialViewLocationFormats = viewLocations;
            this.ViewLocationFormats = viewLocations;
        }
    }
}