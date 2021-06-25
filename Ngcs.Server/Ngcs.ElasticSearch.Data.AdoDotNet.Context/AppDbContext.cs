using System.Data;
using Ngcs.Data.AdoDotNet.DbContext;

namespace Ngcs.ElasticSearch.Data.AdoDotNet.Context
{
    public class AppDbContext : IDbContext
    {
        public IDbConnection Connection { get; }

        public TypedTableBase<T> Set<T>() where T : DataRow
        {
            throw new System.NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}