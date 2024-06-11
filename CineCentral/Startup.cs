using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CineCentral.Startup))]
namespace CineCentral
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
