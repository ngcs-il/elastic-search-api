using AutoMapper;
using JetBrains.Annotations;
using Ngcs.ElasticSearch.Api.Controllers;
using Ngcs.ElasticSerch.Domain.Entities;

namespace Ngcs.ElasticSearch.Api.Mappers
{
    /// <summary>
    /// Maps CourtEntity domain entity to CourtDto and versa.
    /// </summary>
    [UsedImplicitly]
    public class CourtMapper
    {
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes an instance of the CourtMapper class.
        /// </summary>
        /// <param name="mapper">The instance of the actual mapper.</param>
        public CourtMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        internal CourtDto MapToCourtDto(CourtEntity courtEntity) => _mapper.Map<CourtDto>(courtEntity);

        internal CourtEntity MapToCourt(CourtDto courtDto) => _mapper.Map<CourtEntity>(courtDto);
    }
}