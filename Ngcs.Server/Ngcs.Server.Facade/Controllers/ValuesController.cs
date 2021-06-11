using System.Web.Http;

namespace Ngcs.Server.Facade.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        [Route("~/api/Values")]
        public int GetValue()
        {
            return 5;
        }
    }
}
