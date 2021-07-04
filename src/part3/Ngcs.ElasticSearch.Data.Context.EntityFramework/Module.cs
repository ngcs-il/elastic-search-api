using System.ComponentModel.Composition;
using Ngcs.Data.DbContext.EntityFramework;
using Ngcs.Data.Repository;
using Ngcs.Data.Repository.EntityFramework;
using Ngcs.Practices.IoC;
using ICompositionModule = Ngcs.Practices.Composition.ICompositionModule;
#if EF
using Solid.Practices.Modularity;
using Microsoft.Extensions.DependencyInjection;
#endif

namespace Ngcs.ElasticSearch.Data.Context.EntityFramework
{
    [Export(typeof(ICompositionModule))]
    class Module : ICompositionModule
#if EF
        , ICompositionModule<IServiceCollection>
#endif
    {
        public void RegisterModule(IIocContainer container)
        {
            container.RegisterSingleton<IUnitOfWork, UnitOfWork>();
            container.RegisterSingleton<IDbContext, AppDbContext>();
            container.RegisterTransient<ITransactionFactory, TransactionConcreteFactory>();
            container.RegisterTransient<IDbContextFactory, DbContextFactory>();
        }

#if EF
        public void RegisterModule(IServiceCollection dependencyRegistrator)
        {
            dependencyRegistrator.AddSingleton<IUnitOfWork, UnitOfWork>();
            dependencyRegistrator.AddSingleton<IDbContext, AppDbContext>();
            dependencyRegistrator.AddSingleton<ITransactionFactory, TransactionConcreteFactory>();
            dependencyRegistrator.AddSingleton<IDbContextFactory, DbContextFactory>();
        }
#endif
    }
}