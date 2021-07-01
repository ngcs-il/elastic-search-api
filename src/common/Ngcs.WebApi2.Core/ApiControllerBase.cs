using System.Web.Http;

namespace Ngcs.WebApi2.Core
{
    public abstract class ApiControllerBase : ApiController
    {
	    protected string Upn => null;
    }
}