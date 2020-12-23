﻿using System.Web.Optimization;
using DLibrary.WebUI;

namespace BookStore.WebUI.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-3.4.1.js", "~/Scripts/jquery.unobtrusive-ajax.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate.js", "~/Scripts/jquery.validate.unobtrusive.js"));
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-2.8.3.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css"));
            var lessBundleBranding = new StyleBundle("~/Content/Themes/less").Include
            (
                "~/Content/Themes/variables.less",
                "~/Content/Themes/custom.less"
                );
            lessBundleBranding.Transforms.Add(new LessTransform());
            lessBundleBranding.Transforms.Add(new CssMinify());
            bundles.Add(lessBundleBranding);
        }
    }
}