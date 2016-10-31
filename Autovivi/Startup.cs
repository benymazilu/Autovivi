using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Autovivi.Startup))]
namespace Autovivi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
