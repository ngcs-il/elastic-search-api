using System;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

// ReSharper disable UnusedParameterInPartialMethod
namespace Ngcs.ElasticSearch.Presentation.Controllers
{
    /// <inheritdoc />
    public partial class SearchController
    {
        private partial Task<IHttpActionResult> PostSearchQueryImplementationAsync(QueryDto body, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}