using System;
using System.IO;
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
			
			actionExecutedContext.Response = CreateHttpResponseMessage(actionExecutedContext.Exception);
			
		}

		private static HttpResponseMessage CreateHttpResponseMessage(Exception exception)
		{
			return new HttpResponseMessage
			{
				StatusCode = TranslateExceptionToStatusCode(exception),
				Content = new StringContent(exception.ToString()),
				ReasonPhrase = exception.Message
			};
		}

		private static HttpStatusCode TranslateExceptionToStatusCode(Exception exception)
		{
			if (exception is NotImplementedException)
			{
				return HttpStatusCode.NotImplemented;
			}

			if (exception is UnauthorizedAccessException)
			{
				return HttpStatusCode.Unauthorized;
			}

			if (exception is FileNotFoundException)
			{
				return HttpStatusCode.NotFound;
			}

			
			return HttpStatusCode.InternalServerError;
		}
	}
}