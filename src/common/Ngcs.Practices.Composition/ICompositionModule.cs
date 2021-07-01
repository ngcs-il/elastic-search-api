using Ngcs.Practices.IoC;

namespace Ngcs.Practices.Composition
{
    public interface ICompositionModule
    {
        void RegisterModule(IIocContainer container);
    }
}