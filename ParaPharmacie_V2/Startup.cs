using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DefaultV.Startup))]
namespace DefaultV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
