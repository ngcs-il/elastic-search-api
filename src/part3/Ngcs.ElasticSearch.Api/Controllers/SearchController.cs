using System;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

// ReSharper disable UnusedParameterInPartialMethod

namespace Ngcs.ElasticSearch.Api.Controllers
{
    public partial class SearchController
    {
        private partial Task<IHttpActionResult> PostSearchQueryImplementationAsync(QueryDto body, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}