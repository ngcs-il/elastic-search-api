using Ngcs.ElasticSearch.Domain.Contracts;

namespace Ngcs.ElasticSearch.Domain.Implementation.Services
{
    internal class ValueService: IValueService
    {
        public int GetValue()
        {
            return 115;
        }
    }
}