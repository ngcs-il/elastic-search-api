using System.Threading;
using System.Threading.Tasks;
using Ngcs.ElasticSearch.Domain.Contracts;
using Ngcs.ElasticSerch.Domain.Entities;


namespace Ngcs.ElasticSearch.Domain.Implementation.Services
{
    internal sealed class FakeCourtsService : ICourtsService
    {
        public Court[] GetCourts()
        {
            return new Court[]
            {
                new Court
                {
                    Id = 17,
                    Name = "שלום נצרת",
                    Level = "שלום"
                },
                new Court
                {
                    Id = 18,
                    Name = "שלום טבריה",
                    Level = "שלום"
                },
            };
        }

        public Task<Court[]> GetCourtsAsync(CancellationToken cancellationToken)
        {
	        return Task.FromResult<Court[]>(new Court[]
		        {
			        new Court
			        {
				        Id = 17,
				        Name = "שלום נצרת",
				        Level = "שלום"
			        },
			        new Court
			        {
				        Id = 18,
				        Name = "שלום טבריה",
				        Level = "שלום"
			        },
		        }
	        );
        }
    }
}