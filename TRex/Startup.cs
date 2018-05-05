using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TRex.Startup))]
namespace TRex
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
