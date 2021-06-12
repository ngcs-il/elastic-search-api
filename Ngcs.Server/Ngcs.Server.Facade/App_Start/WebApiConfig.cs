using System.Web.Http;
using LogoFX.Practices.IoC.SimpleContainer;
using Ngcs.Practices.IoC;

#pragma warning disable 1591

namespace Ngcs.Server.Facade
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var iocContainer = new SimpleIocContainer();
            ServiceLocator.Current = iocContainer;

            // ReSharper disable once ObjectCreationAsStatement
            new AppBootstrapper(iocContainer);
        }
    }
}
