using Ngcs.Practices.Composition;
using Ngcs.Practices.IoC;

namespace Ngcs.Web.Core
{
	public class BootstrapperInitializationFacade : BootstrapperInitializationFacadeBase
	{
		public BootstrapperInitializationFacade(IIocContainer iocContainer)
			: base(iocContainer)
		{
		}

		protected override IAssembliesReadOnlyResolver CreateAssembliesResolver() 
			=> new AssembliesResolver(CompositionContainer);
	}
}