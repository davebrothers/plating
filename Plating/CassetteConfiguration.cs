using Cassette;
using Cassette.Scripts;
using Cassette.Stylesheets;

namespace Plating
{
    /// <summary>
    /// Configures the Cassette asset bundles for the web application.
    /// </summary>
    public class CassetteBundleConfiguration : IConfiguration<BundleCollection>
    {
        public void Configure(BundleCollection bundles)
        {
            var scriptsFiles = new[]
            {
                "Content/Scripts/jquery-1.9.1.min.js",
                "Content/Scripts/bootstrap.min.js"
            };

            var stylesFileSearch = new FileSearch
            {
                Pattern = "*.min.css"
            };

            bundles.Add<ScriptBundle>("Scripts", scriptsFiles);
            bundles.AddPerSubDirectory<StylesheetBundle>(applicationRelativePath: "Content", fileSearch: stylesFileSearch);
        }
    }
}