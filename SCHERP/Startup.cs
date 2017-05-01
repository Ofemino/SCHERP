using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SCHERP.Startup))]
namespace SCHERP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
