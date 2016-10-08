using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(socialsounds.Startup))]
namespace socialsounds
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
