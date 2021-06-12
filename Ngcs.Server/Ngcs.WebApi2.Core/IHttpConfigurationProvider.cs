using LogoFX.Web.Core;

namespace Ngcs.WebApi2.Core
{
	/// <inheritdoc />
	public interface IHttpConfigurationProvider
	{
		/// <inheritdoc />
		IHttpConfigurationProxy GetConfiguration();
	}
}