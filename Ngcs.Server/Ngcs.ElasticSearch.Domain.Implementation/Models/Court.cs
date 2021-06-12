using Ngcs.ElasticSearch.Domain.Contracts;

namespace Ngcs.ElasticSearch.Domain.Implementation.Models
{
    public class Court : ICourt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
    }
}