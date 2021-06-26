﻿using AutoMapper;
using JetBrains.Annotations;
using Ngcs.ElasticSearch.Api.Controllers;
using Ngcs.ElasticSearch.Domain.Entities;

namespace Ngcs.ElasticSearch.Api.Mappers
{
    /// <summary>
    /// Maps Court domain entity to CourtDto and versa.
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

        internal CourtDto MapToCourtDto(Court court) => _mapper.Map<CourtDto>(court);

        internal Court MapToCourt(CourtDto courtDto) => _mapper.Map<Court>(courtDto);
    }
}