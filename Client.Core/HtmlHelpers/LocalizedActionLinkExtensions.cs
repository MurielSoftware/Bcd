using Shared.Core.Dtos;
using Shared.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Client.Core.HtmlHelpers
{
    public static class LocalizedActionLinkExtensions
    {
        public static MvcHtmlString LocalizedActionLinkFor<T, U>(this HtmlHelper<T> htmlHelper, Expression<Func<T, U>> expression, string action = "#", string controller = "", object routeValues = null, object htmlAttributes = null)
        {
            ModelMetadata expressionModelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            if (expressionModelMetadata.Model == null)
            {
                return null;
            }
            string resourceKey = expressionModelMetadata.Model.ToString();
            if (expressionModelMetadata.Model is ReferenceString)
            {
                resourceKey = (expressionModelMetadata.Model as ReferenceString).GetValue();
            }
            return LocalizedActionLink(htmlHelper, resourceKey, action, controller, routeValues, htmlAttributes);
        }

        public static MvcHtmlString LocalizedActionLink<T>(this HtmlHelper<T> htmlHelper, string resourceKey, string action = "#", string controller = "", object routeValues = null, object htmlAttributes = null)
        {
            string tempName = Guid.NewGuid().ToString();
            if (routeValues == null && action != "Index")
            {
                action += "/";
            }
            string actionLinkMvcHtmlString = LinkExtensions.ActionLink(htmlHelper, tempName, action, controller, routeValues, htmlAttributes).ToHtmlString();
            actionLinkMvcHtmlString = actionLinkMvcHtmlString.Replace(tempName, ResourceUtils.GetString(resourceKey));
            return MvcHtmlString.Create(actionLinkMvcHtmlString);
        }
    }
}
