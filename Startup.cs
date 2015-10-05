using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TTT.Startup))]
namespace TTT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
