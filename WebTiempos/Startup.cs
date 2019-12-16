using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTiempos.Startup))]
namespace WebTiempos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
