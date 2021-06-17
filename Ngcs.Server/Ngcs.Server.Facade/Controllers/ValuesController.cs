using System.Web.Http;
using Ngcs.ElasticSearch.Domain.Contracts;

namespace Ngcs.Server.Facade.Controllers
{
    /// <summary>
    /// Represents the Value API endpoint.
    /// </summary>
    public class ValuesController : ApiController
    {
        private readonly IValueService _valueService;

        /// <summary>
        /// Initializes a new instance of the ValueController class.
        /// </summary>
        /// <param name="valueService"></param>
        public ValuesController(IValueService valueService)
        {
            _valueService = valueService;
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <returns>The integer number.</returns>
        [HttpGet]
        [Route("~/api/Values")]
        public IHttpActionResult GetValue()
        {
            return Ok(_valueService.GetValue());
        }
    }
}
