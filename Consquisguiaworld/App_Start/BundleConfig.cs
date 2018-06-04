using System.Web;
using System.Web.Optimization;

namespace Consquisguiaworld
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //site assets
            bundles.Add(new ScriptBundle("~/bundles/site/jquerymigrate").Include("~/Scripts/site/jquery-migrate-3.0.0.min.js"));            
            bundles.Add(new ScriptBundle("~/bundles/site/sitescripts").Include("~/Scripts/site/jquery.flexisel.js", "~/Scripts/site/move-top.js", "~/Scripts/site/easing.js"));
            bundles.Add(new StyleBundle("~/Content/site/contactcss").Include("~/Content/site/css/contact.css"));

            bundles.Add(new StyleBundle("~/Content/site/sitestyles").Include("~/Content/site/css/style.css", "~/Content/site/css/fontawesome-all.css"));

            //desoslide
            bundles.Add(new ScriptBundle("~/Scripts/site/desoslide").Include("~/Scripts/site/jquery.desoslide.js"));
            bundles.Add(new StyleBundle("~/bundles/site/desoslide").Include("~/Content/site/css/jquery.desoslide.css"));
        }
    }
}
