using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using LogoFX.Practices.IoC.SimpleContainer;
using Solid.Practices.Composition.Web;
using Solid.Practices.IoC;

namespace Ngcs.Server.Facade
{
    public static class WebApiConfig
    {
        private static void StartRuntime(IIocContainer iocContainer)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            string path = Path.Combine(directoryInfo.FullName, @"bin");
            var initializationFacade = new BootstrapperInitializationFacade(iocContainer);
            initializationFacade.Initialize(path);
            
            //code smell
            //_assembliesResolver = initializationFacade.AssembliesResolver as IAssembliesResolver;
            //_typeResolver = new HttpControllerTypeResolver();
            //_controllerActivator = new HttpControllerActivator();
            //RegisterServices();
            //Configure();
            //RegisterControllers(_typeResolver.GetControllerTypes(_assembliesResolver));
        }

        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var iocContainer = new SimpleIocContainer();
            ServiceLocator.Current = iocContainer;
            StartRuntime(iocContainer);

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
