using Nancy;

namespace Plating
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        public Bootstrapper()
        {
            StaticConfiguration.DisableErrorTraces = false;
            Cassette.Nancy.CassetteNancyStartup.OptimizeOutput = true;
        }
    }
}