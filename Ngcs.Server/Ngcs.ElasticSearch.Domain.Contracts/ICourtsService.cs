using System.Threading;
using System.Threading.Tasks;
using Ngcs.ElasticSerch.Domain.Entities;

namespace Ngcs.ElasticSearch.Domain.Contracts
{
    public interface ICourtsService
    {
        Task<CourtEntity[]> GetCourtsAsync(CancellationToken cancellationToken = default);
    }
}