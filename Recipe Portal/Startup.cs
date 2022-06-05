using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Recipe_Portal.Startup))]
namespace Recipe_Portal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
