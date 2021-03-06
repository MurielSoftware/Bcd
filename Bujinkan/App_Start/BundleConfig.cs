﻿using System.Web;
using System.Web.Optimization;

namespace Bujinkan
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/script-admin").Include(
                        "~/Scripts/jquery-3.2.1.min.js",
                        "~/Scripts/jquery.mask.min.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/bootstrap-datepicker.min.js",
                        "~/Scripts/ff/ff-inlineeditable.js",
                        "~/Scripts/ff/ff-remotecontent.js",
                        "~/Scripts/ff/ff-reference.js",
                        "~/Scripts/ff/ff-referencelist.js",
                        "~/Scripts/ff/ff-richtextbox.js",
                        "~/Scripts/ff/ff-dialog.js",
                        "~/Scripts/ff/ff-tree.js",
                        "~/Scripts/ff/ff-admin.js"));

            bundles.Add(new StyleBundle("~/Content/css-admin").Include(
                        "~/Content/bootstrap.min.css",
                        "~/Content/bootstrap-datepicker.min.css",
                        "~/Content/font-awesome.min.css",
                        "~/Content/ff/ff-richtextbox.css",
                        "~/Content/ff/ff-ribbon.css",
                        "~/Content/ff/ff-reference.css",
                        "~/Content/ff/ff-tree.css",
                        "~/Content/ff/ff-admin.css"));
        }
    }
}
