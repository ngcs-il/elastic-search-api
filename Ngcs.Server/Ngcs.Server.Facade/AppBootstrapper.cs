using System.Web.Http;
using LogoFX.Web.Core;
using Ngcs.Practices.IoC;

namespace Ngcs.Server.Facade
{
    public class AppBootstrapper : IisBootstrapper
    {
        public AppBootstrapper(IIocContainer iocContainer)
            : base(iocContainer)
        {
        }

        public override string ModulesPath
        {
            get
            {
                return Properties.Resources.ModulesPath;
            }
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
        private IHttpConfigurationProxy _httpConfigurationProxy;

        public IisBootstrapper(IIocContainer iocContainer)
            : base(iocContainer)
        {
        }

        public IHttpConfigurationProxy GetConfiguration()
        {
            return _httpConfigurationProxy;
        }

        protected override void Configure()
        {
            var config = GlobalConfiguration.Configuration;
            _httpConfigurationProxy = new HttpConfigurationProxy(config);
            SetupHttpConfiguration(_httpConfigurationProxy);
        }
    }
}