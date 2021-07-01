namespace Ngcs.Data.Repository
{
    public interface IConnectionStringService
    {
        string GetConnectionString();

        string GetProviderName();
    }
}