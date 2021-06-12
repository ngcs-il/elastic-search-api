using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Ngcs.ElasticSearch.Api.Controllers
{
    public partial class CourtsController
    {
        /// <summary>Listing Courts</summary>
        /// <returns>OK</returns>
        private partial Task<ApiResponse<ICollection<CourtDto>>> GetCourtsImplementationAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        /// <summary>Listing Court Level types</summary>
        /// <returns>OK</returns>
        private partial Task<ApiResponse<ICollection<CourtLevelDto>>> GetCourtLevelsImplementationAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}