using System.Web;
using System.Web.Optimization;

namespace Bujinkan
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/script-admin").Include(
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/ff-admin.js"));

            bundles.Add(new StyleBundle("~/Content/css-admin").Include(
                        "~/Content/bootstrap.min.css",
                        "~/Content/bootstrap-datepicker.min.css",
                        "~/Content/font-awesome.min.css",
                        "~/Content/ff/ff-ribbon.css",
                        "~/Content/ff/ff-admin.css"));
        }
    }
}
