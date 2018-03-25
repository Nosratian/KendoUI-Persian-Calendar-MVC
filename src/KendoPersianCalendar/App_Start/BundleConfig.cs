using System.Web;
using System.Web.Optimization;

namespace KendoPersianCalendar
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            // Script (Kendo UI)
            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                "~/Scripts/kendoPersianCalendar/JalaliDate.js",
                "~/Scripts/kendoPersianCalendar/kendo.web.js",
                "~/Scripts/kendoPersianCalendar/fa-IR.js",
                "~/Scripts/kendoPersianCalendar/changeCulture.js",
                "~/Scripts/kendoPersianCalendar/kendo.calendar.js",
                "~/Scripts/kendoPersianCalendar/kendo.datepicker.js"));

            // CSS style (bootstrap)
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/bootstrap-rtl.min.css"));

            // CSS style (custom css)
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/box-sizing-fixes.css",
                "~/Content/Site.css"));

            bundles.IgnoreList.Clear();

        }
    }
}
