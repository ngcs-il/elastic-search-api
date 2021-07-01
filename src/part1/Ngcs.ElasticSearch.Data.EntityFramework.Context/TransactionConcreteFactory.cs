using JetBrains.Annotations;
using Ngcs.Data.EntityFramework.DbContext;

namespace Ngcs.ElasticSearch.Data.EntityFramework.Context
{
    [UsedImplicitly]
    public class TransactionConcreteFactory : TransactionAbstractFactory<AppDbContext>
    {
        private readonly IDbContextFactory _dbContextFactory;

        public TransactionConcreteFactory(IDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        protected override AppDbContext CreateDbContext()
        {
            return _dbContextFactory.CreateDbContext<AppDbContext>();
        }
    }
}