using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dare.Startup))]
namespace Dare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
