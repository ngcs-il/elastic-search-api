using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Ngcs.Data.Repository;
using Ngcs.ElasticSearch.Domain.Contracts;
using Ngcs.ElasticSerch.Domain.Entities;

namespace Ngcs.ElasticSearch.Domain.Implementation.Services
{
    [UsedImplicitly]
    internal sealed class CourtsService : ICourtsService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CourtsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        async Task<CourtEntity[]> ICourtsService.GetCourtsAsync(CancellationToken cancellationToken)
        {
            var repository = _unitOfWork.Repository<CourtEntity>();
            var courts = await Task.Run(() => repository.GetAll().ToArray(), cancellationToken);
            return courts;
        }
    }
}