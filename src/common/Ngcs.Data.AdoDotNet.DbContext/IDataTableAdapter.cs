using System.Data;

namespace Ngcs.Data.AdoDotNet.DbContext
{
    public interface IDataTableAdapter
    {
        void SetConnection(IDbConnection connection);

        int Fill(DataTable dataTable);
    }
}