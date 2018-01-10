using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KingPim.Startup))]
namespace KingPim
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
