using Ngcs.ElasticSerch.Domain.Entities;

namespace Ngcs.ElasticSearch.Domain.Contracts
{
    public interface ICourtsService
    {
        Court[] GetCourts();
    }
}