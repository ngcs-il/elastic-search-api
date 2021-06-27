using System.Collections.Generic;
using System.Threading.Tasks;
using HotChocolate;
using Ngcs.ElasticSearch.Domain.Contracts;
using Ngcs.ElasticSearch.Domain.Entities;

namespace Ngcs.Server.GraphQL.Facade
{
	public sealed class Query
	{
		
		public async Task<IEnumerable<Court>> GetCourts([Service] ICourtsService courtsService) => await courtsService.GetCourtsAsync();
		
	}
}