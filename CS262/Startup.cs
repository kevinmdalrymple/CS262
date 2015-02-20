using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CS262.Startup))]
namespace CS262
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
