using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;//Install-Package Microsoft.AspNet.Web.Optimization

namespace MVC_BTR.App_Start
{
    public class Bundelconfig
    {
        public static void RegisterBundles(BundleCollection Bundels)
        {
            Bundels.Add(new ScriptBundle("~/bundles/JQuery")
                   .Include("~/Scripts/jquery-2.1.4.js",
                   "~/Scripts/chosen.jquery.js",
                   "~/Scripts/jquery-ui.1.10.4.min.js"));

            Bundels.Add(new ScriptBundle("~/bundles/JQueryValidate")
                   .Include("~/Scripts/jquery.validate.unobtrusive.js",
                        "~/Scripts/jquery.validate.js"));

            Bundels.Add(new ScriptBundle("~/bundles/LoginCss")
                   .Include("~/Contents/CSS/Style.css"));

            Bundels.Add(new ScriptBundle("~/Contents/CSS/styles").Include(
                                              "~/Contents/CSS/styles.css",
                                              "~/Contents/CSS/Loader.css",
                                       "~/Contents/CSS/jqueryuiLight.css",
                                        "~/Contents/CSS/font-awesome.css",
                                            "~/Contents/CSS/chosen.css"));

            //BundleTable.EnableOptimizations = false;
        }
    }
}