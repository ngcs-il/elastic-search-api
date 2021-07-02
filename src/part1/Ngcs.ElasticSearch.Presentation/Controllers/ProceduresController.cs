using System;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace Ngcs.ElasticSearch.Presentation.Controllers
{
    public partial class ProceduresController
    {
        /// <summary>Listing Procedure types</summary>
        /// <returns>OK</returns>
        private partial Task<IHttpActionResult> GetProceduresImplementationAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}