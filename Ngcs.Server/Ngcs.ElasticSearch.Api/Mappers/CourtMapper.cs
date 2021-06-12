using Ngcs.ElasticSearch.Api.Controllers;
using Ngcs.ElasticSearch.Domain.Contracts;

namespace Ngcs.ElasticSearch.Api.Mappers
{
    public static class CourtMapper
    {
        public static CourtDto ToDto(ICourt model)
        {
            return new CourtDto
            {
                Id = model.Id,
                Name = model.Name,
                Level = model.Level
            };
        }
    }
}