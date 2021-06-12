using System.Web.Http;
using LogoFX.Web.Core;
using Ngcs.Practices.IoC;

namespace Ngcs.WebApi2.Core
{
	/// <inheritdoc />
	public class IisBootstrapper : BootstrapperBase, IHttpConfigurationProvider
	{
		private IHttpConfigurationProxy _httpConfigurationProxy;

		/// <inheritdoc />
		public IisBootstrapper(IIocContainer iocContainer)
			: base(iocContainer)
		{
		}

		/// <inheritdoc />
		public IHttpConfigurationProxy GetConfiguration() => _httpConfigurationProxy;

		/// <inheritdoc />
		protected override void Configure()
		{
			var config = GlobalConfiguration.Configuration;
			_httpConfigurationProxy = new HttpConfigurationProxy(config);
			SetupHttpConfiguration(_httpConfigurationProxy);
		}
	}
}