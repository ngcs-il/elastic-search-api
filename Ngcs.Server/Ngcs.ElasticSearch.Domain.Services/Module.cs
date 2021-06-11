using System.ComponentModel.Composition;
using Ngcs.ElasticSearch.Domain.Contracts;
using Ngcs.Practices.Composition;
using Ngcs.Practices.IoC;

namespace Ngcs.ElasticSearch.Domain.Services
{
    [Export(typeof(ICompositionModule))]
    class Module : ICompositionModule
    {
        public void RegisterModule(IIocContainer container)
        {
            container.RegisterSingleton<IValueService, ValueService>();
        }
    }
}