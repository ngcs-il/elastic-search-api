using System.IO;
using Ngcs.Practices.IoC;

namespace Ngcs.Practices.Composition
{
    public abstract class BootstrapperInitializationFacadeBase : IBootstrapperInitializationFacade
    {
        private readonly IIocContainer _iocContainer;
        protected ICompositionContainer CompositionContainer;

        protected BootstrapperInitializationFacadeBase(IIocContainer iocContainer) => this._iocContainer = iocContainer;

        public IAssembliesReadOnlyResolver AssembliesResolver { get; private set; }

        public void Initialize(string rootPath)
        {
            this.InitializeComposition(rootPath);
            this.AssembliesResolver = this.CreateAssembliesResolver();
            this.RegisterModules();
        }

        protected abstract IAssembliesReadOnlyResolver CreateAssembliesResolver();

        private void InitializeComposition(string rootPath)
        {
            if (!Directory.Exists(rootPath))
                Directory.CreateDirectory(rootPath);
            this.CompositionContainer = new Ngcs.Practices.Composition.CompositionContainer(rootPath);
            this.CompositionContainer.Compose();
        }

        private void RegisterModules() => new ModuleRegistrator(this._iocContainer, this.CompositionContainer).RegisterModules();
    }
}