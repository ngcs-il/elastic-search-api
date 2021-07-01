using System.Configuration;
using Ngcs.Data.Repository;

namespace Ngcs.Server.Facade
{
    internal class ConnectionStringService : IConnectionStringService
    {
        private const string ConnectionName = "appEntities";
        private readonly string _connectionString;
        private readonly string _providerName;

        public ConnectionStringService()
        {
            var settings = ConfigurationManager.ConnectionStrings[ConnectionName];

            // If found, return the connection string.
            if (settings != null)
            {
                _connectionString = settings.ConnectionString;
                _providerName = settings.ProviderName;
            }
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