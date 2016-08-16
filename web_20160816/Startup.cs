using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(web_20160816.Startup))]
namespace web_20160816
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
