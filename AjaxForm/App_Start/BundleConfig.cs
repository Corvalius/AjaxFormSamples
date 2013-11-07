using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace AjaxForm.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include
             (
                 "~/Scripts/jquery-{version}.js",
                 "~/Scripts/jquery.validate.*",
                 "~/Scripts/jquery.unobtrusive-ajax.js"
             ));
        }
    }
}