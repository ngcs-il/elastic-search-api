using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using Ngcs.ElasticSearch.Api.Mappers;
using Ngcs.ElasticSearch.Domain.Contracts;
#pragma warning disable 1998

namespace Ngcs.ElasticSearch.Api.Controllers
{
    //[Impersonate]
    public partial class CourtsController
    {
        private readonly ICourtsService _courtsService;

        public CourtsController(ICourtsService courtsService)
        {
            _courtsService = courtsService;
        }

        /// <summary>Listing Courts</summary>
        /// <returns>OK</returns>
        
        private async partial Task<IHttpActionResult> GetCourtsImplementationAsync(CancellationToken cancellationToken)
        {
            return Ok(_courtsService.GetCourts().Select(CourtMapper.ToDto));
        }

        /// <summary>Listing Court Level types</summary>
        /// <returns>OK</returns>
        private partial Task<IHttpActionResult> GetCourtLevelsImplementationAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}