using System.Data.Entity.Infrastructure;

namespace Ngcs.Data.EntityFramework.DbContext
{
    public interface IDbContextConfiguration
    {
        DbContextConfiguration ContextConfiguration { get; }
    }    
}
