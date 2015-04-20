using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppmvcapi.Startup))]
namespace WebAppmvcapi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
