using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CircleInnovation.API.Startup))]

namespace CircleInnovation.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
