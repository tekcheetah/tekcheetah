using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tekcheetah.Startup))]
namespace Tekcheetah
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
