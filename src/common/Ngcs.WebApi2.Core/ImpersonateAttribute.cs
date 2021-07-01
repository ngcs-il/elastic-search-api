using System.Diagnostics.CodeAnalysis;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Ngcs.WebApi2.Core
{
	[SuppressMessage("ReSharper", "UnusedMember.Global")]
	public class ImpersonateAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuting(HttpActionContext actionContext)
		{
			(actionContext.ControllerContext.Controller as ApiController)?.SetImpersonationContext();
		}
	}
}