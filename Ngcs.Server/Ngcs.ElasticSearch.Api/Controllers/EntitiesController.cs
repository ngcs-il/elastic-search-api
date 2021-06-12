using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Ngcs.ElasticSearch.Api.Controllers
{
    public partial class EntitiesController
    {
        /// <summary>Listing Entity types</summary>
        /// <returns>OK</returns>
        private partial Task<ApiResponse<ICollection<EntityTypeDto>>> GetEntitiesImplementationAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}