using System;
using System.IO;
using System.Web.Http;
using LogoFX.Practices.IoC.SimpleContainer;
using Ngcs.Practices.IoC;

namespace Ngcs.Server.Facade
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var iocContainer = new SimpleIocContainer();
            ServiceLocator.Current = iocContainer;

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
