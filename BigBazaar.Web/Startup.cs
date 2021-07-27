using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigBazaar.Web.Startup))]
namespace BigBazaar.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
