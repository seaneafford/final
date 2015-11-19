using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GuildWebSite.Startup))]
namespace GuildWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
