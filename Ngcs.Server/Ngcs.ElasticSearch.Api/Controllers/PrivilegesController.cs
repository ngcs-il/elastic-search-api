﻿using System;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace Ngcs.ElasticSearch.Api.Controllers
{
    public partial class PrivilegesController
    {
        /// <summary>Listing Privileges types</summary>
        /// <returns>OK</returns>
        private partial Task<IHttpActionResult> GetPrivilegesImplementationAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

    }
}