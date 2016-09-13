using System.Web.Optimization;

namespace StarterMvc.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/bootbox.js",
                        "~/Scripts/respond.js",
                        "~/Scripts/DataTables/jquery.dataTables.js",
                        "~/Scripts/DataTables/dataTables.bootstrap.js",
                        "~/Scripts/DataTables/dataTables.buttons.min.js",
                        "~/Scripts/DataTables/buttons.print.min.js",
                        "~/Scripts/DataTables/buttons.colVis.min.js",
                        "~/Scripts/DataTables/buttons.bootstrap.min.js",
                        "~/Scripts/jszip.min.js",
                        "~/Scripts/DataTables/buttons.html5.min.js",
                        "~/Scripts/pdfmake/pdfmake.min.js",
                        "~/Scripts/pdfmake/vfs_fonts.js",

                        "~/Scripts/AdminLTE/app.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/DataTables/css/dataTables.bootstrap.css",
                      "~/Content/DataTables/css/buttons.bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
