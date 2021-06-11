using System.Collections.Generic;
using System.Reflection;

namespace Ngcs.Practices.Composition
{
    public interface IAssembliesReadOnlyResolver
    {
        IEnumerable<Assembly> GetAssemblies();
    }
}