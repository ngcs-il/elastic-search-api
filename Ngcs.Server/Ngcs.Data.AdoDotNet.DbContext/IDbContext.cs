using System.Data;
using System.Linq;

namespace Ngcs.Data.AdoDotNet.DbContext
{
    public interface IDbContext
    {
        IDbConnection Connection { get; }

        IQueryable<T> Set<T>()
            where T : class;

        int SaveChanges();
    }
}