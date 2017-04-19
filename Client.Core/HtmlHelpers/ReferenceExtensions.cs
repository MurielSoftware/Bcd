using Shared.Core.Constants;
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
using System.Web.Routing;

namespace Client.Core.HtmlHelpers
{
    public static class ReferenceExtensions
    {
        /// <summary>
        /// Creates the reference with the remote autocomplete.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="htmlHelper">The html helper</param>
        /// <param name="expression">The expression to the referenced object</param>
        /// <param name="name">The name of the referenced object</param>
        /// <param name="action">The action to load the data</param>
        /// <param name="maximum">The maximum elements to set</param>
        /// <returns>Returns the reference control</returns>
        public static MvcHtmlString ReferenceFor<T, U>(this HtmlHelper<T> htmlHelper, Expression<Func<T, U>> expression, string name, string action, int maximum)
        {
            ModelMetadata metadataId = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string referenceIconName = name + "reference";
            StringBuilder sb = new StringBuilder();
            sb.Append("<div class='ui-autocomplete-multiselect ui-state-default'>");
            sb.Append("<div class=\"input-group\">");
            sb.Append(InputExtensions.TextBox(htmlHelper, name, null, new { data_action = action, data_maximum_item = maximum, aria_describedby = referenceIconName }));
            sb.Append("<div class=\"input-group-addon\"><i class=\"fa fa-ellipsis-h\"></i></div>");
            sb.Append(InputExtensions.HiddenFor(htmlHelper, expression));
            sb.Append("</div></div>");
            return MvcHtmlString.Create(sb.ToString());
        }

        /// <summary>
        /// The label for the referenced object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="htmlHelper">The html helper</param>
        /// <param name="expression">The expression</param>
        /// <param name="action">The name of the action to run after the click</param>
        /// <param name="controller">The name of the controller to run after the click</param>
        /// <param name="htmlAttributes">The html attributes</param>
        /// <returns>The label for the referenced object</returns>
        public static MvcHtmlString ReferenceLabelFor<T, U>(this HtmlHelper<T> htmlHelper, Expression<Func<T, U>> expression, string action = null, string controller = null, object htmlAttributes = null)
        {
            ModelMetadata metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            if (metadata.Model == null || !(metadata.Model is ReferenceString))
            {
                return CreateTexts(htmlHelper, SharedConstants.EMPTY_STRING, htmlAttributes);
               // return ExtensionsUtil.CreateLabel(metadata.PropertyName, SharedConstants.EMPTY_STRING, htmlAttributes);
            }

            //Dictionary<Guid, string> referencies = (metadata.Model as ReferenceString).GetReferencies();

            if (action == null && controller == null)
            {
                return MvcHtmlString.Create(CreateTexts<T>(htmlHelper, (metadata.Model as ReferenceString).GetValues(), htmlAttributes));
            }
            return MvcHtmlString.Create(CreateLinks<T>(htmlHelper, metadata.Model as ReferenceString, action, controller, htmlAttributes));
        }

        /// <summary>
        /// Creates only labels of the references.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="htmlHelper">The html helper</param>
        /// <param name="metadata">The metadata of the current property</param>
        /// <param name="referencies">The referencies contained IDs and labels</param>
        /// <param name="htmlAttributes">The html attributres</param>
        /// <returns>Returns the created texts</returns>
        public static string CreateTexts<T>(this HtmlHelper<T> htmlHelper, string text, object htmlAttributes)
        {
            TagBuilder tagBuilder = new TagBuilder("div");
            tagBuilder.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
            tagBuilder.InnerHtml = text;
            return tagBuilder.ToString();
            
          //  return ExtensionsUtil.CreateLabel(propertyName, referenceString.GetValues(), htmlAttributes).ToString();
        }

        /// <summary>
        /// Creates the links of the references.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="htmlHelper">The html helper</param>
        /// <param name="referencies">The referencies contained IDs and labels</param>
        /// <param name="action">The action name</param>
        /// <param name="controller">The controller name</param>
        /// <param name="htmlAttributes">The html attributes</param>
        /// <returns>Returns the created links of the references</returns>
        public static string CreateLinks<T>(this HtmlHelper<T> htmlHelper, ReferenceString referenceString, string action, string controller, object htmlAttributes)
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<Guid, string> reference in referenceString.GetReferencies())
            {
                sb.Append(LinkExtensions.ActionLink(htmlHelper, reference.Value, action, controller, new { id = reference.Key, name = UrlUtils.ToSeoUrl(reference.Value) }, htmlAttributes).ToString());
            }
            return sb.ToString();
        }
    }
}
