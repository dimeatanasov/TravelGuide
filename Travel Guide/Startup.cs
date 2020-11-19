using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Travel_Guide.Startup))]
namespace Travel_Guide
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
