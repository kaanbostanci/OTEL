using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OTEL.Startup))]
namespace OTEL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
