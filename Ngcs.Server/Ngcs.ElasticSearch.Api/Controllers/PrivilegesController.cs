using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Ngcs.ElasticSearch.Api.Controllers
{
    public partial class PrivilegesController
    {
        /// <summary>Listing Privileges types</summary>
        /// <returns>OK</returns>
        private partial Task<ApiResponse<ICollection<PrivilegeDto>>> GetPrivilegesImplementationAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

    }
}