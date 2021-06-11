using Ngcs.Practices.Composition;
using Ngcs.Practices.IoC;

namespace NGCS.Practices.Composition.Web
{
	public class BootstrapperInitializationFacade : BootstrapperInitializationFacadeBase
	{
		public BootstrapperInitializationFacade(IIocContainer iocContainer)
			: base(iocContainer)
		{
		}

		protected override IAssembliesReadOnlyResolver CreateAssembliesResolver() => (IAssembliesReadOnlyResolver)new AssembliesResolver((ICompositionModulesProvider)this.CompositionContainer);
	}
}