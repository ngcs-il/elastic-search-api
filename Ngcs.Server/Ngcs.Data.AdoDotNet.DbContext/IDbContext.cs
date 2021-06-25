using System.Data;

namespace Ngcs.Data.AdoDotNet.DbContext
{
    public interface IDbContext
    {
        IDbConnection Connection { get; }

        TypedTableBase<T> Set<T>()
            where T : DataRow;

        int SaveChanges();
    }
}