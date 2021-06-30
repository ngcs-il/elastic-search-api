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
    /// <summary>
    /// Represents a Courts endpoint.
    /// </summary>
    /// <example></example>
	//[Impersonate]
    public partial class CourtsController
    {
        private readonly ICourtsService _courtsService;
        private readonly CourtMapper _courtMapper;

        /// <summary>
        /// Initializes new instance of the CourtsController class.
        /// </summary>
        /// <param name="courtsService">The service representing the Courts business domain (model).</param>
        /// <param name="courtMapper">The service representing methods for mapping of properties
        /// of the Courts entity to CourtsDto properties and versa.
        /// </param>
        /// <remarks>All of dependencies of the class should be automatically injected.
        /// Do not forget to register dependencies properly.
        /// </remarks>
        public CourtsController(ICourtsService courtsService, CourtMapper courtMapper)
        {
            _courtsService = courtsService;
            _courtMapper = courtMapper;
        }

        /// <summary>Listing Courts</summary>
        /// <returns>OK</returns>
        private async partial Task<IHttpActionResult> GetCourtsImplementationAsync(CancellationToken cancellationToken)
        {
            var courtLevels = await _courtsService.GetCourtLevelsAsync(cancellationToken).ConfigureAwait(false);
            var courts = await _courtsService.GetCourtsAsync(cancellationToken).ConfigureAwait(false);
            return Ok(courts.Select(court =>
            {
                var courtDto = _courtMapper.MapToCourtDto(court);
                courtDto.Level = courtLevels.Single(level => level.Id == court.LevelId).Name;
                return courtDto;
            }));
        }

        /// <summary>Listing Court Level types</summary>
        /// <returns>OK</returns>
        private async partial Task<IHttpActionResult> GetCourtLevelsImplementationAsync(CancellationToken cancellationToken)
        {
            var courtLevels = await _courtsService.GetCourtLevelsAsync(cancellationToken).ConfigureAwait(false);
            return Ok(courtLevels.Select(courtLevel => _courtMapper.MapToCourtLevelDto(courtLevel)));
        }
    }
}