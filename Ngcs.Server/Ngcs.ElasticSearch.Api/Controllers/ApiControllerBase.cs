using System.Web.Http;

namespace Ngcs.ElasticSearch.Api.Controllers
{
    public abstract class ApiControllerBase : ApiController
    {
	    protected string Upn
	    {
		    get
		    {
			    return null;
		    }
	    }
    }
}