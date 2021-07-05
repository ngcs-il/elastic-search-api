﻿using System.Data.Entity;
using JetBrains.Annotations;
using Ngcs.Data.DbContext.EntityFramework;
using Ngcs.Data.Repository;
using Ngcs.ElasticSearch.Domain.Entities;

namespace Ngcs.ElasticSearch.Data.Context.EntityFramework
{
    [UsedImplicitly]
    public class AppDbContext : DbContext, IDbContext
    {
        public AppDbContext(IConnectionStringService connectionStringService)
            : base(connectionStringService.GetConnectionString())
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
            modelBuilder.Entity<CourtLevel>().ToTable("CourtLevels");
        }
    }
}