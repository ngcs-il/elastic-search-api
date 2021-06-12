using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Ngcs.ElasticSearch.Api.Controllers
{
    public partial class ProceedingsController
    {
        /// <summary>Listing Proceeding types</summary>
        /// <returns>OK</returns>
        private partial Task<ApiResponse<ICollection<ProceedingDto>>> GetProceedingsImplementationAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}