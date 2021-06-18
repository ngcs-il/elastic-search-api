using System.Data.Entity;

namespace Ngcs.Data.EntityFramework.DbContext
{
    public abstract class TransactionAbstractFactory<TContext> : ITransactionFactory where TContext : System.Data.Entity.DbContext
    {
        protected abstract TContext CreateDbContext();

        public DbContextTransaction CreateTransaction()
        {
            var context = CreateDbContext();
            return context.Database.BeginTransaction();
        }
    }
}
