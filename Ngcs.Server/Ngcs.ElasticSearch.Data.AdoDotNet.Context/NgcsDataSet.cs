﻿using System.Data;
using System.Data.SqlClient;
using JetBrains.Annotations;
using Ngcs.Data.AdoDotNet.DbContext;

namespace Ngcs.ElasticSearch.Data.AdoDotNet.Context
{
    partial class NgcsDataSet
    {
    }
}

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
}