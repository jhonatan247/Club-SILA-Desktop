using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Diseño_WEB.Startup))]
namespace Diseño_WEB
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
