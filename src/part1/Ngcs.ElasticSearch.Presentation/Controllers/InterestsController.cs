using System;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace Ngcs.ElasticSearch.Presentation.Controllers
{
    public partial class InterestsController
    {
        /// <summary>Listiting Interest types</summary>
        /// <returns>OK</returns>
        private partial Task<IHttpActionResult> GetInterestsImplementationAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}