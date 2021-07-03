using Ngcs.Web.Core;

namespace Ngcs.WebApi2.Core
{
	public interface IHttpConfigurationProvider
	{
		IHttpConfigurationProxy GetConfiguration();
	}
}