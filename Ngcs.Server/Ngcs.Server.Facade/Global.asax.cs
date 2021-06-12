using System.Web;
using System.Web.Http;

namespace Ngcs.Server.Facade
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
	        GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
