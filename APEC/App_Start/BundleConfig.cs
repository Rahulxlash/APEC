using System.Web;
using System.Web.Optimization;

namespace APEC
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
            bundles.Add(new ScriptBundle("~/bundles/extScripts").Include(
                "~/Scripts/jquery-1.10.2.intellisense.js",
                "~/Scripts/jquery-migrate-1.2.1.min.js",
                "~/Scripts/jquery.appear.js",
                "~/Scripts/jquery.fitvids.js",
                "~/Scripts/jquery.lettering.js",
                "~/Scripts/jquery.migrate.js",
                "~/Scripts/jquery.nicescroll.min.js",
                "~/Scripts/jquery.parallax.js",
                "~/Scripts/jquery.slicknav.js",
                "~/Scripts/jquery.textillate.js",
                "~/Scripts/jquery.isotope.min.js",
                "~/Scripts/nivo-lightbox.min.js",
                "~/Scripts/owl.carousel.min.js",
                "~/Scripts/respond.js",
                "~/Scripts/count-to.js",
                "~/Scripts/script.js"
                ));



            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/animate.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/responsive.css",
                      "~/Content/slicknav.css",
                      "~/Content/style.css"));

            bundles.Add(new StyleBundle("~/Content/Admincss").Include(
                    "~/Content/bootstrap.css",
                    "~/Content/site.css"));
        }
    }
}
