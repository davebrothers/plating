using Nancy;

namespace Plating
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        public Bootstrapper()
        {
            Cassette.Nancy.CassetteNancyStartup.OptimizeOutput = true;
        }
    }
}