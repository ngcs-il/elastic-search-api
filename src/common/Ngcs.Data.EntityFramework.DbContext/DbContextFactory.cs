using System;

namespace Ngcs.Data.EntityFramework.DbContext
{
    public interface IDbContextFactory
    {
        TContext CreateDbContext<TContext>() where TContext : System.Data.Entity.DbContext;
    }

    public class DbContextFactory : IDbContextFactory
    {
        public TContext CreateDbContext<TContext>() where TContext : System.Data.Entity.DbContext
        {
            return (TContext)Activator.CreateInstance(typeof(TContext));
        }
    }
}
