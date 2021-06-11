using System.Web.Http;
using Ngcs.ElasticSearch.Domain.Contracts;

namespace Ngcs.ElasticSearch.Api.Controllers
{
    public class Values2Controller : ApiController
    {
        private readonly IValueService _valueService;

        public Values2Controller(IValueService valueService)
        {
            _valueService = valueService;
        }

        [HttpGet]
        [Route("~/api/Values2")]
        public int GetValue()
        {
            return _valueService.GetValue() * 2;
        }
    }
}
