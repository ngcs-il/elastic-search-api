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
    public partial class CourtsController
    {
        private readonly ICourtsService _courtsService;
        private readonly CourtMapper _courtMapper;

        public CourtsController(ICourtsService courtsService, CourtMapper courtMapper)
        {
            _courtsService = courtsService;
            _courtMapper = courtMapper;
        }

        /// <summary>Listing Courts</summary>
        /// <returns>OK</returns>
        private async partial Task<IHttpActionResult> GetCourtsImplementationAsync(CancellationToken cancellationToken)
        {
            return Ok(_courtsService.GetCourts().Select(x => _courtMapper.MapToCourtDto(x)));
        }

        /// <summary>Listing Court Level types</summary>
        /// <returns>OK</returns>
        private partial Task<IHttpActionResult> GetCourtLevelsImplementationAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}