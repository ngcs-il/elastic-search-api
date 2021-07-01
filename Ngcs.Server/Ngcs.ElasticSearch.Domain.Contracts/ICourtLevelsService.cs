using System.Threading;
using System.Threading.Tasks;
using Ngcs.ElasticSearch.Domain.Entities;

namespace Ngcs.ElasticSearch.Domain.Contracts
{
    public interface ICourtLevelsService
    {
        Task<CourtLevel[]> GetCourtLevelsAsync(CancellationToken cancellationToken = default);
    }
}