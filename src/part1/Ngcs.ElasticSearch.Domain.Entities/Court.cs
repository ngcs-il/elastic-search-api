using JetBrains.Annotations;

namespace Ngcs.ElasticSearch.Domain.Entities
{
    [UsedImplicitly]
    public class Court
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LevelId { get; set; }
    }
}