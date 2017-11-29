using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OhmCode.Startup))]
namespace OhmCode
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
