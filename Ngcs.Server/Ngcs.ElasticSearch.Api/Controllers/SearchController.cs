using System;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

// ReSharper disable UnusedParameterInPartialMethod

namespace Ngcs.ElasticSearch.Api.Controllers
{
    public partial class SearchController
    {
        private partial Task<IHttpActionResult> GetSearchResultsImplementationAsync(string q,
            int num, int start, Source? source, bool? searchInTitles, bool? searchInContent, bool? searchInMemoTitles,
            bool? searchInMemoContent, DateRangeType? dateRangeType, DateTimeOffset? startDate,
            DateTimeOffset? endDate, bool hasAppeal, bool legalCase, string court, string courtLevel,
            string interest, string procedure, string proceeding, string entities,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        private partial Task<IHttpActionResult> PostSearchQueryImplementationAsync(QueryDto body, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}