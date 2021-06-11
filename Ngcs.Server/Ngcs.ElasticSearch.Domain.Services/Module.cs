using System.ComponentModel.Composition;
using System.Diagnostics;
using Ngcs.Practices.Composition;
using Ngcs.Practices.IoC;

namespace Ngcs.ElasticSearch.Domain.Services
{
    [Export(typeof(ICompositionModule))]
    class Module : ICompositionModule
    {
        public void RegisterModule(IIocContainer container)
        {
            Debug.WriteLine(("Module!!"));
        }
    }
}