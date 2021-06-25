using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using JetBrains.Annotations;
using Ngcs.Data.AdoDotNet.DbContext;

namespace Ngcs.ElasticSearch.Data.AdoDotNet.Context
{
    [UsedImplicitly]
    public class AppDbContext : IDbContext
    {
        private SqlConnection _connection;

        public AppDbContext()
        {
            Initialize();
        }

        private void Initialize()
        {
            var connectionString = GetConnectionStringByName("appEntities");
            _connection = new SqlConnection(connectionString);
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

        TypedTableBase<T> IDbContext.Set<T>()
        {
            throw new System.NotImplementedException();
        }

        int IDbContext.SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}