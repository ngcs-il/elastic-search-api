using Ngcs.ElasticSearch.Domain.Contracts;
using Ngcs.ElasticSearch.Domain.Implementation.Models;

namespace Ngcs.ElasticSearch.Domain.Implementation.Services
{
    internal sealed class FakeCourtsService : ICourtsService
    {
        public ICourt[] GetCourts()
        {
            return new ICourt[]
            {
                new Court
                {
                    Id = 17,
                    Name = "שלום נצרת",
                    Level = "שלום"
                },
                new Court
                {
                    Id = 18,
                    Name = "שלום טבריה",
                    Level = "שלום"
                },
            };
        }
    }
}