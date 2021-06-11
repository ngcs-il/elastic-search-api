using System.ComponentModel.Composition;
using Solid.Practices.Composition;
using Solid.Practices.IoC;

namespace Sample.Server.TestModule
{
    [Export(typeof(ICompositionModule))]
    class Module : ICompositionModule
    {
        public void RegisterModule(IIocContainer container)
        {
            
        }
    }
}
