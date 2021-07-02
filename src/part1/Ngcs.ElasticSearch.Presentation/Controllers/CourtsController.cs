﻿using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using Ngcs.ElasticSearch.Domain.Contracts;
using Ngcs.ElasticSearch.Presentation.Mappers;

#pragma warning disable 1998

namespace Ngcs.ElasticSearch.Presentation.Controllers
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
            return Ok((await _courtsService.GetCourtsAsync(cancellationToken).ConfigureAwait(false))
								.Select(x => _courtMapper.MapToCourtDto(x)));
        }

        /// <summary>Listing Court Level types</summary>
        /// <returns>OK</returns>
        private partial Task<IHttpActionResult> GetCourtLevelsImplementationAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}