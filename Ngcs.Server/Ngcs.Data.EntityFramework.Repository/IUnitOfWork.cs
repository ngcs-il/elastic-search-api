using System;

namespace Ngcs.Data.EntityFramework.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
        IRepositoryBase<T> Repository<T>() where T : class;
    }
}