using System.Data;
using System.Data.SqlClient;
using JetBrains.Annotations;
using Ngcs.Data.AdoDotNet.DbContext;
// ReSharper disable CheckNamespace

namespace Ngcs.ElasticSearch.Data.AdoDotNet.Context.NgcsDataSetTableAdapters
{
    [UsedImplicitly]
    partial class CourtsTableAdapter : IDataTableAdapter
    {
        public void SetConnection(IDbConnection connection)
        {
            Connection = (SqlConnection) connection;
        }

        public int Fill(DataTable dataTable)
        {
            return Fill((NgcsDataSet.CourtsDataTable) dataTable);
        }
    }

    [UsedImplicitly]
    partial class CourtLevelsTableAdapter : IDataTableAdapter
    {
        public void SetConnection(IDbConnection connection)
        {
            Connection = (SqlConnection)connection;
        }

        public int Fill(DataTable dataTable)
        {
            return Fill((NgcsDataSet.CourtLevelsDataTable) dataTable);
        }
    }

}