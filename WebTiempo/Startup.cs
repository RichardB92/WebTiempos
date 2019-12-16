using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTiempo.Startup))]
namespace WebTiempo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
