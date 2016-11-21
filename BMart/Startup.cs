using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BMart.Startup))]
namespace BMart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
