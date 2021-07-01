using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using JetBrains.Annotations;
using Ngcs.Data.AdoDotNet.DbContext;
using Ngcs.ElasticSearch.Data.AdoDotNet.Context.NgcsDataSetTableAdapters;
using Ngcs.ElasticSearch.Domain.Entities;

namespace Ngcs.ElasticSearch.Data.AdoDotNet.Context
{
    [UsedImplicitly]
    public class AppDbContext : IDbContext
    {
        private DbMapperBuilder _dbMapperBuilder;
        private SqlConnection _connection;

        public AppDbContext()
        {
            Initialize();
        }

        private void Initialize()
        {
            var connectionString = GetConnectionStringByName("appEntities");
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

            _dbMapperBuilder.AddMapping<CourtLevel, CourtLevelsTableAdapter, NgcsDataSet.CourtLevelsDataTable>(dataRow =>
            {
                var courtLevelsRow = (NgcsDataSet.CourtLevelsRow) dataRow;
                return new CourtLevel
                {
                    Id = courtLevelsRow.id,
                    Name = courtLevelsRow.name
                };
            });

        }

        /// <summary>
        /// Retrieves a connection string by name. 
        /// </summary>
        /// <param name="name">Connection string name.</param>
        /// <returns>Null if the name is not found.</returns>
        private static string GetConnectionStringByName(string name)
        {
            // Assume failure.
            string returnValue = null;

            // Look for the name in the connectionStrings section.
            var settings = ConfigurationManager.ConnectionStrings[name];

            // If found, return the connection string.
            if (settings != null)
            {
                returnValue = settings.ConnectionString;
            }

            return returnValue;
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