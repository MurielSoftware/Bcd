using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Client.Core.Controllers
{
    public abstract class BaseController : Controller
    {
        /// <summary>
        /// Gets the index view.
        /// </summary>
        /// <returns>The index view</returns>
        public virtual ActionResult Index()
        {
            return View();
        }

        protected object SaveToTempAndView(string propertyName)
        {
            ViewData[propertyName] = TempData[propertyName];
            TempData[propertyName] = ViewData[propertyName];
            return ViewData[propertyName];
        }
    }
}
