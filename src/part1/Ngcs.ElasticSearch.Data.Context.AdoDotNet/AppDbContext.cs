using System.Data;
using System.Data.SqlClient;
using System.Linq;
using JetBrains.Annotations;
using Ngcs.Data.DbContext.AdoDotNet;
using Ngcs.Data.Repository;
using Ngcs.ElasticSearch.Data.Context.AdoDotNet.NgcsDataSetTableAdapters;
using Ngcs.ElasticSearch.Domain.Entities;

namespace Ngcs.ElasticSearch.Data.Context.AdoDotNet
{
    [UsedImplicitly]
    public class AppDbContext : IDbContext
    {
        private readonly IConnectionStringService _connectionStringService;
        private DbMapperBuilder _dbMapperBuilder;
        private SqlConnection _connection;

        public AppDbContext(IConnectionStringService connectionStringService)
        {
            _connectionStringService = connectionStringService;
            Initialize();
        }

        private void Initialize()
        {
            var connectionString = _connectionStringService.GetConnectionString();

            _connection = new SqlConnection(connectionString);
            _dbMapperBuilder = new DbMapperBuilder(_connection);

            _dbMapperBuilder.AddMapping<Court, CourtsTableAdapter, NgcsDataSet.CourtsDataTable>(dataRow =>
            {
                var courtsRow = (NgcsDataSet.CourtsRow) dataRow;
                return new Court
                {
                    Id = courtsRow.id,
                    Name = courtsRow.name,
                    LevelId = courtsRow.levelId
                };
            });
        }

        IDbConnection IDbContext.Connection => _connection;

        IQueryable<T> IDbContext.Set<T>()
        {
            var dataTable = _dbMapperBuilder.GetDataTable<T>();
            var entities = _dbMapperBuilder.Convert<T>(dataTable);
            return entities.AsQueryable();
        }

        int IDbContext.SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}