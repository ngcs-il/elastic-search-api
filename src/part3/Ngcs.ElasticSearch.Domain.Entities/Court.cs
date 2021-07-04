using JetBrains.Annotations;

namespace Ngcs.ElasticSearch.Domain.Entities
{
    [UsedImplicitly]
    public class Court
    {
        public int Id { [UsedImplicitly] get; set; }
        public string Name { [UsedImplicitly] get; set; }
        public int LevelId { [UsedImplicitly] get; set; }
    }
}