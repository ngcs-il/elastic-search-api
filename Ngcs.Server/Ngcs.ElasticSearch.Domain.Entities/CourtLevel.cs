using JetBrains.Annotations;

namespace Ngcs.ElasticSearch.Domain.Entities
{
    [UsedImplicitly]
    public class CourtLevel
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}