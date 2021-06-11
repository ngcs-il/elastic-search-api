using System.Web.Http;

namespace Sample.Server.TestModule.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        [Route("~/api/Values/GetValue")]
        public int GetValue()
        {
            return 5;
        }
    }
}
