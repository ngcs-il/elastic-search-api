using Ngcs.Data.DbContext.AdoDotNet;

namespace Ngcs.ElasticSearch.Data.Context.AdoDotNet
{
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