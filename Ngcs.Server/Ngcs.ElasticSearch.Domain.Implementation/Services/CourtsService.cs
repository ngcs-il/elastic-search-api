using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Ngcs.Data.Repository;
using Ngcs.ElasticSearch.Data.AdoDotNet.Context;
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
	        return await Task.Run(() => new CourtEntity[]
	        {
		        new CourtEntity
		        {
			        Id = 17,
			        Name = "שלום נצרת",
			        Level = "שלום"
		        },
		        new CourtEntity
		        {
			        Id = 18,
			        Name = "שלום טבריה",
			        Level = "שלום"
		        },
		        new CourtEntity
		        {
			        Id = 19,
			        Name = " טבריה",
			        Level = "שלום"
		        }
			}, cancellationToken);
            //var repository = _unitOfWork.Repository<NgcsDataSet.CourtsRow>();
            //var courts = await Task.Run(() => repository.GetAll().ToArray(), cancellationToken);
            //return courts;
        }
    }
}