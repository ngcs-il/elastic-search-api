using System.ComponentModel.Composition;
using AutoMapper;
using JetBrains.Annotations;
using Ngcs.ElasticSearch.Api.Mappers;
using Ngcs.Practices.Composition;
using Ngcs.Practices.IoC;

namespace Ngcs.ElasticSearch.Api
{
    [UsedImplicitly]
    [Export(typeof(ICompositionModule))]
    internal sealed class MappingModule : ICompositionModule
    {
        public void RegisterModule(IIocContainer container)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            container.RegisterInstance(config.CreateMapper());
            container.RegisterSingleton<CourtMapper, CourtMapper>();
        }
    }
}