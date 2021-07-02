using System.Data;

namespace Ngcs.Data.DbContext.AdoDotNet
{
    public interface IDataTableAdapter
    {
        void SetConnection(IDbConnection connection);

        int Fill(DataTable dataTable);
    }
}