using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Ngcs.ElasticSearch.Api.Controllers
{
    public partial class InterestsController
    {
        /// <summary>Listiting Interest types</summary>
        /// <returns>OK</returns>
        private partial Task<ApiResponse<ICollection<InterestDto>>> GetInterestsImplementationAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}