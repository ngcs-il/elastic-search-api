using Microsoft.Extensions.Configuration;
using Ngcs.Data.Repository;

namespace Ngcs.Server.GraphQL.Facade
{
    internal class ConnectionStringService : IConnectionStringService
    {
        private const string ConnectionName = "appEntities";
        private readonly string _connectionString;
        private readonly string _providerName;

        public ConnectionStringService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString(ConnectionName);
            _providerName = "System.Data.SqlClient";
        }

        public string GetConnectionString()
        {
            return _connectionString;
        }

        public string GetProviderName()
        {
            return _providerName;
        }
    }
}