using System.Data;

namespace Ngcs.Data.DbContext.AdoDotNet
{
    public interface ITransactionFactory
    {
        IDbTransaction CreateTransaction();
    }
}