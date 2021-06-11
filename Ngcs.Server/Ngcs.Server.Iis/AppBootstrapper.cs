using System.Web.Http;
using LogoFX.Web.Core;
using Solid.Practices.IoC;

namespace Ngcs.Server.Iis
{
    public class AppBootstrapper : IisBootstrapper
    {
        public AppBootstrapper(IIocContainer iocContainer, HttpConfiguration config) 
            : base(iocContainer, config)
        {
        }

        protected override void Configure()
        {
            base.Configure();
        }
    }

    public interface IHttpConfigurationProvider
    {
        IHttpConfigurationProxy GetConfiguration();
    }

    public class IisBootstrapper : BootstrapperBase, IHttpConfigurationProvider
    {
        private readonly HttpConfiguration _config;
        private IHttpConfigurationProxy _httpConfigurationProxy;

        public IisBootstrapper(IIocContainer iocContainer, HttpConfiguration config) 
            : base(iocContainer)
        {
            _config = config;
        }

        public IHttpConfigurationProxy GetConfiguration()
        {
            return _httpConfigurationProxy;
        }

        protected override void Configure()
        {
            _httpConfigurationProxy = new HttpConfigurationProxy(_config);
            SetupHttpConfiguration(_httpConfigurationProxy);
        }
    }
}