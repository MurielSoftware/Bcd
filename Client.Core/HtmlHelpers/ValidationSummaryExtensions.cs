using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Client.Core.HtmlHelpers
{
    public static class ValidationSummaryExtensions
    {
        /// <summary>
        /// Gets the Validation summary for the current model.
        /// </summary>
        /// <param name="htmlHelper">The HtmlHelper</param>
        /// <returns>The Validation summary</returns>
        public static MvcHtmlString CustomValidationSummary(this HtmlHelper htmlHelper)
        {
            if (htmlHelper.ViewData.ModelState.IsValid)
            {
                return null;
            }
            TagBuilder tagBuilder = new TagBuilder("div");
            tagBuilder.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(new { @class = "alert alert-danger", role = "alert"}));
            tagBuilder.InnerHtml = "<span><i class='fa fa-warning'></i></span> <strong>Chyba</strong><br />Došlo k těmto chybám:" + ValidationExtensions.ValidationSummary(htmlHelper).ToString();
            return MvcHtmlString.Create(tagBuilder.ToString());
        }
    }
}
