using System.Data;

namespace Ngcs.Data.AdoDotNet.DbContext
{
    public interface ITransactionFactory
    {
        IDbTransaction CreateTransaction();
    }
}