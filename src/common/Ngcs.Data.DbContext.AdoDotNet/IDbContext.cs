using System.Data;
using System.Linq;

namespace Ngcs.Data.DbContext.AdoDotNet
{
    public interface IDbContext
    {
        IDbConnection Connection { get; }

        IQueryable<T> Set<T>()
            where T : class;

        int SaveChanges();
    }
}