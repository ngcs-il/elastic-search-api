using System.Collections.Generic;

namespace Ngcs.Practices.Composition
{
    public interface ICompositionModulesProvider
    {
        IEnumerable<ICompositionModule> Modules { get; }
    }
}