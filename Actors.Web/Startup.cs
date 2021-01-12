using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Actors.Web.Startup))]
namespace Actors.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
