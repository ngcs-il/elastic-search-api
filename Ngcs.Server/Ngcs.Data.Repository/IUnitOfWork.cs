using System;

namespace Ngcs.Data.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
        IRepository<T> Repository<T>() where T : class;
    }
}