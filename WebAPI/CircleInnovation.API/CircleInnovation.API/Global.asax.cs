using CircleInnovation.API.App_Start;
using System.Web.Http;

namespace CircleInnovation.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutomapperConfig.Configure();
        }
    }
}
