using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Ngcs.ElasticSearch.Api.Controllers
{
    public partial class ProceduresController
    {
        /// <summary>Listing Procedure types</summary>
        /// <returns>OK</returns>
        private partial Task<ApiResponse<ICollection<ProcedureDto>>> GetProceduresImplementationAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}