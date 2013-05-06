using Cassette;
using Cassette.Scripts;
using Cassette.Stylesheets;

namespace BootstrapMVC
{
    /// <summary>
    /// Configures the Cassette asset bundles for the web application.
    /// </summary>
    public class CassetteBundleConfiguration : IConfiguration<BundleCollection>
    {
        public void Configure(BundleCollection bundles)
        {


            var scripts = new[]
                              {
                                  "~/Scripts/lib/jquery-2.0.0.js",
                                  "~/Scripts/lib/bootstrap.js",
                                  "~/Scripts/admin.js",
                              };

            var head = new[]
                              {
                                  "~/Scripts/lib/lodash.custom.js",
                                  "~/Scripts/lib/modernizr.custom.js",
                                  "~/Scripts/head.js",
                              };

            bundles.Add<ScriptBundle>("head", head);
            bundles.Add<ScriptBundle>("main", scripts);

            bundles.Add<StylesheetBundle>("~/Styles");

            bundles.Add<ScriptBundle>("debug-mode", "~/Scripts/debug-mode.js");
        }
    }
}