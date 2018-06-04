using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Consquisguiaworld.Startup))]
namespace Consquisguiaworld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
