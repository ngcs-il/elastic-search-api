using System;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace Ngcs.ElasticSearch.Presentation.Controllers
{
    public partial class EntitiesController
    {
        /// <summary>Listing Entity types</summary>
        /// <returns>OK</returns>
        private partial Task<IHttpActionResult> GetEntitiesImplementationAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}