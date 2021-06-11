using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Ngcs.Practices.Composition
{
    public abstract class AssembliesResolverBase : IAssembliesReadOnlyResolver
    {
        private readonly ICompositionModulesProvider _compositionModulesProvider;

        protected AssembliesResolverBase(
            ICompositionModulesProvider compositionModulesProvider)
        {
            this._compositionModulesProvider = compositionModulesProvider;
        }

        protected abstract IEnumerable<Assembly> GetRootAssemblies();

        public IEnumerable<Assembly> GetAssemblies() => this.GetRootAssemblies().Concat<Assembly>(this._compositionModulesProvider.Modules != null ? this._compositionModulesProvider.Modules.Select<ICompositionModule, Assembly>(t => t.GetType().Assembly) : new Assembly[0]);
    }
}