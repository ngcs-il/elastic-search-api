namespace Ngcs.ElasticSearch.Domain.Contracts
{
    public interface ICourt
    {
        int Id { get; }

        string Name { get; }

        string Level { get; }
    }
}