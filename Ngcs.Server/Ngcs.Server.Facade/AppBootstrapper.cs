using Ngcs.Practices.IoC;
using Ngcs.WebApi2.Core;

namespace Ngcs.Server.Facade
{
	/// <inheritdoc />
	public class AppBootstrapper : IisBootstrapper
    {
	    /// <inheritdoc />
	    public AppBootstrapper(IIocContainer iocContainer)
            : base(iocContainer)
        {
        }

	    /// <inheritdoc />
        public override string ModulesPath => Properties.Resources.ModulesPath;
        
    }
}