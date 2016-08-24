using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(APEC.Startup))]
namespace APEC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
