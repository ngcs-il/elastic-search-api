using System.ComponentModel.Composition;
using Microsoft.Extensions.DependencyInjection;
using Ngcs.ElasticSearch.Domain.Contracts;
using Ngcs.ElasticSearch.Domain.Implementation.Services;
using Ngcs.Practices.IoC;
using Solid.Practices.Modularity;
using ICompositionModule = Ngcs.Practices.Composition.ICompositionModule;

namespace Ngcs.ElasticSearch.Domain.Implementation
{
    [Export(typeof(ICompositionModule))]
    class Module : ICompositionModule, ICompositionModule<IServiceCollection>
    {
        public void RegisterModule(IIocContainer container)
        {
            container.RegisterSingleton<IValueService, ValueService>();
            container.RegisterSingleton<ICourtsService, CourtsService>();
            container.RegisterSingleton<ICourtLevelsService, CourtLevelsService>();
        }

        public void RegisterModule(IServiceCollection dependencyRegistrator)
        {
            dependencyRegistrator.AddSingleton<IValueService, ValueService>();
            dependencyRegistrator.AddSingleton<ICourtsService, CourtsService>();
            dependencyRegistrator.AddSingleton<ICourtLevelsService, CourtLevelsService>();
        }
    }
}