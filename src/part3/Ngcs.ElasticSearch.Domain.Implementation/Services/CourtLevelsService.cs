using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Ngcs.Data.Repository;
using Ngcs.ElasticSearch.Domain.Contracts;
using Ngcs.ElasticSearch.Domain.Entities;

namespace Ngcs.ElasticSearch.Domain.Implementation.Services
{
    [UsedImplicitly]
    internal sealed class CourtLevelsService : ICourtLevelsService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CourtLevelsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        async Task<CourtLevel[]> ICourtLevelsService.GetCourtLevelsAsync(CancellationToken cancellationToken)
        {
            var repository = _unitOfWork.Repository<CourtLevel>();
            var courtLevels = await Task.Run(() => repository.GetAll().ToArray(), cancellationToken);
            return courtLevels;
        }
    }
}