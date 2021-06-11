namespace Ngcs.Practices.Composition
{
    public interface ICompositionContainer : ICompositionModulesProvider
    {
        void Compose();
    }
}