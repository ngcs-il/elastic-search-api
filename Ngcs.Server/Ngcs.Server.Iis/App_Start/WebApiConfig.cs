using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using LogoFX.Practices.IoC.SimpleContainer;
using Solid.Practices.IoC;

namespace Ngcs.Server.Iis
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var iocContainer = new SimpleIocContainer();
            ServiceLocator.Current = iocContainer;
            IHttpConfigurationProvider bootstrapper = new AppBootstrapper(iocContainer, config);

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
