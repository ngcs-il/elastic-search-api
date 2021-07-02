using System.ComponentModel.Composition;
using Ngcs.Data.DbContext.AdoDotNet;
using Ngcs.Data.Repository;
using Ngcs.Data.Repository.AdoDotNet;
using Ngcs.Practices.Composition;
using Ngcs.Practices.IoC;

namespace Ngcs.ElasticSearch.Data.Context.AdoDotNet
{
    [Export(typeof(ICompositionModule))]
    class Module : ICompositionModule
    {
        public void RegisterModule(IIocContainer container)
        {
            container.RegisterSingleton<IUnitOfWork, UnitOfWork>();
            container.RegisterSingleton<IDbContext, AppDbContext>();
            container.RegisterTransient<ITransactionFactory, TransactionConcreteFactory>();
            container.RegisterTransient<IDbContextFactory, DbContextFactory>();
        }
    }
}