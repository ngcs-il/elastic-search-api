using System.Data;
using System.Data.SqlClient;
using JetBrains.Annotations;
using Ngcs.Data.DbContext.AdoDotNet;

// ReSharper disable once CheckNamespace
namespace Ngcs.ElasticSearch.Data.Context.AdoDotNet.NgcsDataSetTableAdapters
{
    [UsedImplicitly]
    partial class CourtsTableAdapter : IDataTableAdapter
    {
        public void SetConnection(IDbConnection connection)
        {
            Connection = (SqlConnection)connection;
        }

        public int Fill(DataTable dataTable)
        {
            return Fill((NgcsDataSet.CourtsDataTable)dataTable);
        }
    }
}