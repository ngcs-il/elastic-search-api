using System;
using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;

namespace Ngcs.WebApi2.Core
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	public class ExceptionFilterAttribute : System.Web.Http.Filters.ExceptionFilterAttribute
	{
		public override void OnException(HttpActionExecutedContext actionExecutedContext)
		{
			if (actionExecutedContext.Exception is NotImplementedException)
			{
				actionExecutedContext.Response = new HttpResponseMessage
				{
					StatusCode = HttpStatusCode.NotImplemented,
					Content = new StringContent(actionExecutedContext.Exception.ToString()),
					ReasonPhrase = actionExecutedContext.Exception.Message
				};
			}

			if (actionExecutedContext.Exception is UnauthorizedAccessException)
			{
				actionExecutedContext.Response = new HttpResponseMessage
				{
					StatusCode = HttpStatusCode.Unauthorized,
					Content = new StringContent(actionExecutedContext.Exception.ToString()),
					ReasonPhrase = actionExecutedContext.Exception.Message
				};
			}
		}
	}
}