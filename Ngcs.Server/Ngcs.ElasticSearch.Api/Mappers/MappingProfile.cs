﻿using System;
using AutoMapper;
using Ngcs.ElasticSearch.Api.Controllers;
using Ngcs.ElasticSearch.Domain.Implementation.Models;

namespace Ngcs.ElasticSearch.Api.Mappers
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateCourtsMaps();
        }

        private void CreateCourtsMaps() => CreateDomainObjectMap<CourtDto, Court>();

        //TODO: put this piece of functionality into 
        //an external package, e.g. Model.Mapping.AutoMapper
        private void CreateDomainObjectMap<TDto, TModel>() => CreateDomainObjectMap(typeof(TDto), typeof(TModel));

        private void CreateDomainObjectMap(Type dtoType, Type modelType)
        {
            CreateMap(dtoType, modelType);
            CreateMap(modelType, dtoType);
        }
    }
}