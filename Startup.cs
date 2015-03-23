using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPWebApp.Startup))]
namespace ASPWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
