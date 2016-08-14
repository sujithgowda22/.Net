using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloCI.Web.Startup))]
namespace HelloCI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
