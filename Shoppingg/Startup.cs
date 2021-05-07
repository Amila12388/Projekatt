using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shoppingg.Startup))]
namespace Shoppingg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
