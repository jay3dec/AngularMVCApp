using System.Web;
using System.Web.Optimization;

namespace AngularMVCApp
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.IgnoreList.Clear();

            bundles.Add(new StyleBundle("~/bundles/bootstrap").Include(
                        "~/Style/bootstrap.min.css",
                        "~/Style/jumbotron-narrow.css"));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                        "~/Scripts/angular.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                        "~/Scripts/app.js"));

          
        }
    }
}