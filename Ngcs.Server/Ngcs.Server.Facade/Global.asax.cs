using System.Web;
using System.Web.Http;

#pragma warning disable 1591

namespace Ngcs.Server.Facade
{
	/// <inheritdoc />
	public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
	        GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
