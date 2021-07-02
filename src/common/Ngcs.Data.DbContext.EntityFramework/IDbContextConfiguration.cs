using System.Data.Entity.Infrastructure;

namespace Ngcs.Data.DbContext.EntityFramework
{
    public interface IDbContextConfiguration
    {
        DbContextConfiguration ContextConfiguration { get; }
    }    
}
