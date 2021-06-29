using System.ComponentModel.Composition;
using Microsoft.Extensions.DependencyInjection;
using Ngcs.Data.AdoDotNet.DbContext;
using Ngcs.Data.AdoDotNet.Repository;
using Ngcs.Data.Repository;
using Ngcs.Practices.IoC;
using Solid.Practices.Modularity;
using ICompositionModule = Ngcs.Practices.Composition.ICompositionModule;

namespace Ngcs.ElasticSearch.Data.AdoDotNet.Context
{
    [Export(typeof(ICompositionModule))]
    class Module : ICompositionModule, ICompositionModule<IServiceCollection>
    {
        public void RegisterModule(IIocContainer container)
        {
            container.RegisterSingleton<IUnitOfWork, UnitOfWork>();
            container.RegisterSingleton<IDbContext, AppDbContext>();
            container.RegisterTransient<ITransactionFactory, TransactionConcreteFactory>();
            container.RegisterTransient<IDbContextFactory, DbContextFactory>();
        }

        public void RegisterModule(IServiceCollection dependencyRegistrator)
        {
            dependencyRegistrator.AddSingleton<IUnitOfWork, UnitOfWork>();
            dependencyRegistrator.AddSingleton<IDbContext, AppDbContext>();
            dependencyRegistrator.AddSingleton<ITransactionFactory, TransactionConcreteFactory>();
            dependencyRegistrator.AddSingleton<IDbContextFactory, DbContextFactory>();
        }
    }
}