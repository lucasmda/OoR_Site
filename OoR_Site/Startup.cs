using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OoR_Site.Startup))]
namespace OoR_Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
