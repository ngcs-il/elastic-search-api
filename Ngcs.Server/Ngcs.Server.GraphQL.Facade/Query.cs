using System.Collections.Generic;
using System.Threading.Tasks;
using HotChocolate;
using Ngcs.ElasticSearch.Domain.Contracts;
using Ngcs.ElasticSerch.Domain.Entities;

namespace Ngcs.Server.GraphQL.Facade
{
	public sealed class Query
	{
		
		public async Task<IEnumerable<CourtEntity>> GetCourts([Service] ICourtsService courtsService) => await courtsService.GetCourtsAsync();
		
	}
}