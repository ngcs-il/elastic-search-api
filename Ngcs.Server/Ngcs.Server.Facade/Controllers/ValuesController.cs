using System.Web.Http;
using Ngcs.ElasticSearch.Domain.Contracts;

namespace Ngcs.Server.Facade.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IValueService _valueService;

        public ValuesController(IValueService valueService)
        {
            _valueService = valueService;
        }

        [HttpGet]
        [Route("~/api/Values")]
        public int GetValue()
        {
            return _valueService.GetValue();
        }
    }
}
