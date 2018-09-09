using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PTC.Web.Startup))]
namespace PTC.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
