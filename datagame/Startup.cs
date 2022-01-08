using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(datagame.Startup))]
namespace datagame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
