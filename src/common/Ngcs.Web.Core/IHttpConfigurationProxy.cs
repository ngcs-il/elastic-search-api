using System.Web.Http;

namespace Ngcs.Web.Core
{
    public interface IHttpConfigurationProxy
    {        
        IHttpConfigurationProxy MapHttpRoutes();
        IHttpConfigurationProxy ReplaceService<TService>(TService service);
        HttpConfiguration HttpConfiguration { get; }
    }
}
