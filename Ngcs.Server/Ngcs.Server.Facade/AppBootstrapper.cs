using System.Web.Http;
using Ngcs.Practices.IoC;
using Ngcs.WebApi2.Core;

namespace Ngcs.Server.Facade
{
	public class AppBootstrapper : IisBootstrapper
    {
	    /// <inheritdoc />
	    public AppBootstrapper(IIocContainer iocContainer)
            : base(iocContainer)
        {
        }

	    /// <inheritdoc />
        public override string ModulesPath =>
#if DEBUG && ADONET
			"..\\bin\\AspNet";
#elif DEBUG && EF
            "..\\bin\\DebugEF";
#else
            "..\\bin\\Release";
#endif

		protected override void Configure()
	    {
		    base.Configure();
			GlobalConfiguration.Configuration.Filters.Add(new ExceptionFilterAttribute());
	    }
    }
}