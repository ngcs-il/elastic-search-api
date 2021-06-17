using System.Threading;
using System.Threading.Tasks;
using Ngcs.ElasticSerch.Domain.Entities;

namespace Ngcs.ElasticSearch.Domain.Contracts
{
    public interface ICourtsService
    {
	    Court[] GetCourts();

        Task<Court[]> GetCourtsAsync(CancellationToken cancellationToken);
    }
}