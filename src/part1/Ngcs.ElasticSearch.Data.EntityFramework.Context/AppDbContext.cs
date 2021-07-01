using System.Data.Entity;
using JetBrains.Annotations;
using Ngcs.Data.EntityFramework.DbContext;
using Ngcs.ElasticSearch.Domain.Entities;

namespace Ngcs.ElasticSearch.Data.EntityFramework.Context
{
    [UsedImplicitly]
    public class AppDbContext : DbContext, IDbContext
    {
        public AppDbContext()
            : base("name=appEntities")
        {
            Database.SetInitializer<AppDbContext>(null);

        }
        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Court>().ToTable("Courts");
        }
    }
}