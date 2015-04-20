using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFileLibrary.Startup))]
namespace WebFileLibrary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
