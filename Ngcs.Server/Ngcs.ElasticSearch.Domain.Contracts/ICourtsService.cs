using System.Threading;
using System.Threading.Tasks;
using Ngcs.ElasticSearch.Domain.Entities;

namespace Ngcs.ElasticSearch.Domain.Contracts
{
    public interface ICourtsService
    {
        Task<Court[]> GetCourtsAsync(CancellationToken cancellationToken = default);

        Task<CourtLevel[]> GetCourtLevelsAsync(CancellationToken cancellationToken = default);
    }
}